using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AppMainStackNavigator: TemplateBase
    {
        public AppMainStackNavigator(SmartAppInfo smartApp) : base(smartApp)
        {
        }

        public override string OutputPath => "App\\Navigation\\AppMainStackNavigator.js";
    }
}
