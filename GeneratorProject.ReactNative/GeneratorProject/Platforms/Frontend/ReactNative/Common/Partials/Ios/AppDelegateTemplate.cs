using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AppDelegateTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public AppDelegateTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}\AppDelegate.m", _smartAppInfo.Id.ToPascalCase());
    }
}