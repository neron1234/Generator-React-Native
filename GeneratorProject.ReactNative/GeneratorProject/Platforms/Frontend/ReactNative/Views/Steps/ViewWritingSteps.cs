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
using System.Linq;
using System.Collections.Generic;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class ViewWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ViewWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ViewWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative views");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformViews(smartApp);
                TransformStyles(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformViews(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                string apiSuffix = GetApiSuffix();
                string viewModelSuffix = GetViewModelSuffix();

                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ViewTemplate viewTemplate = new ViewTemplate(smartApp.Title, concern, layout, smartApp.Languages, smartApp.Api, apiSuffix, viewModelSuffix);

                        string path = Path.Combine(_context.BasePath, viewTemplate.OutputPath, TextConverter.PascalCase(concern.Id));

                        _writingService.WriteFile(Path.Combine(path, TextConverter.PascalCase(layout.Id) + "Screen.js"), viewTemplate.TransformText());
                    }
                }
            }
        }

        private void TransformStyles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                ViewStyleTemplate viewStyleTemplate = new ViewStyleTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, viewStyleTemplate.OutputPath), viewStyleTemplate.TransformText());
            }
        }

        private string GetApiSuffix()
        {
            var apiSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ApiSuffix") ? _context.DynamicContext.ApiSuffix as List<Answer> : new List<Answer>();
            return (apiSuffix != null && apiSuffix.Count > 0) ? apiSuffix.FirstOrDefault().Value : "Service";
        }

        private string GetViewModelSuffix()
        {
            var viewModelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ViewModelSuffix") ? _context.DynamicContext.ViewModelSuffix as List<Answer> : new List<Answer>();
            return (viewModelSuffix != null && viewModelSuffix.Count > 0) ? viewModelSuffix.FirstOrDefault().Value : "ViewModel";
        }
    }
}
