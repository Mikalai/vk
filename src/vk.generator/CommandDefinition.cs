using System;
using System.Linq;
using System.Xml.Linq;

namespace Vk.Generator
{
    public class CommandDefinition : IEquatable<CommandDefinition>
    {
        public string Name { get; }
        public TypeSpec ReturnType { get; }
        public ParameterDefinition[] Parameters { get; }
        public string[] SuccessCodes { get; }
        public string[] ErrorCodes { get; }
        public bool IsVariant { get; }

        public CommandDefinition(string name, TypeSpec returnType, ParameterDefinition[] parameters, string[] successCodes, string[] errorCodes, bool isVariant)
        {
            Require.NotNull(parameters);
            Require.NotNull(successCodes);
            Require.NotNull(errorCodes);

            Name = name;
            ReturnType = returnType;
            Parameters = parameters;
            SuccessCodes = successCodes;
            ErrorCodes = errorCodes;
            IsVariant = isVariant;
        }

        public override bool Equals(object obj)
        {
            if (obj is not CommandDefinition other)
                return false;

            return Name == other.Name
                && IsVariant == other.IsVariant
                && Equals(ReturnType, other.ReturnType)
                && Parameters.SequenceEqual(other.Parameters)
                && SuccessCodes.SequenceEqual(other.SuccessCodes)
                && ErrorCodes.SequenceEqual(other.ErrorCodes);
        }

        public override int GetHashCode()
        {
            int hash = Name?.GetHashCode() ?? 0;
            hash = (hash * 397) ^ (ReturnType?.GetHashCode() ?? 0);
            hash = (hash * 397) ^ IsVariant.GetHashCode();

            foreach (var param in Parameters)
                hash = (hash * 397) ^ (param?.GetHashCode() ?? 0);

            foreach (var code in SuccessCodes)
                hash = (hash * 397) ^ (code?.GetHashCode() ?? 0);

            foreach (var code in ErrorCodes)
                hash = (hash * 397) ^ (code?.GetHashCode() ?? 0);

            return hash;
        }

        public static CommandDefinition CreateFromXml(XElement xe)
        {
            Require.Equal("command", xe.Name);

            var aliasAttr = xe.Attribute("alias");
            if (aliasAttr != null)
                return null;

            var proto = xe.Element("proto");
            string name = proto.Element("name").Value;
            string returnTypeName = proto.Element("type").Value;
            TypeSpec returnType = new TypeSpec(returnTypeName);

            var successAttr = xe.Attribute("successcodes");
            string[] successCodes = successAttr != null
                ? successAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            var errorAttr = xe.Attribute("errorcodes");
            string[] errorCodes = errorAttr != null
                ? errorAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            ParameterDefinition[] parameters = xe.Elements("param")
                .Where(o => !o.HasApiAttribute("vulkansc"))
                .Select(paramXml => ParameterDefinition.CreateFromXml(paramXml)).ToArray();

            return new CommandDefinition(name, returnType, parameters, successCodes, errorCodes, false);
        }

        public string GetParametersSignature(TypeNameMappings tnm)
        {
            return string.Join(", ", Parameters.Select(pd => pd.GetMappedAndNormalizedString(tnm)));
        }

        public string GetParametersSignature()
        {
            return string.Join(", ", Parameters.Select(pd => pd.ToString()));
        }

        public override string ToString()
        {
            string paramSig = GetParametersSignature();
            return $"{ReturnType} {Name}({paramSig})";
        }

        public bool Equals(CommandDefinition other)
        {
            return Equals((object)other);
        }
    }
}
