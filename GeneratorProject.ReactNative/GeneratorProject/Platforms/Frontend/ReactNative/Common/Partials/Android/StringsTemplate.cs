using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class StringsTemplate : TemplateBase
    {
        public StringsTemplate(SmartAppInfo smartApp) : base(smartApp)
        {

        }

        public override string OutputPath => "android\\app\\src\\main\\res\\values\\strings.xml";
    }
}
