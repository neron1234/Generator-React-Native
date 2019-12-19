using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AppNavigator: TemplateBase
    {
        private string _rootScreen { get; set; }

        public AppNavigator(SmartAppInfo smartApp) : base(smartApp)
        {
            _rootScreen = string.Empty;

            SetRootScreen(smartApp);
        }

        private void SetRootScreen(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Any())
            {
                foreach (ConcernInfo concern in smartApp.Concerns)
                {
                    var layout = concern.Layouts.FirstOrDefault(l => l.IsRoot);
                    if (layout != null)
                    {
                        _rootScreen = concern.Id;
                    }
                }
            }
        }
        public override string OutputPath => "App\\Navigation\\AppNavigator.js";
    }
}
