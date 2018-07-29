using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class RestApiTemplate : TemplateBase
    {
        public RestApiTemplate(SmartAppInfo smartApp): base(smartApp)
        {

        }

        public override string OutputPath => "App\\Api\\RestApi.js";
    }
}
