using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseGenerators.Extensions;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "ViewWorkflowId", Order = 9)]
    public class ViewWorkflow : IWorkflow
    {
        public string Id => "ViewWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.AddViewModelsSuffixQuestion()
                 .Then<ViewWritingSteps>()
                .Then<WorkflowEndStepBase>();
        }
    }
}