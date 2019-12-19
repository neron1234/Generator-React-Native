using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class InfoPlistTestsTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public InfoPlistTestsTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}Tests\Info.plist", _smartAppInfo.Id.ToPascalCase());
    }
}
