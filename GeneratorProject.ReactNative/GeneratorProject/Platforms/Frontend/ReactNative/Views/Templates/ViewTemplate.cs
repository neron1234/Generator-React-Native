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
    
    #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("import React from \'react\';\r\nimport { \r\n  Image,\r\n  Text,\r\n  Button,\r\n  View,\r\n  S" +
                    "crollView\r\n} from \'react-native\';\r\n\r\n// Styles\r\n//import styles from \'./Styles/");
            
            #line 12 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("ScreenStyle\';\r\n\r\nexport default class ");
            
            #line 14 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Screen extends React.Component {\r\n    static navigationOptions = {\r\n        title" +
                    ":\'");
            
            #line 16 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Title)));
            
            #line default
            #line hidden
            this.Write(" Screen\'\r\n    };\r\n\r\n    constructor(props) {\r\n        super(props);\r\n    }\r\n");
            
            #line 22 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

  if(_layout.Actions.AsEnumerable() != null)
  {
    foreach(var action in _layout.Actions.AsEnumerable())
    {
         switch (action.Type.ToLower())
                {
                    case "navigation":
                        if(action.Target != null)
                        {
                            string[] actionTargetSplitted = action.Target.Split('.');
                            string targetedConcern = TextConverter.PascalCase(actionTargetSplitted[0]);
                            string targetedLayout = TextConverter.PascalCase(actionTargetSplitted[1]);

            
            #line default
            #line hidden
            this.Write("\r\n    ");
            
            #line 37 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(" = () => {\r\n        this.props.on");
            
            #line 38 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("();\r\n    }\r\n");
            
            #line 40 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                        }
                        break;
                    case "method":

            
            #line default
            #line hidden
            this.Write("\r\n    ");
            
            #line 46 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(" = () => {\r\n        //TODO\r\n    }\r\n");
            
            #line 49 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                        break;
                    case "dataget": case "datalist": case "datacreate": case "dataupdate": case "datadelete":
                        if (action.Api != null && _api != null)
                        {
                            string[] actionSplitted = action.Api.Split('.');
                            string apiService = actionSplitted[0];
                            string apiAction = actionSplitted[1];

                            foreach (ApiInfo api in _api.AsEnumerable())
                            {
                                if (api.Id.ToLower().Equals(apiService.ToLower()) && api.Actions.AsEnumerable() != null)
                                {
                                    foreach (ApiActionInfo apiA in api.Actions.AsEnumerable())
                                    {
                                        if (apiA.Id.ToLower().Equals(apiAction.ToLower()))
                                        {

            
            #line default
            #line hidden
            this.Write("\r\n    ");
            
            #line 68 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(" = (\r\n");
            
            #line 69 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                            if (apiA.Parameters.AsEnumerable() != null && apiA.Parameters.AsEnumerable().Count() > 0)
                                            {
                                                ApiParameterInfo last = apiA.Parameters.AsEnumerable().Last();
                                                foreach (ApiParameterInfo apiParameter in apiA.Parameters.AsEnumerable())
                                                {
                                                    if (apiParameter.Id != null)
                                                    {
                                                       // string type = apiParameter.TypeScriptType();
                                                       // type = IsModelBool(type) ? type  + _viewModelSuffix : type;
                                                        if (apiParameter.Equals(last))
                                                        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 82 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 83 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                                        }
                                                        else
                                                        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 88 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 89 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                                        }
                                                    }
                                                }
                                            }

            
            #line default
            #line hidden
            this.Write("    ) => {\r\n        return this._");
            
            #line 96 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(api.Id) + _apiSuffix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 96 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiA.Id)));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 97 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                            if (apiA.Parameters.AsEnumerable() != null && apiA.Parameters.AsEnumerable().Count() > 0)
                                            {
                                                ApiParameterInfo last = apiA.Parameters.AsEnumerable().Last();
                                                foreach (ApiParameterInfo apiParameter in apiA.Parameters.AsEnumerable())
                                                {
                                                    if (apiParameter.Id != null && apiParameter.Equals(last))
                                                    {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 106 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 107 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                                    }
                                                    else
                                                    {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 112 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 113 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                                    }
                                                }
                                            }

            
            #line default
            #line hidden
            this.Write("        );\r\n    }\r\n");
            
            #line 120 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
        }
  }

            
            #line default
            #line hidden
            this.Write("\r\n    render() {\r\n        return (\r\n          <View style={styles.container}>\r\n  " +
                    "         <ScrollView>\r\n                <View>\r\n");
            
            #line 137 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

    foreach(var action in _layout.Actions.AsEnumerable())
    {
        if(action.Type.ToLower().Equals("navigation"))
        {

            
            #line default
            #line hidden
            this.Write("                    <Button title=\"");
            
            #line 143 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(action.Id))));
            
            #line default
            #line hidden
            this.Write("\" onPress={this.");
            
            #line 143 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("}/>\r\n");
            
            #line 144 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("                </View>\r\n                <View>\r\n");
            
            #line 150 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

    foreach(var action in _layout.Actions.AsEnumerable())
    {
        if(action.Type.ToLower().Equals("method"))
        {

            
            #line default
            #line hidden
            this.Write("                    <Button title=\"");
            
            #line 156 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(action.Id))));
            
            #line default
            #line hidden
            this.Write("\" onPress={this.");
            
            #line 156 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("}/>\r\n");
            
            #line 157 "D:\01 Working\01 RedFabriq\01 working\generators\react-native\generator\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("                </View>\r\n             </ScrollView>\r\n          </View>\r\n         " +
                    " );\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
