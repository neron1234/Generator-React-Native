using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "CommonWorkflowId", Order = 3)]
    public class CommonWorkflow : IWorkflow
    {
        public string Id => "CommonWorkflowId";
        public int Version => 1;
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.StartWith<CommonWritingSteps>()
                .Then<WorkflowEndStepBase>();
        }
    }
}