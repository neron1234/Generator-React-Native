using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "ApiWorkflowId", Order = 2)]
    public class ApiWorkflow : IWorkflow
    {
        public string Id => "ApiWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ApiWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}