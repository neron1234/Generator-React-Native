using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "ReducersWorkflowId", Order = 7)]
    public class ReducersWorkflow : IWorkflow
    {
        public string Id => "ReducersWorkflowId";
        public int Version => 1;
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.StartWith<ReducersWritingSteps>()
                .Then<WorkflowEndStepBase>();
        }
    }
}