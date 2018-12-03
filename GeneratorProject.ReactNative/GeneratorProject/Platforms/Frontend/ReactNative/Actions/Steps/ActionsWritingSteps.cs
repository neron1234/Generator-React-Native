using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

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
            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
            {
                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ActionsTemplate actionsTemplate = new ActionsTemplate(concern, layout);

                        string path = Path.Combine(_context.BasePath, actionsTemplate.OutputPath, TextConverter.PascalCase(concern.Id));

                        _writingService.WriteFile(Path.Combine(path, TextConverter.PascalCase(layout.Id) + "Actions.js"), actionsTemplate.TransformText());
                    }
                }
            }
        }
    }
}
