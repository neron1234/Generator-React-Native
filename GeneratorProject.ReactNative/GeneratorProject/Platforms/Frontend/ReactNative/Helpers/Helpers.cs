using Mobioos.Scaffold.BaseGenerators.Helpers;
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
            return Regex.Replace(TextConverter.PascalCase(input), "([A-Z])", " $1", RegexOptions.Compiled).Trim();
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
    }
}
