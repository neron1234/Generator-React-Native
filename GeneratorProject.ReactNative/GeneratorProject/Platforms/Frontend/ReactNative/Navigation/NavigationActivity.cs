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
    [Activity(Order = 5)]
    public class NavigationActivity: GeneratorActivity
    {
        public NavigationActivity(string name, string basePath) : base(name, basePath)
        {
        }

        #region GeneratorActivity Methods

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            TransformNavigations(Context.DynamicContext.Manifest);
            TransformMainStackNavigator(Context.DynamicContext.Manifest);
            TransformAuthStackNavigator(Context.DynamicContext.Manifest);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformNavigations(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                if(smartApp.Concerns != null && smartApp.Concerns.Count > 0)
                {
                    foreach(ConcernInfo concern in smartApp.Concerns)
                    {
                        NavigationTemplate navigationTemplate = new NavigationTemplate(smartApp, concern);

                        string filename = TextConverter.PascalCase(concern.Id) + "StackNavigator.js";

                        WriteFile(Path.Combine(BasePath, navigationTemplate.OutputPath, filename), navigationTemplate.TransformText());
                    }
                }
            }
        }

        private void TransformMainStackNavigator(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                if (smartApp.Concerns != null && smartApp.Concerns.Count > 0)
                {
                    AppMainStackNavigator appMainStackNavigator = new AppMainStackNavigator(smartApp);
                    WriteFile(Path.Combine(BasePath, appMainStackNavigator.OutputPath), appMainStackNavigator.TransformText());
                }
            }
        }

        private void TransformAuthStackNavigator(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {

                AuthStackNavigator authStackNavigator = new AuthStackNavigator(smartApp);
                WriteFile(Path.Combine(BasePath, authStackNavigator.OutputPath), authStackNavigator.TransformText());

            }
        }

        #endregion
    }
}
