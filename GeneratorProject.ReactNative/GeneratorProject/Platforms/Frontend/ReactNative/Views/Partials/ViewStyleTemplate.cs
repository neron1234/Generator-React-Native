using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ViewStyleTemplate : TemplateBase
    {
        public ViewStyleTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
        }

        public override string OutputPath => "App\\Screens\\Styles\\StyleSheet.js";
    }
}
