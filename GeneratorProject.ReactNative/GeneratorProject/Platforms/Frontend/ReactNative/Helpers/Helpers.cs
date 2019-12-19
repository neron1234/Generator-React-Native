using Common.Generator.Framework.Extensions;
using System.Text.RegularExpressions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public static class Helper
    {
        /// <summary>
        /// Seperates Pascal Case string to space seperated words
        /// </summary>
        public static string WordSeperator(string input)
        {
            return Regex.Replace(input.ToPascalCase(), "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }

        public static string GetHtmlType(string type)
        {
            string htmlType = type;

            switch (type)
            {
                case "string": htmlType = "text"; break;
            }

            return htmlType;
        }

        public static bool IsModelBool(string type)
        {
            bool result = false;
            switch (type.ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                case "integer": break;
                default: result = true; break;
            }
            return result;
        }
    }
}
