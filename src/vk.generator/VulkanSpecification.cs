using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Vk.Generator
{
    public class VulkanSpecification
    {
        public CommandDefinition[] Commands { get; }
        public ConstantDefinition[] Constants { get; }
        public TypedefDefinition[] Typedefs { get; }
        public EnumDefinition[] Enums { get; }
        public StructureDefinition[] Structures { get; }
        public StructureDefinition[] Unions { get; }
        public HandleDefinition[] Handles { get; }
        public string[] BitmaskTypes { get; }
        public Dictionary<string, string> BaseTypes { get; }
        public ExtensionDefinition[] Extensions { get; }
        public ExtensionDefinition[] Features { get; }

        public VulkanSpecification(
            CommandDefinition[] commands,
            ConstantDefinition[] constants,
            TypedefDefinition[] typedefs,
            EnumDefinition[] enums,
            StructureDefinition[] structures,
            StructureDefinition[] unions,
            HandleDefinition[] handles,
            string[] bitmaskTypes,
            Dictionary<string, string> baseTypes,
            ExtensionDefinition[] extensions,
            ExtensionDefinition[] features)
        {
            Commands = commands;
            Constants = constants;
            Typedefs = typedefs;
            Enums = enums;
            Structures = structures;
            Unions = unions;
            Handles = handles;
            BitmaskTypes = bitmaskTypes;
            BaseTypes = baseTypes;
            Extensions = extensions;
            Features = features;
            AddExtensionEnums(Enums.ToList(), Extensions);
            AddExtensionEnums(Enums.ToList(), Features);
        }
        public static VulkanSpecification LoadFromXmlStream(Stream specFileStream)
        {
            var spec = XDocument.Load(specFileStream);
            var registry = spec.Element("registry");
            var commands = registry.Element("commands");
            CommandDefinition[] commandDefinitions = commands.Elements("command")
                .Where(commandx => !commandx.HasApiAttribute("vulkansc"))
                .Select(commandx => CommandDefinition.CreateFromXml(commandx))
                .Where(o => o != null) // skip aliases
                .ToArray();

            ConstantDefinition[] constantDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.Attribute("name").Value == "API Constants")
                .SelectMany(enumx => enumx.Elements("enum"))
                .Select(enumxx => ConstantDefinition.CreateFromXml(enumxx)).ToArray();

            var types = registry.Elements("types");
            var typedefDefinitions = types.Elements("type").Where(xe => xe.Value.Contains("typedef") && xe.HasCategoryAttribute("bitmask") && !xe.HasApiAttribute("vulkansc"))
                .Select(xe2 => TypedefDefinition.CreateFromXml(xe2)).ToList();

            var enumDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.GetTypeAttributeOrNull() == "enum" || enumx.GetTypeAttributeOrNull() == "bitmask")
                .Select(enumx => EnumDefinition.CreateFromXml(enumx)).ToArray();

            StructureDefinition[] structures = types.Elements("type").Where(typex => typex.HasCategoryAttribute("struct"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            StructureDefinition[] unions =
                types.Elements("type")
                .Where(typex => typex.HasCategoryAttribute("union"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            HandleDefinition[] handles = types.Elements("type").Where(typex => typex.HasCategoryAttribute("handle"))
                .Select(typex => HandleDefinition.CreateFromXml(typex))
                .Where(o => o != null)
                .ToArray();

            var bitmaskTypes = types.Elements("type").Where(typex => typex.HasCategoryAttribute("bitmask"))
                .Select(typex => typex.GetNameElement())
                .Where(o => o != null)
                .ToList();

            Dictionary<string, string> baseTypes = types.Elements("type").Where(typex => typex.HasCategoryAttribute("basetype"))
                .Where(o => o.GetNameElement() != null && o.Element("type") != null)
                .ToDictionary(
                    typex => typex.GetNameElement(),
                    typex => typex.Element("type").Value);

            var enumAliasesDefinitions = types.Elements("type")
                .Where(enumx => (enumx.HasCategoryAttribute("enum") || enumx.HasCategoryAttribute("bitmask")) && enumx.IsAliasAttribute())
                .Select(enumx => EnumDefinition.CreateFromAliasXml(enumDefinitions, bitmaskTypes, typedefDefinitions, enumx))
                .Where(o => o != null)
                .ToArray();

            enumDefinitions = enumDefinitions.Concat(enumAliasesDefinitions).OrderBy(o => o.Name).ToArray();

            ExtensionDefinition[] extensions = registry.Element("extensions").Elements("extension")
                .Select(xe => ExtensionDefinition.CreateFromXml(xe)).ToArray();

            ExtensionDefinition[] features = registry.Elements("feature")
                .Select(xe => ExtensionDefinition.CreateFromXml(xe)).ToArray();

            return new VulkanSpecification(
                commandDefinitions,
                constantDefinitions,
                typedefDefinitions.ToArray(),
                enumDefinitions,
                structures,
                unions,
                handles,
                bitmaskTypes.ToArray(),
                baseTypes,
                extensions,
                features);
        }

        private void AddExtensionEnums(List<EnumDefinition> enums, ExtensionDefinition[] extensions)
        {
            foreach (ExtensionDefinition exDef in extensions)
            {
                if (exDef.Name == "VK_KHX_device_group")
                {

                }

                foreach (var enumEx in exDef.EnumExtensions)
                {
                    EnumDefinition enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    int value = int.Parse(enumEx.Value);
                    var newValue = new EnumValue(enumEx.Name, value, null);
                    bool exists = false;

                    for (var i = 0; i < enumDef.Values.Length; ++i)
                    {
                        if (enumDef.Values[i].Name == newValue.Name && enumDef.Values[i].ValueOrBitPosition != newValue.ValueOrBitPosition)
                        {
                            enumDef.Values[i].ValueOrBitPosition = newValue.ValueOrBitPosition;
                            exists = true;
                            break;
                        }
                        else if (enumDef.Values[i].Name == newValue.Name && enumDef.Values[i].ValueOrBitPosition == newValue.ValueOrBitPosition)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        enumDef.Values = enumDef.Values.Append(newValue).ToArray();
                    }
                }
            }
        }

        private EnumDefinition GetEnumDef(IEnumerable<EnumDefinition> enums, string name)
        {
            return enums.Single(ed => ed.Name == name);
        }
    }
}
