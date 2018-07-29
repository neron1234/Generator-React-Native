using Mobioos.Scaffold.Core.Runtime.Activities;
using System.IO;
using System.Threading.Tasks;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Generators.Helpers;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 2)]
    public class DataModelActivity : GeneratorActivity
    {
        string _sessionId;

        public DataModelActivity(string name, string basePath) : base(name, basePath)
        {
        }

        #region GeneratorActivity Methods

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            _sessionId = "session 00002";

            await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            SmartAppInfo smartApp = Context.DynamicContext.Manifest;


            TransformDataModel(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods



        private void TransformDataModel(SmartAppInfo manifest)
        {
            bool result = true;
            string modelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ModelSuffix) ? "Model" : TextConverter.PascalCase(Context.DynamicContext.ModelSuffix);

            var entities = manifest.DataModel.Entities;

            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    if (!result) break;

                    if (entity != null)
                    {
                        DataModelTemplate template = new DataModelTemplate(entity, manifest.Id, modelSuffix);
                        try
                        {
                            result = WriteFile(Path.Combine(BasePath, template.OutputPath, TextConverter.PascalCase(entity.Id) + "." + modelSuffix + ".js"), template.TransformText());
                        }
                        catch (Exception ex)
                        {
                            result = false;
                            Context.RuntimeContext.Runtime.Logger.Error($"error on generating controllers api for session: {_sessionId} with exception message: {ex.Message}");
                        }
                    }
                }
            }
        }

        #endregion
    }
}
