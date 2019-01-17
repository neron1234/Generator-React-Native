﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class AppDelegateHTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public AppDelegateHTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}\AppDelegate.h", TextConverter.PascalCase(_smartAppInfo.Id));
    }
}
