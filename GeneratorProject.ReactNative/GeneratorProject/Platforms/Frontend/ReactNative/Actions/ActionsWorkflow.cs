using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "ActionsWorkflowId", Order = 1)]
    public class ActionsWorkflow : IWorkflow
    {
        public string Id => "ActionsWorkflowId";
        public int Version => 1;
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.StartWith<ActionsWritingSteps>()
                .Then<WorkflowEndStepBase>();
        }
    }
}