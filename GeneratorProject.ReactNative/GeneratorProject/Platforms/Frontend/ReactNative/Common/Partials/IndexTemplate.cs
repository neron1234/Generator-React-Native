using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class IndexTemplate : TemplateBase
    {
        public IndexTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "index.js";
    }
}

                                                                                                            