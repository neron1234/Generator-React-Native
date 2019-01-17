using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class CommonWorkflowTest: BaseGeneratorTest, IDisposable
    {
        public CommonWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<CommonWorkflow>();
            _container.RegisterType<CommonWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("CommonWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}