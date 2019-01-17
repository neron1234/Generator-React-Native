using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ActionTypesTemplate : TemplateBase
    {
        public ActionTypesTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
        }

        public override string OutputPath => "App\\Actions\\ActionTypes.js";
    }
}
