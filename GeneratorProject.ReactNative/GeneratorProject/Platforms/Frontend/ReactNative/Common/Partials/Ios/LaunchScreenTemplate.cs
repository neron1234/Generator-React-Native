using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class LaunchScreenTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public LaunchScreenTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}\Base.lproj\LaunchScreen.xib", _smartAppInfo.Id.ToPascalCase());
    }
}