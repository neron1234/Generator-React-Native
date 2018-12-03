using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [WorkFlow(Id = "DataModelsWorkflowId", Order = 5)]
    public class DataModelsWorkflow : IWorkflow
    {
        public string Id => "DataModelsWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<DataModelsPromptingSteps>()
                 .WaitForAnswers(nameof(DataModelsPromptingSteps))
                 .Then<DataModelsWritingSteps>()
                 .Then<WorkFlowEndStepBase>();
        }
    }
}