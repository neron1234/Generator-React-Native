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
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Scaffold.Generators.Helpers;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class PackageJsonTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"
 var model = (SmartAppInfo)Model;
            
            #line default
            #line hidden
            this.Write("\n{\n  \"name\": \"");
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\",\n");
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"

    if(model.Description != null)
    {

            
            #line default
            #line hidden
            this.Write("\n  \"description\": \"");
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Description));
            
            #line default
            #line hidden
            this.Write("\",\n");
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\PackageJsonTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"
  ""version"": ""0.0.1"",
  ""private"": true,
  ""scripts"": {
    ""start"": ""node node_modules/react-native/local-cli/cli.js start"",
    ""test"": ""jest""
  },
  ""dependencies"": {
    ""apisauce"": ""^0.15.2"",
    ""prop-types"": ""^15.6.2"",
    ""react"": ""16.3.1"",
    ""react-native"": ""0.55.4"",
    ""react-native-i18n"": ""^2.0.12"",
    ""react-navigation"": ""^2.5.5"",
    ""react-redux"": ""^5.0.7"",
    ""redux"": ""^4.0.0"",
    ""redux-thunk"": ""^2.3.0""
  },
  ""devDependencies"": {
    ""babel-jest"": ""23.2.0"",
    ""babel-preset-react-native"": ""4.0.0"",
    ""jest"": ""23.2.0"",
    ""react-test-renderer"": ""16.3.1"",
    ""react-devtools"": ""^3.2.3""
  },
  ""jest"": {
    ""preset"": ""react-native""
  }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
