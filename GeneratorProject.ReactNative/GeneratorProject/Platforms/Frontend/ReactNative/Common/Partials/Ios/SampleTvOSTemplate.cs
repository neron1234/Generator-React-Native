using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class SampleTvOSTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public SampleTvOSTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}.xcodeproj\xcshareddata\xcschemes\Sample-tvOS.xcscheme", _smartAppInfo.Id.ToPascalCase());
    }
}
