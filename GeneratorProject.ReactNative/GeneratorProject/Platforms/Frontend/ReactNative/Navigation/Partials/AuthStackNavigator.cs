using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AuthStackNavigator: TemplateBase
    {
        private string _rootScreen { get; set; }
        private string _rootScreenFolder { get; set; }

        public AuthStackNavigator(SmartAppInfo smartApp) : base(smartApp)
        {
            _rootScreenFolder = string.Empty;
            _rootScreen = string.Empty;

            SetRootScreen(smartApp);
        }

        private void SetRootScreen(SmartAppInfo smartApp)
        {
            if(smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
            {
                foreach(ConcernInfo concern in smartApp.Concerns)
                {
                    var layout = concern.Layouts.FirstOrDefault(l => l.IsRoot == true);
                    if(layout != null)
                    {
                        _rootScreen = layout.Id;
                        _rootScreenFolder = concern.Id;
                    }
                }
            }
        }
        public override string OutputPath => "App\\Navigation\\AuthStackNavigator.js";
    }
}
