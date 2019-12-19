﻿using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Workflow(Id = "ContainerWorkflowId", Order = 4)]
    public class ContainerWorkflow : IWorkflow
    {
        public string Id => "ContainerWorkflowId";
        public int Version => 1;
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder.StartWith<ContainerWritingSteps>()
                .Then<WorkflowEndStepBase>();
        }
    }
}