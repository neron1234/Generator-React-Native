using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class SampleTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public SampleTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}.xcodeproj\xcshareddata\xcschemes\Sample.xcscheme", _smartAppInfo.Id.ToPascalCase());
    }
}