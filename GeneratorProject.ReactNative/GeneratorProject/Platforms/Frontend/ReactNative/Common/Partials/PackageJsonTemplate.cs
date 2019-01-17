using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class PackageJsonTemplate: TemplateBase
    {
        public PackageJsonTemplate(SmartAppInfo smartApp):base(smartApp)
        {

        }

        public override string OutputPath => "package.json";
    }
}
