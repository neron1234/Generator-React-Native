using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ContainerTemplate : TemplateBase
    {
        private ConcernInfo _concern { get; set; }
        private LayoutInfo _layout { get; set; }
        private List<ActionInfo> _navigationActions { get; set; }
        private List<string> apiIds { get; set; }

        public ContainerTemplate(ConcernInfo concern, LayoutInfo layout)
        {
            _concern = concern;
            _layout = layout;
            apiIds = GetApiIds(_layout);

            _navigationActions = _layout.Actions.Where(r => r.Type.ToLower()
                                    .Equals("navigation")).ToList<ActionInfo>();
        }

        public List<string> GetApiIds(LayoutInfo layout)
        {
            List<string> apiModels = new List<string>();
            if (layout != null && layout.Actions.AsEnumerable() != null)
            {
                foreach (ActionInfo action in layout.Actions.AsEnumerable())
                {
                    if (action.Api != "")
                    {
                        char delimiter = '.';
                        string[] apiSplitted = action.Api.Split(delimiter);
                        string apiAction = apiSplitted[0];
                        if (apiAction != null && !apiModels.AsEnumerable().Contains(apiAction))
                        {
                            apiModels.Add(apiAction);
                        }
                    }

                }
            }

            return apiModels;
        }
        public override string OutputPath => "App\\Containers";
    }
}

