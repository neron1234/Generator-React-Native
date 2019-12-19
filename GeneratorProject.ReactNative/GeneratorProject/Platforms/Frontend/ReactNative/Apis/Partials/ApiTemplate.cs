using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using Common.Generator.Framework.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ApiTemplate : TemplateBase
    {
        private ApiInfo _api { get; set; }
        private string _apiSuffix { get; set; }

        public ApiTemplate(SmartAppInfo smartApp, ApiInfo api, string apiSuffix) : base(smartApp)
        {
            _api = api;
            _apiSuffix = apiSuffix.ToPascalCase();
        }

        public override string OutputPath => "App\\Api";
    }
}
