using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.NavigationActivityName, Order = 24)]
    public partial class AuthStackNavigator: TemplateBase
    {
        public AuthStackNavigator(SmartAppInfo smartApp) : base(smartApp)
        {
        }

        public override string OutputPath => "App\\Navigation\\AuthStackNavigator.js";
    }
}
