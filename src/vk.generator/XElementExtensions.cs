using System.Xml.Linq;

namespace Vk.Generator
{
    public static class XElementExtensions
    {
        public static string GetNameAttribute(this XElement xe)
        {
            return xe.Attribute("name").Value;
        }

        public static string GetNameElement(this XElement xe)
        {
            var aliasAttr = xe.Attribute("alias");
            if (aliasAttr != null)
                return null;

            return xe.Element("name").Value;
        }

        public static string GetTypeElement(this XElement xe)
        {
            return xe.Element("type").Value;
        }

        public static string GetTypeAttributeOrNull(this XElement xe)
        {
            return xe.Attribute("type")?.Value;
        }

        public static bool GetOptionalAttributeOrFalse(this XElement xe)
        {
            var attr = xe.Attribute("optional");
            return attr != null
                ? attr.Value == "true"
                : false;
        }

        public static bool HasCategoryAttribute(this XElement xe, string value)
        {
            var attr = xe.Attribute("category");
            return attr != null && attr.Value == value;
        }

        public static bool IsAliasAttribute(this XElement xe)
        {
            var attr = xe.Attribute("alias");
            return attr != null;
        }

        public static bool HasApiAttribute(this XElement xe, string value)
        {
            var attr = xe.Attribute("api");
            return attr != null && attr.Value == value;
        }
    }
}
