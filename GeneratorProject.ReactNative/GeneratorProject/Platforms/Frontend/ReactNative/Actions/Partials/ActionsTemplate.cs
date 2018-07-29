
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class ActionsTemplate : TemplateBase
    {
        private ConcernInfo _concern { get; set; }
        private LayoutInfo _layout { get; set; }

        public ActionsTemplate(ConcernInfo concern, LayoutInfo layout)
        {
            _concern = concern;
            _layout = layout;
        }

        /// <summary>
        /// Check if the type given is a model or a primitive type. Return a string.
        /// </summary>
        /// <param name="type">A type.</param>
        public string IsModel(string type)
        {
            string result = "";
            switch (type.ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                default: result = ""; break;
            }
            return result;
        }

        /// <summary>
        /// Check if the type given is a model or a primitive type. Return a boolean.
        /// </summary>
        /// <param name="type">A type.</param>
        public bool IsModelBool(string type)
        {
            bool result = false;
            switch (type.ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                default: result = true; break;
            }
            return result;
        }

        /// <summary>
        /// Check if the action type given is a data action or not. Return a boolean.
        /// </summary>
        /// <param name="actionType">An action type.</param>
        public bool IsDataAction(string actionType)
        {
            bool result = false;
            switch (actionType.ToLower())
            {
                case "dataget":
                case "datalist":
                case "datacreate":
                case "dataupdate":
                case "datadelete":
                    result = true; break;
            }
            return result;
        }

        public override string OutputPath => "App\\Actions";
    }
}
