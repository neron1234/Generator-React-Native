using Mobioos.Scaffold.Infrastructure.Runtime;
using Mobioos.Scaffold.Core.Runtime;
using Mobioos.Foundation.Jade;
using System.Dynamic;
using System.IO;

namespace GeneratorProject.Tests
{
    public class BaseGeneratorTests
    {
        protected string _smartAppPath { get; set; }
        protected IActivityContext _context { get; set; }

        public BaseGeneratorTests()
        {
            _smartAppPath = Path.Combine(Directory.GetCurrentDirectory(), "Manifest");
            _context = new ActivityContext(new ExpandoObject(), null, null);
            _context.DynamicContext.Manifest = JadeEngine.Parse(_smartAppPath);
            _context.DynamicContext.GeneratorPath = Directory.GetCurrentDirectory();
            _context.DynamicContext.Theme = "light";
            _context.DynamicContext.ViewModelSuffix = "ViewModel";
            _context.DynamicContext.ApiSuffix = "Service";
            _context.DynamicContext.ModelSuffix = "Model";
        }

        protected void Clear()
        {
            //var directoryPath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            //if (Directory.Exists(directoryPath))
            //    Directory.Delete(directoryPath, true);
        }
    }
}
