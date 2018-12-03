using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ProjectTemplate : TemplateBase
    {
        public ProjectTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "android\\.project";
    }
}
