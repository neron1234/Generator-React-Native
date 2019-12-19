using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Foundation.Prompt;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Common.Generator.Framework.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class ViewModelsWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ViewModelsWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
        {
            _context = context;
            _writingService = writingService;
            _workflowNotifier = workflowNotifier;
        }

        public override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            if (null == _context.Manifest)
                throw new ArgumentNullException(nameof(_context.Manifest));

            SmartAppInfo smartApp = _context.Manifest;

            _workflowNotifier.Notify(nameof(ViewModelsWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative view models");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformViewModels(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformViewModels(SmartAppInfo smartApp)
        {
           if (smartApp != null)
            {
                string modelSuffix = GetModelSuffix();
                string viewModelSuffix = GetViewModelSuffix();

                smartApp.Api.ToList()
                    .ForEach(api => api.Actions.ToList()
                    .ForEach(action =>
                    {
                        List<EntityInfo> viewmodels = action.GetApiActionViewModelsEntities();
                        TransformViewModel(viewmodels, viewModelSuffix, modelSuffix);

                    }));
           }

        }

        private void TransformViewModel(List<EntityInfo> dataModel, string viewModelSuffix, string modelSuffix)
        {
            if (dataModel != null)
            {
                dataModel.ForEach(model =>
                {
                    ViewModelTemplate viewModelTemplate = new ViewModelTemplate(model, viewModelSuffix, modelSuffix);
                    _writingService.WriteFile(Path.Combine(_context.BasePath, viewModelTemplate.OutputPath, model.Id.ToPascalCase() + "." + viewModelSuffix.ToPascalCase() + ".js"), viewModelTemplate.TransformText());
                });
            }
        }

        private string GetModelSuffix()
        {
            var modelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ModelSuffix") ? _context.DynamicContext.ModelSuffix as List<Answer> : new List<Answer>();
            return (modelSuffix != null && modelSuffix.Count > 0) ? modelSuffix.FirstOrDefault().Value : "Model";
        }

        private string GetViewModelSuffix()
        {
            var viewModelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ViewModelSuffix") ? _context.DynamicContext.ViewModelSuffix as List<Answer> : new List<Answer>();
            return (viewModelSuffix != null && viewModelSuffix.Count > 0) ? viewModelSuffix.FirstOrDefault().Value : "ViewModel";
        }
    }
}
