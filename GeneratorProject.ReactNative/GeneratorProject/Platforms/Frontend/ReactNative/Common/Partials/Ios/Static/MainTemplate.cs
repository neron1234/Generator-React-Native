using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class MainTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public MainTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}\main.m", _smartAppInfo.Id.ToPascalCase());
    }
}