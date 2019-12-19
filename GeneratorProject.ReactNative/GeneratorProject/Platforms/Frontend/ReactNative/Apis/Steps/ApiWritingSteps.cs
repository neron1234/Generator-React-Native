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

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class ApiWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ApiWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ApiWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative apis and servicebase");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                string apiSuffix = GetApiSuffix();
                TransformServiceBase(smartApp, apiSuffix);
                TransformApis(smartApp, apiSuffix);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformServiceBase(SmartAppInfo smartApp, string apiSuffix)
        {
            if (smartApp != null)
            {
                RestApiTemplate serviceBaseTemplate = new RestApiTemplate(smartApp, apiSuffix);
                _writingService.WriteFile(Path.Combine(_context.BasePath, serviceBaseTemplate.OutputPath), serviceBaseTemplate.TransformText());
            }
        }

        private void TransformApis(SmartAppInfo smartApp, string apiSuffix)
        {
            if (smartApp != null && smartApp.Api != null && smartApp.Api.Count > 0)
                {
                   foreach (ApiInfo api in smartApp.Api)
                    {
                        if (api != null)
                        {
                            ApiTemplate serviceTemplate = new ApiTemplate(smartApp, api, apiSuffix);
                            _writingService.WriteFile(Path.Combine(_context.BasePath, serviceTemplate.OutputPath, api.Id + ".js"), serviceTemplate.TransformText());
                        }
                    }
                }
        }
        private string GetApiSuffix()
        {
            var apiSuffix = ((System.Collections.Generic.IDictionary<string, object>)_context.DynamicContext).ContainsKey("ApiSuffix") ? _context.DynamicContext.ApiSuffix as List<Answer> : new List<Answer>();
            return (apiSuffix != null && apiSuffix.Count > 0) ? apiSuffix.FirstOrDefault().Value : "Service";
        }

    }
}
