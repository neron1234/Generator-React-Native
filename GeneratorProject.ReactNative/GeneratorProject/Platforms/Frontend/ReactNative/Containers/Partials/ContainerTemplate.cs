using System.Linq;
using System.Collections.Generic;

using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Foundation.Jade.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.FeaturesActivityName, Order = 24)]
    public partial class ContainerTemplate : TemplateBase
    {
        private ConcernInfo _concern { get; set; }
        private LayoutInfo _layout { get; set; }
        private List<ActionInfo> _navigationActions { get; set; }

        public ContainerTemplate(ConcernInfo concern, LayoutInfo layout)
        {
            _concern = concern;
            _layout = layout;
        
            _navigationActions = _layout.Actions.Where(r => r.Type.ToLower()
                                    .Equals("navigation")).ToList<ActionInfo>();
        }



        public override string OutputPath => "App\\Containers";
    }
}

