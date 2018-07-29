using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Infrastructure.Runtime;


namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 6)]
    public class ApiActivity : GeneratorActivity
    {
        string _sessionId;

        public ApiActivity(string name, string basePath) : base(name, basePath)
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

            TransformServiceBase(smartApp);
            TransformApis(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformServiceBase(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                RestApiTemplate serviceBaseTemplate = new RestApiTemplate(smartApp);
                WriteFile(Path.Combine(BasePath, serviceBaseTemplate.OutputPath), serviceBaseTemplate.TransformText());
            }
        }

        private void TransformApis(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                if (smartApp.Api != null && smartApp.Api.Count > 0)
                {
                    foreach (ApiInfo api in smartApp.Api)
                    {
                        if (api != null)
                        {
                            ApiTemplate serviceTemplate = new ApiTemplate(smartApp, api);
                            WriteFile(Path.Combine(BasePath, serviceTemplate.OutputPath,api.Id+"Api.js"), serviceTemplate.TransformText());
                        }
                    }
                }
            }
        }

        #endregion
    }
}
