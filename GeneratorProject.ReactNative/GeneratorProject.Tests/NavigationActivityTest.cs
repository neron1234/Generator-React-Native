using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class NavigationActivityTest : BaseGeneratorTests, IDisposable
    {
        public NavigationActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            NavigationActivity activity = new NavigationActivity("NavigationActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }

    }
}


