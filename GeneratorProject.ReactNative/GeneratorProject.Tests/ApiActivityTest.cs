using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
    public class ApiActivityTest : BaseGeneratorTests, IDisposable
    {
        public ApiActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            ApiActivity activity = new ApiActivity("ApiActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
