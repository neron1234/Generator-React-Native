using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class BuildGradleTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }
        public BuildGradleTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => "android\\app\\build.gradle";
    }
}
