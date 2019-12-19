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
    public class ContainerWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ContainerWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ContainerWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative containers");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformContainers(smartApp);
                
            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformContainers(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ContainerTemplate containerTemplate = new ContainerTemplate(concern, layout);

                        string path = Path.Combine(_context.BasePath, containerTemplate.OutputPath, concern.Id.ToPascalCase());

                        _writingService.WriteFile(Path.Combine(path, layout.Id.ToPascalCase() + "Container.js"), containerTemplate.TransformText());
                    }
                }
            }
        }

    }
}
