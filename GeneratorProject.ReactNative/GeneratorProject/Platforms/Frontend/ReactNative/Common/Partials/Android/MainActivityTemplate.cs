using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class MainActivityTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public MainActivityTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"android\app\src\main\java\com\{0}\MainActivity.java", _smartAppInfo.Id.ToLower());
    }
}