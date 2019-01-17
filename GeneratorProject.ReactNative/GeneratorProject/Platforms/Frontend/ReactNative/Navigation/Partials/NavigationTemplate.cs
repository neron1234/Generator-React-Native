using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
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
