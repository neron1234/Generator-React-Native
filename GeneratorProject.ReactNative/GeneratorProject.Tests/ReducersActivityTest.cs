using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

using GeneratorProject.Platforms.Frontend.ReactNative;

namespace GeneratorProject.Tests
{
   public class ReducersActivityTest : BaseGeneratorTests, IDisposable
    {
        public ReducersActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            ReducersActivity activity = new ReducersActivity("ReducersActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
