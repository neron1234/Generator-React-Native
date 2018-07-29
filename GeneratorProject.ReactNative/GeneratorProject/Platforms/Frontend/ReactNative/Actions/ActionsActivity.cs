using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Activity(Order = 7)]
    public class ActionsActivity : GeneratorActivity
    {
        string _sessionId;

        public ActionsActivity(string name, string basePath) : base(name, basePath)
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

            //TransformActionTypes(smartApp);
            TransformActions(smartApp);

            await base.Writing();
        }

        #endregion

        #region Writing Methods

        private void TransformActionTypes(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                if (smartApp.Api != null && smartApp.Api.Count > 0)
                {
                    ActionTypesTemplate actionTypesTemplate = new ActionTypesTemplate(smartApp);
                    WriteFile(Path.Combine(BasePath, actionTypesTemplate.OutputPath), actionTypesTemplate.TransformText());
                }
            }
        }

        private void TransformActions(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Concerns != null && smartApp.Concerns.Count > 0)
            {
                foreach (var concern in smartApp.Concerns)
                {
                    foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                    {

                        ActionsTemplate actionsTemplate = new ActionsTemplate(concern, layout);

                        string path = Path.Combine(BasePath, actionsTemplate.OutputPath, TextConverter.PascalCase(concern.Id));

                        WriteFile(Path.Combine(path, TextConverter.PascalCase(layout.Id) + "Actions.js"), actionsTemplate.TransformText());
                    }
                }
            }
        }

        #endregion
        }
}
