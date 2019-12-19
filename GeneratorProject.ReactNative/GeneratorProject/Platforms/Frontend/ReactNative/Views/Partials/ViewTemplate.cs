using Common.Generator.Framework.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ViewTemplate : TemplateBase
    {
        private string _smartAppTitle { get; set; }
        private string _viewModelSuffix { get; set; }
        private string _apiSuffix { get; set; }
        private ConcernInfo _concern { get; set; }
        private LayoutInfo _layout { get; set; }
        private LanguageList _languages { get; set; }
        private ApiList _api { get; set; }
        private List<string> apiIds { get; set; }

        public ViewTemplate(string smartAppTitle, ConcernInfo concern, LayoutInfo layout, LanguageList languages, ApiList api, string apiSuffix, string viewModelSuffix)
        {
            _smartAppTitle = smartAppTitle;
            _concern = concern;
            _layout = layout;
            _languages = languages;
            _api = api;
            _viewModelSuffix = viewModelSuffix.ToPascalCase();
            _apiSuffix = apiSuffix.ToPascalCase();
            apiIds = GetApiIds(_layout);
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

        public override string OutputPath => "App\\Screens";
    }
}
