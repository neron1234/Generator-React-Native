using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "ReducersWorkflowId", Order = 7)]
    public class ReducersWorkflow : IWorkflow
    {
        public string Id => "ReducersWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ReducersWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}