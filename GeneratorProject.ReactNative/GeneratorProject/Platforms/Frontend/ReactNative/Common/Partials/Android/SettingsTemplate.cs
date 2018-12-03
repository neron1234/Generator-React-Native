using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class SettingsTemplate : TemplateBase
    {
        public SettingsTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "android\\settings.gradle";
    }
}
