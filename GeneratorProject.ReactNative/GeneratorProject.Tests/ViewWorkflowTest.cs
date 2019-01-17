using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Foundation.Prompt;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ViewWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ViewWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ViewWorkflow>();
            _container.RegisterType<ViewWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            var answers = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "ApiSuffix",
                Type = AnswerType.Text,
                Value = "Service"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ApiSuffix", answers);

            var answers1 = new List<Answer>();
            answers1.Add(new Answer()
            {
                Name = "ViewModelSuffix",
                Type = AnswerType.Text,
                Value = "ViewModel"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ViewModelSuffix", answers1);

            string workflowId = await _workflowHost.StartWorkflow("ViewWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
