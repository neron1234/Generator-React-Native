using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Common.Generator.Framework.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class ReducersWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ReducersWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ReducersWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative reducers and initial states");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformReducers(smartApp);
                TransformInitialStates(smartApp);
                TransformCombineReducer(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformReducers(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null && smartApp.Api.Any())
            {
                foreach (var api in smartApp.Api)
                {
                    ReducersTemplate reducersTemplate = new ReducersTemplate(smartApp, api);
                    _writingService.WriteFile(Path.Combine(_context.BasePath, reducersTemplate.OutputPath, api.Id.ToPascalCase() + "Reducer.js"), reducersTemplate.TransformText());
                }
            }
        }

        private void TransformInitialStates(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                InitialStateTemplate initialStateTemplate = new InitialStateTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, initialStateTemplate.OutputPath), initialStateTemplate.TransformText());
            }
        }

        private void TransformCombineReducer(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                CombineReducerTemplate combineReducerTemplate = new CombineReducerTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, combineReducerTemplate.OutputPath), combineReducerTemplate.TransformText());
            }
        }
    }
}
