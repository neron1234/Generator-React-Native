using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ActionsTemplate : TemplateBase
    {
        private ApiInfo _api { get; set; }
        private string _apiSuffix { get; set; }

        public ActionsTemplate(SmartAppInfo smartApp, ApiInfo api, string apiSuffix)
        {
            _api = api;
            _apiSuffix = apiSuffix;

        }
        public override string OutputPath => "App\\Actions";
    }
}
