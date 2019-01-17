using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class MainApplicationTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public MainApplicationTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"android\app\src\main\java\com\{0}\MainApplication.java", _smartAppInfo.Id.ToLower());
    }
}