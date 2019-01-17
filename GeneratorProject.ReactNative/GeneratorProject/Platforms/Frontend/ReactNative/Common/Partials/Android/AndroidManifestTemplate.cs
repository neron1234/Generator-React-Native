using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AndroidManifestTemplate : TemplateBase
    {
        public AndroidManifestTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "android\\app\\src\\main\\AndroidManifest.xml";
    }
}