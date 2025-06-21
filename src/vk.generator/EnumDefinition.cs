using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Vk.Generator
{
    public class EnumDefinition
    {
        public string Name { get; set; }
        public EnumType Type { get; }
        public EnumValue[] Values { get; set; }

        public EnumDefinition Clone()
        {
            return new EnumDefinition(Name, Type, Values.Select(o => o.Clone()).ToArray());
        }

        public EnumDefinition(string name, EnumType type, EnumValue[] values)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
        }

        public static EnumDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            EnumType type;
            var typeAttr = xe.Attribute("type");
            if (typeAttr != null)
            {
                string typeString = xe.Attribute("type").Value;
                type = (EnumType)Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            string name = xe.Attribute("name").Value;
            EnumValue[] values = xe.Elements("enum")
                .Select(valuesx => EnumValue.CreateFromXml(valuesx, type == EnumType.Bitmask))
                .Where(o => o != null)
                .ToArray();
            return new EnumDefinition(name, type, values);
        }

        public override string ToString()
        {
            return $"Enum: {Name} ({Type})[{Values.Length}]";
        }

        internal static EnumDefinition CreateFromAliasXml(EnumDefinition[] enumDefinitions, List<string> bitmaskTypes, List<TypedefDefinition> typedefDefinitions, XElement xe)
        {
            var aliasName = xe.Attribute("alias").Value;
            var newName = xe.Attribute("name").Value;
            var alias = enumDefinitions.Where(o => o.Name == aliasName).FirstOrDefault();
            if (alias == null)
            {
                var typedef = typedefDefinitions.Where(o => o.Name == aliasName).First();
                if (typedef.Requires == null)
                {
                    // it is just a typedef
                    typedefDefinitions.Add(new TypedefDefinition(xe.Attribute("name").Value, null, typedef.Type));
                    return null;
                }
                else
                {
                    alias = enumDefinitions.Where(o => o.Name == typedef.Requires).First();
                    typedefDefinitions.Add(new TypedefDefinition(xe.Attribute("name").Value, null, typedef.Type));
                    return null;
                }
            }

            var newEnum = alias.Clone();
            newEnum.Name = newName;

            string oldSuffix = "";
            string newSuffix = "";

            int i = 0;

            for (; i < aliasName.Length && i < newEnum.Name.Length; ++i)
            {
                if (aliasName[i] != newEnum.Name[i])
                {
                    break;
                }
            }

            oldSuffix = aliasName.Substring(i).ToUpper();
            newSuffix = newEnum.Name.Substring(i).ToUpper();

            foreach (var value in newEnum.Values)
            {
                if (string.IsNullOrEmpty(oldSuffix))
                    value.Name = value.Name + "_" + newSuffix;
                else
                    value.Name = value.Name.Replace(oldSuffix, newSuffix);
            }

            if (newEnum.Type == EnumType.Bitmask)
                bitmaskTypes.Add(newEnum.Name);

            return newEnum;
        }
    }

    public enum EnumType
    {
        Bitmask,
        Enum,
        Constants,
    }

    public class EnumValue
    {
        public string Name { get; set; }
        public int ValueOrBitPosition { get; set; }
        public string Comment { get; }

        public EnumValue Clone()
        {
            return new EnumValue(Name, ValueOrBitPosition, Comment);
        }

        public override string ToString()
        {
            return $"{Name}:{ValueOrBitPosition} // {Comment}";
        }
        public EnumValue(string name, int value, string comment)
        {
            Name = name;
            ValueOrBitPosition = value;
            Comment = comment;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Name);
            hash.Add(ValueOrBitPosition);
            hash.Add(Comment);
            return hash.ToHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is EnumValue e)
            {
                return e.Name == Name && e.ValueOrBitPosition == ValueOrBitPosition && e.Comment == Comment;
            }
            return false;
        }

        public static EnumValue CreateFromXml(XElement xe, bool isBitmask)
        {
            Require.NotNull(xe);

            string name = xe.Attribute("name").Value;

            var aliasAttr = xe.Attribute("alias");
            if (aliasAttr != null)
                return null;

            int value;
            string valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = int.Parse(valueStr, System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    value = int.Parse(valueStr);
                }
            }
            else
            {
                string bitposStr = xe.Attribute("bitpos").Value;
                value = 1 << int.Parse(bitposStr);
            }

            var commentAttr = xe.Attribute("comment");
            string comment = commentAttr != null ? commentAttr.Value : string.Empty;
            return new EnumValue(name, value, comment);
        }
    }
}
