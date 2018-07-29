using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompts.Interfaces;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 1)]
    public class CommonActivity : GeneratorActivity
    {
        private string _templatesDirectoryPath { get; set; }

        public CommonActivity(string name, string basePath)
           : base(name, basePath)
        {
        }

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            _templatesDirectoryPath = Path.Combine(
                activityContext.DynamicContext.GeneratorPath,
                "Platforms\\Frontend\\ReactNative\\Common\\Templates"
            );
            await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public override Task Prompting()
        {
            return base.Prompting();
        }

        protected override void ActivityPrompt_Completed(IEnumerable<IQuestion> questions)
        {
            base.ActivityPrompt_Completed(questions);
        }

        [Task(Order = 3)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            SmartAppInfo smartApp = Context.DynamicContext.Manifest;
          
            TransformStaticFile(_templatesDirectoryPath);
            TransferRootFiles(smartApp);


            await base.Writing();
        }

        private void TransformStaticFile(string templatesDirectoryPath)
        {
            string outputPath = Path.Combine(Context.DynamicContext.GeneratorPath, templatesDirectoryPath);
            CopyDirectory(outputPath, BasePath);
        }

        private void TransferRootFiles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                IndexTemplate indexTemplate = new IndexTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, indexTemplate.OutputPath), indexTemplate.TransformText());

                AppJsonTemplate appJsonTemplate = new AppJsonTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, appJsonTemplate.OutputPath), appJsonTemplate.TransformText());

                PackageJsonTemplate packageJsonTemplate = new PackageJsonTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, packageJsonTemplate.OutputPath), packageJsonTemplate.TransformText());
            }
        }
    }
}
