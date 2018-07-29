using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class ReducersTemplate : TemplateBase
    {
        private ConcernInfo _concern { get; set; }
        private LayoutInfo _layout { get; set; }

        public ReducersTemplate(ConcernInfo concern, LayoutInfo layout)
        {
            _concern = concern;
            _layout = layout;
        }

        private string GetInitStateModelOfCurrentLayout(LayoutInfo layout)
        {
            string initialState = "initialState.";

            if (layout != null && layout.DataModel != null)
            {
                initialState = initialState + TextConverter.CamelCase(layout.DataModel.Id);
            }
            else
            {
                //If layout does not define any datamodel then return empty object as initial state
                initialState = initialState + "emptyModel";
            }

            return initialState;
        }

        public override string OutputPath => "App\\Reducers";
    }
}

