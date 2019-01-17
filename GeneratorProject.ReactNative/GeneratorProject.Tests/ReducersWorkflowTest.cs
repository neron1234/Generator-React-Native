using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
   public class ReducersWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ReducersWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ReducersWorkflow>();
            _container.RegisterType<ReducersWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("ReducersWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
