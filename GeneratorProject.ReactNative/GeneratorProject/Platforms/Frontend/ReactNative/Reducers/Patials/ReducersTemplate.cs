using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ReducersTemplate : TemplateBase
    {
        private ApiInfo _api { get; set; }

        public ReducersTemplate(SmartAppInfo smartApp, ApiInfo api)
        {
            _api = api;
        }

        public override string OutputPath => "App\\Reducers";
    }
}

