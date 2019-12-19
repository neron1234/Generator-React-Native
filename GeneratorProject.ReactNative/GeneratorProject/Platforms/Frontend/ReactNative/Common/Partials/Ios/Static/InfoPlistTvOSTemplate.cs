using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class InfoPlistTvOSTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public InfoPlistTvOSTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}-tvOS\Info.plist", _smartAppInfo.Id.ToPascalCase());
    }
}
