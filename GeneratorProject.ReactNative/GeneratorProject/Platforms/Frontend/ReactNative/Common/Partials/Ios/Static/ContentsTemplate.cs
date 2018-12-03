﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public partial class ContentsTemplate : TemplateBase
    {
        private SmartAppInfo _smartAppInfo { get; set; }

        public ContentsTemplate(SmartAppInfo smartApp) : base(smartApp)
        {
            _smartAppInfo = smartApp;
        }

        public override string OutputPath => string.Format(@"ios\{0}\Images.xcassets\Contents.json", TextConverter.PascalCase(_smartAppInfo.Id));
    }
}