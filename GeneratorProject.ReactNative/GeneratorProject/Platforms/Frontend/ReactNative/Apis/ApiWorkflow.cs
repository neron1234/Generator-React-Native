using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseGenerators.Extensions;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "ApiWorkflowId", Order = 2)]
    public class ApiWorkflow : IWorkflow
    {
        public string Id => "ApiWorkflowId";
        public int Version => 1;
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.AddApiSuffixQuestion()
              .Then<ApiWritingSteps>()
              .Then<WorkflowEndStepBase>();
        }
    }
}