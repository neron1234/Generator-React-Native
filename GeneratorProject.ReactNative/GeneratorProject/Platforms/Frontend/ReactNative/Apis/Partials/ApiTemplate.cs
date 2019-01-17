using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ApiTemplate : TemplateBase
    {
        private ApiInfo _api { get; set; }

        public ApiTemplate(SmartAppInfo smartApp, ApiInfo api) : base(smartApp)
        {
            _api = api;
        }

        public override string OutputPath => "App\\Api";
    }
}
