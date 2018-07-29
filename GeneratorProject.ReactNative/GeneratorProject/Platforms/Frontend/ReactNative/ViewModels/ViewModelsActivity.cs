using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Infrastructure.Runtime;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 3)]
    public class ViewModelsActivity : GeneratorActivity
    {
        string _sessionId;

        public ViewModelsActivity(string name, string basePath) : base(name, basePath)
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


            TransformViewModels(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformViewModels(SmartAppInfo manifest)
        {
            if (manifest != null)
            {
                string modelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ModelSuffix) ? "Model" : Context.DynamicContext.ModelSuffix;
                string viewModelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ViewModelSuffix) ? "ViewModel" : Context.DynamicContext.ViewModelSuffix;
                List<EntityInfo> alreadyCreated = new List<EntityInfo>();

                manifest.Api.ToList()
                    .ForEach(api => api.Actions.ToList()
                    .ForEach(action =>
                    {
                        if (action.ReturnType != null && !alreadyCreated.Contains(action.ReturnType))
                        {
                            alreadyCreated.Add(action.ReturnType);
                            TransformViewModel(action.ReturnType, viewModelSuffix, modelSuffix);
                        }
                        action.Parameters.ToList()
                        .ForEach(parameter =>
                        {
                            if (parameter.DataModel != null && !alreadyCreated.Contains(parameter.DataModel))
                            {
                                alreadyCreated.Add(parameter.DataModel);
                                TransformViewModel(parameter.DataModel, viewModelSuffix, modelSuffix);
                            }
                        });
                    }));
            }
        }

        private void TransformViewModel(EntityInfo dataModel, string viewModelSuffix, string modelSuffix)
        {
            if (dataModel != null)
            {
                ViewModelTemplate viewModelTemplate = new ViewModelTemplate(dataModel, viewModelSuffix, modelSuffix);
                WriteFile(Path.Combine(BasePath, viewModelTemplate.OutputPath, TextConverter.PascalCase(dataModel.Id) + "." + TextConverter.PascalCase(viewModelSuffix) + ".js"), viewModelTemplate.TransformText());
            }
        }

        #endregion
    }
}

