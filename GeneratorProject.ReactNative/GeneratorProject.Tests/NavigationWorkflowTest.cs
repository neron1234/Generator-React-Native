using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class NavigationWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public NavigationWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<NavigationWorkflow>();
            _container.RegisterType<NavigationWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("NavigationWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}


