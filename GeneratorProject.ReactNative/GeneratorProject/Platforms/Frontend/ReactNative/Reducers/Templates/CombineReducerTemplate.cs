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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CombineReducerTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 2 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"

    var model = (SmartAppInfo)Model;

            
            #line default
            #line hidden
            this.Write("import { combineReducers } from \'redux\';\r\n\r\n");
            
            #line 7 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
 
    if(model !=null && model.Concerns != null && model.Concerns.Count > 0)
    {
        foreach(ConcernInfo concern in model.Concerns)
        {
            foreach(LayoutInfo layout in concern.Layouts)
            {

            
            #line default
            #line hidden
            this.Write("import ");
            
            #line 15 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(concern.Id)));
            
            #line default
            #line hidden
            
            #line 15 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write(" from \'./");
            
            #line 15 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(concern.Id)));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 15 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write("Reducer\';\r\n");
            
            #line 16 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"

             }
        }

            
            #line default
            #line hidden
            this.Write("\r\nconst RootReducer = combineReducers({\r\n");
            
            #line 22 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"

       foreach(ConcernInfo concern in model.Concerns)
        {
            foreach(LayoutInfo layout in concern.Layouts)
            {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(concern.Id)));
            
            #line default
            #line hidden
            
            #line 28 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("});\r\n\r\nexport default RootReducer;\r\n");
            
            #line 36 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\CombineReducerTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
