using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "ViewWorkflowId", Order = 9)]
    public class ViewWorkflow : IWorkflow
    {
        public string Id => "ViewWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ViewWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}