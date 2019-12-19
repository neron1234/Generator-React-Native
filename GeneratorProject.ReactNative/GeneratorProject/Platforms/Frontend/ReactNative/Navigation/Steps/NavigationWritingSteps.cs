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
using Common.Generator.Framework.Extensions;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{ 
    public class NavigationWritingSteps: StepBodyAsync
    {
    private readonly ISessionContext _context;
    private readonly IWriting _writingService;
    private readonly IWorkflowNotifier _workflowNotifier;

    public NavigationWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

        _workflowNotifier.Notify(nameof(NavigationWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative navigations");

        if (_context.BasePath != null && _context.GeneratorPath != null)
        {
                TransformNavigations(smartApp);
                TransformMainStackNavigator(smartApp);
                TransformAuthStackNavigator(smartApp);
                TransformAppNavigator(smartApp);
            }
        return Task.FromResult(ExecutionResult.Next());
    }

        private void TransformNavigations(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
                {
                    foreach (ConcernInfo concern in smartApp.Concerns)
                    {
                        NavigationTemplate navigationTemplate = new NavigationTemplate(smartApp, concern);

                        string filename = concern.Id.ToPascalCase() + "StackNavigator.js";

                        _writingService.WriteFile(Path.Combine(_context.BasePath, navigationTemplate.OutputPath, filename), navigationTemplate.TransformText());
                    }
                }
        }

        private void TransformMainStackNavigator(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
                {
                    AppMainStackNavigator appMainStackNavigator = new AppMainStackNavigator(smartApp);
                    _writingService.WriteFile(Path.Combine(_context.BasePath, appMainStackNavigator.OutputPath), appMainStackNavigator.TransformText());
                }
        }

        private void TransformAuthStackNavigator(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                AuthStackNavigator authStackNavigator = new AuthStackNavigator(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, authStackNavigator.OutputPath), authStackNavigator.TransformText());
            }
        }

        private void TransformAppNavigator(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                AppNavigator appNavigator = new AppNavigator(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, appNavigator.OutputPath), appNavigator.TransformText());
            }
        }
    }
}
