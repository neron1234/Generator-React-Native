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
    
    #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class InitialStateTemplate_old : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
var model = (SmartAppInfo)Model;
            
            #line default
            #line hidden
            
            #line 2 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"

    if(model !=null && model.Concerns != null && model.Concerns.Count > 0)
    {

            
            #line default
            #line hidden
            this.Write("export default {\r\n");
            
            #line 7 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"

        List<string> addModels = new List<string>();
        foreach(ConcernInfo concern in model.Concerns)
        {
            foreach(LayoutInfo layout in concern.Layouts)
            {
                if(layout != null && layout.DataModel != null && !addModels.Contains(layout.DataModel.Id))
                {
                    addModels.Add(layout.DataModel.Id);

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 17 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(layout.DataModel.Id)));
            
            #line default
            #line hidden
            
            #line 17 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
if(layout.DataModel.References != null && layout.DataModel.References.Count > 0 && layout.DataModel.References[0].IsCollection){
            
            #line default
            #line hidden
            this.Write(": []");
            
            #line 17 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
} else {
            
            #line default
            #line hidden
            this.Write(": {}");
            
            #line 17 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"
}
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 18 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n    //If layout does not define any datamodel then return empty object as initi" +
                    "al state\r\n    emptyModel: {}\r\n}\r\n");
            
            #line 27 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Reducers\Templates\InitialStateTemplate_old.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
