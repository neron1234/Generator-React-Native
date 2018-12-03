using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "NavigationWorkflowId", Order = 6)]
    public class NavigationWorkflow : IWorkflow
    {
        public string Id => "NavigationWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<NavigationWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}