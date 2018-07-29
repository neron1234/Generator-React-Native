using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class ActionTypesTemplate : TemplateBase
    {
        public ActionTypesTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
        }

        public override string OutputPath => "App\\Actions\\ActionTypes.js";
    }
}
