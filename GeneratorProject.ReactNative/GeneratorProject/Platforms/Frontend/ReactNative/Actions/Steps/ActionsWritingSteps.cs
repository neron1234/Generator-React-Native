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
using System.Collections.Generic;
using Mobioos.Foundation.Prompt;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class ActionsWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ActionsWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ActionsWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative actions");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformActions(smartApp);
            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformActions(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null && smartApp.Api.Any())
            {
                string apiSuffix = GetApiSuffix();

                foreach (var api in smartApp.Api)
                {
                    ActionsTemplate actionsTemplate = new ActionsTemplate(smartApp, api, apiSuffix);
                  _writingService.WriteFile(Path.Combine(_context.BasePath, actionsTemplate.OutputPath, api.Id.ToPascalCase() + apiSuffix  + "Actions.js"), actionsTemplate.TransformText());
                }
            }
        }

        private string GetApiSuffix()
        {
            var apiSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ApiSuffix") ? _context.DynamicContext.ApiSuffix as List<Answer> : new List<Answer>();

            return (apiSuffix != null && apiSuffix.Count > 0) ? apiSuffix.FirstOrDefault().Value : "Service";
        }
    }
}
