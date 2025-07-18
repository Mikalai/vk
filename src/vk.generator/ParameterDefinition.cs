﻿using System.Xml.Linq;

namespace Vk.Generator
{
    public class ParameterDefinition
    {
        public string Name { get; }
        public TypeSpec Type { get; }
        public ParameterModifier Modifier { get; }
        public bool IsOptional { get; }

        public override bool Equals(object obj)
        {
            if (obj is not ParameterDefinition other)
                return false;

            return Name == other.Name
                && Equals(Type, other.Type)
                && Modifier == other.Modifier
                && IsOptional == other.IsOptional;
        }

        public override int GetHashCode()
        {
            int hash = Name?.GetHashCode() ?? 0;
            hash = (hash * 397) ^ (Type?.GetHashCode() ?? 0);
            hash = (hash * 397) ^ Modifier.GetHashCode();
            hash = (hash * 397) ^ IsOptional.GetHashCode();
            return hash;
        }

        public ParameterDefinition(string name, TypeSpec type, ParameterModifier modifier, bool isOptional)
        {
            Name = name;
            Type = type;
            Modifier = modifier;
            IsOptional = isOptional;
        }

        public static ParameterDefinition CreateFromXml(XElement xe)
        {
            string name = xe.Element("name").Value;
            var optionalAttr = xe.Attribute("optional");
            bool isOptional = optionalAttr != null && optionalAttr.Value == "true";
            string typeName = xe.Element("type").Value;
            int pointerLevel = 0;
            if (xe.Value.Contains($"{typeName}**") || xe.Value.Contains($"{typeName}* const*"))
            {
                pointerLevel = 2;
            }
            else if (xe.Value.Contains($"{typeName}*"))
            {
                pointerLevel = 1;
            }

            TypeSpec type = new TypeSpec(typeName, pointerLevel);

            return new ParameterDefinition(name, type, ParameterModifier.None, isOptional);
        }

        public string GetMappedAndNormalizedString(TypeNameMappings tnm)
        {
            return $"{GetModifierString()}{Type.MapTypeSpec(tnm)} {Util.NormalizeFieldName(Name)}";
        }

        public string GetModifierString()
        {
            if (Modifier == ParameterModifier.Ref)
            {
                return "ref ";
            }
            else if (Modifier == ParameterModifier.Out)
            {
                return "out ";
            }
            else
            {
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return $"{GetModifierString()}{Type} {Name}";
        }
    }

    public enum ParameterModifier
    {
        None,
        Ref,
        Out
    }
}
