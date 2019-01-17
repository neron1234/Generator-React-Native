using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ApiWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ApiWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ApiWorkflow>();
            _container.RegisterType<ApiWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("ApiWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
