﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Mobioos.Scaffold.BaseGenerators.Helpers;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Working\Mobioos\Generators new changes\28Nov2018\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\AndroidTemplates\MainActivityTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class MainActivityTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 2 "D:\Working\Mobioos\Generators new changes\28Nov2018\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\AndroidTemplates\MainActivityTemplate.tt"

    var model = (SmartAppInfo)Model;

            
            #line default
            #line hidden
            this.Write("package com.");
            
            #line 5 "D:\Working\Mobioos\Generators new changes\28Nov2018\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\AndroidTemplates\MainActivityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write(@";

import com.facebook.react.ReactActivity;

public class MainActivity extends ReactActivity {

    /**
     * Returns the name of the main component registered from JavaScript.
     * This is used to schedule rendering of the component.
     */
    @Override
    protected String getMainComponentName() {
        return """);
            
            #line 17 "D:\Working\Mobioos\Generators new changes\28Nov2018\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\AndroidTemplates\MainActivityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(model.Id)));
            
            #line default
            #line hidden
            this.Write("\";\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
