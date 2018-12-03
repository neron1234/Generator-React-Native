using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ActionsWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ActionsWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ActionsWorkflow>();
            _container.RegisterType<ActionsWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("ActionsWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
