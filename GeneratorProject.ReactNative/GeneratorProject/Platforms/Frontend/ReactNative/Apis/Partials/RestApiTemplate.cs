using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class RestApiTemplate : TemplateBase
    {
        public RestApiTemplate(SmartAppInfo smartApp): base(smartApp)
        {

        }

        public override string OutputPath => "App\\Api\\RestApi.js";
    }
}
