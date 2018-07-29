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
    [Activity(Order = 8)]
    public class ReducersActivity : GeneratorActivity
    {
        string _sessionId;

        public ReducersActivity(string name, string basePath) : base(name, basePath)
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

            TransformReducers(smartApp);
            TransformInitialStates(smartApp);
            TransformCombineReducer(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformReducers(SmartAppInfo smartApp)
        {
            //if (smartApp != null)
            //{
            //    if (smartApp.Api != null && smartApp.Api.Count > 0)
            //    {
            //        foreach (ApiInfo api in smartApp.Api)
            //        {
            //            if (api != null)
            //            {
            //                ReducersTemplate reducersTemplate = new ReducersTemplate(smartApp, api);
            //                WriteFile(Path.Combine(BasePath, reducersTemplate.OutputPath, TextConverter.PascalCase(api.Id) + "Reducer.js"), reducersTemplate.TransformText());
            //            }
            //        }
            //    }
            //}

            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
            {
                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ReducersTemplate reducersTemplate = new ReducersTemplate(concern, layout);

                        string path = Path.Combine(BasePath, reducersTemplate.OutputPath, TextConverter.PascalCase(concern.Id));

                        WriteFile(Path.Combine(path, TextConverter.PascalCase(layout.Id) + "Reducer.js"), reducersTemplate.TransformText());
                    }
                }
            }
        }

        private void TransformInitialStates(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                InitialStateTemplate initialStateTemplate = new InitialStateTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, initialStateTemplate.OutputPath), initialStateTemplate.TransformText());
            }
        }

        private void TransformCombineReducer(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                CombineReducerTemplate combineReducerTemplate = new CombineReducerTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, combineReducerTemplate.OutputPath), combineReducerTemplate.TransformText());
            }
        }
        #endregion
    }
}
