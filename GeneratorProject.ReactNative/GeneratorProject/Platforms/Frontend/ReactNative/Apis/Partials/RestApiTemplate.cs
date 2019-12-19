using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using Common.Generator.Framework.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class RestApiTemplate : TemplateBase
    {
        private string _apiSuffix { get; set; }
        public RestApiTemplate(SmartAppInfo smartApp, string apiSuffix) : base(smartApp)
        {
            _apiSuffix = apiSuffix.ToPascalCase();
        }

        public override string OutputPath => "App\\Api\\Rest" + _apiSuffix + ".js";
    }
}
