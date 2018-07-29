using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 4)]
    public class ViewActivity : GeneratorActivity
    {
        string _sessionId;

        public ViewActivity(string name, string basePath) : base(name, basePath)
        {
        }

        #region GeneratorActivity Methods

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            _sessionId = "session 00002";

            await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            SmartAppInfo smartApp = Context.DynamicContext.Manifest;

            TransformViews(smartApp);
            TransformStyles(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformViews(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                string apiSuffix = string.IsNullOrEmpty(Context.DynamicContext.ApiSuffix) ? "Service" : Context.DynamicContext.ApiSuffix;
                string viewModelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ViewModelSuffix) ? "ViewModel" : Context.DynamicContext.ViewModelSuffix;


                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ViewTemplate viewTemplate = new ViewTemplate(smartApp.Title, concern, layout, smartApp.Languages, smartApp.Api, apiSuffix, viewModelSuffix);
                        
                        string path = Path.Combine(BasePath, viewTemplate.OutputPath, TextConverter.PascalCase(concern.Id));

                        WriteFile(Path.Combine(path, TextConverter.PascalCase(layout.Id) + "Screen.js"), viewTemplate.TransformText());
                    }
                }
            }
        }

        private void TransformStyles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                ViewStyleTemplate viewStyleTemplate = new ViewStyleTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, viewStyleTemplate.OutputPath), viewStyleTemplate.TransformText());
            }
        }

        #endregion
    }
}


