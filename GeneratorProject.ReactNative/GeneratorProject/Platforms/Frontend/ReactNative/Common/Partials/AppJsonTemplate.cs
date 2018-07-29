using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AppJsonTemplate : TemplateBase
    {
        public AppJsonTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "app.json";
    }
}

