using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ContainerWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ContainerWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ContainerWorkflow>();
            _container.RegisterType<ContainerWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("ContainerWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
