using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Foundation.Prompt;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class DataModelsWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public DataModelsWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(DataModelsWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative data models");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformDataModel(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformDataModel(SmartAppInfo manifest)
        {
            string modelSuffix = GetModelSuffix();

            var entities = manifest.DataModel.Entities;

            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    if (entity != null)
                    {
                        DataModelTemplate template = new DataModelTemplate(entity, manifest.Id, modelSuffix);
                        _writingService.WriteFile(Path.Combine(_context.BasePath, template.OutputPath, TextConverter.PascalCase(entity.Id) + "." + modelSuffix + ".js"), template.TransformText());
                      
                    }
                }
            }
        }

        private string GetModelSuffix()
        {
            var modelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ModelSuffix") ? _context.DynamicContext.ModelSuffix as List<Answer> : new List<Answer>();
            return (modelSuffix != null && modelSuffix.Count > 0) ? modelSuffix.FirstOrDefault().Value : "Model";
        }
    }
}
