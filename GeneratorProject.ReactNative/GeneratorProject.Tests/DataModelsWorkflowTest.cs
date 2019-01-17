using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class DataModelsWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public DataModelsWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<DataModelsWorkflow>();
            _container.RegisterType<DataModelsWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            var answers = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "ModelSuffix",
                Type = AnswerType.Text,
                Value = "Model"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ModelSuffix", answers);

            string workflowId = await _workflowHost.StartWorkflow("DataModelsWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
