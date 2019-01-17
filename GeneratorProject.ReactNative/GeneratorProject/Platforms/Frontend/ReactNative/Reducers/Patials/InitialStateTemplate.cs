using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class InitialStateTemplate: TemplateBase
    {
        public InitialStateTemplate(SmartAppInfo smartApp) : base(smartApp)
        { 
        }

        public override string OutputPath => "App\\Reducers\\InitialState.js";
    }
}
