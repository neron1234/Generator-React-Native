using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class ApiTemplate : TemplateBase
    {
        private ApiInfo _api { get; set; }

        public ApiTemplate(SmartAppInfo smartApp, ApiInfo api) : base(smartApp)
        {
            _api = api;
        }

        //public bool IsModelBool(string type)
        //{
        //    bool result = false;
        //    switch (type.ToLower())
        //    {
        //        case "date": break;
        //        case "string": break;
        //        case "number": break;
        //        case "boolean": break;
        //        default: result = true; break;
        //    }
        //    return result;
        //}

        //public string GetRestMethod(string actionType)
        //{
        //    string result = "get";

        //    switch (actionType.ToLower())
        //    {
        //        case "dataget": result = "get"; break;
        //        case "datalist": result = "get"; break;
        //        case "datacreate": result = "post"; break;
        //        case "dataupdate": result = "put"; break;
        //        case "datadelete": result = "delete"; break;
        //    }
        //    return result;
        //}

        public override string OutputPath => "App\\Api";
    }
}
