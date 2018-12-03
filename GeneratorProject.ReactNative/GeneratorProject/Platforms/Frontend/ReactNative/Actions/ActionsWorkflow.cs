using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "ActionsWorkflowId", Order = 1)]
    public class ActionsWorkflow : IWorkflow
    {
        public string Id => "ActionsWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ActionsWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}