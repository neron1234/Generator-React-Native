using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class NavigationTemplate : TemplateBase
    {
        private ConcernInfo _concernInfo { get; set; }

        public NavigationTemplate(SmartAppInfo smartApp, ConcernInfo concernInfo) : base(smartApp)
        {
            _concernInfo = concernInfo;
        }

        public override string OutputPath => "App\\Navigation";
    }
}
