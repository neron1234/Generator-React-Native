using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Mobioos.Scaffold.BaseGenerators.Testing;
using Mobioos.Scaffold.Steps;
using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ReactNativeGeneratorTest
    {
        [Fact]
        public async Task Test()
        {
            var generatorTest = new GeneratorTestBuilder()
                .InitializeContext(
                  Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                  Path.Combine(
                     AppDomain.CurrentDomain.BaseDirectory,
                      "Manifest"),
                  Path.Combine(
                     Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                      "GeneratedCode"),
                        "ReactNativeGenerator")
                
                .AddAnswer("ModelSuffix",
                  new List<Answer>
                  {
                      new Answer
                      {
                         Name = "ModelSuffix",
                         Type = AnswerType.Text,
                         Value = "Model"
                      }
                  })

                .AddAnswer("ViewModelSuffix",
                  new List<Answer>
                  {
                      new Answer
                      {
                         Name = "ViewModelSuffix",
                         Type = AnswerType.Text,
                         Value = "ViewModel"
                      }
                  })

                .AddAnswer("ApiSuffix",
                  new List<Answer>
                  {
                      new Answer
                      {
                         Name = "ApiSuffix",
                         Type = AnswerType.Text,
                         Value = "Service"
                      }
                  })

                .RegisterStep<PromptingViewModelsSuffixStep>()
                .RegisterStep<WritingViewModelsSuffixStep>()
                .RegisterStep<PromptingApiSuffixStep>()
                .RegisterStep<WritingApiSuffixStep>()
                .RegisterStep<ActionsWritingSteps>()
                .RegisterStep<ApiWritingSteps>()
                .RegisterStep<CommonWritingSteps>()
                .RegisterStep<ContainerWritingSteps>()
                .RegisterStep<DataModelsPromptingSteps>()
                .RegisterStep<DataModelsWritingSteps>()
                .RegisterStep<NavigationWritingSteps>()
                .RegisterStep<ReducersWritingSteps>()
                .RegisterStep<ViewModelsWritingSteps>()
                .RegisterStep<ViewWritingSteps>()
                .Build();

            generatorTest.RegisterWorkflow<ActionsWorkflow>("ActionsWorkflowId");
            generatorTest.RegisterWorkflow<ApiWorkflow>("ApiWorkflowId");
            generatorTest.RegisterWorkflow<CommonWorkflow>("CommonWorkflowId");
            generatorTest.RegisterWorkflow<ContainerWorkflow>("ContainerWorkflowId");
            generatorTest.RegisterWorkflow<DataModelsWorkflow>("DataModelsWorkflowId");
            generatorTest.RegisterWorkflow<NavigationWorkflow>("NavigationWorkflowId");
            generatorTest.RegisterWorkflow<ReducersWorkflow>("ReducersWorkflowId");
            generatorTest.RegisterWorkflow<ViewModelsWorkflow>("ViewModelsWorkflowId");
            generatorTest.RegisterWorkflow<ViewWorkflow>("ViewWorkflowId");

            await generatorTest.Start();
        }
    }
}
