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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ApiTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 2 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

    var model = (SmartAppInfo)Model;

            
            #line default
            #line hidden
            this.Write("import RestApi from \'./RestApi\';\r\n\r\nexport default class ");
            
            #line 7 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_api.Id));
            
            #line default
            #line hidden
            this.Write("Api{\r\n\r\n");
            
            #line 9 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
 if(_api.Actions != null && _api.Actions.Count > 0)
   {
       foreach(ApiActionInfo action in _api.Actions)
       {
           if (action.Id != null && action.Url != null && action.Type != null)
            {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 16 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

            if (action.Parameters.AsEnumerable() != null && action.Parameters.AsEnumerable().Count() > 0)
                    {
                        ApiParameterInfo last = action.Parameters.AsEnumerable().Last();
                        foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                        {
                            if (apiParameter.Id != null)
                            {
                                if (apiParameter.Equals(last))
                                {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 34 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 35 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                }
                            }
                        }
                    }
                   

            
            #line default
            #line hidden
            this.Write("    ) {\r\n");
            
            #line 43 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                    switch (action.Type)
                    {
                        case "dataget": case "datalist":
    
                            if (action.Parameters.AsEnumerable() != null && action.Parameters.AsEnumerable().Count() > 0)
                            {

            
            #line default
            #line hidden
            this.Write("        let urlSearchParams = {};\r\n");
            
            #line 52 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                             foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                                {
                                    if (apiParameter.Id != null)
                                    {

            
            #line default
            #line hidden
            this.Write("        urlSearchParams[\'");
            
            #line 58 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\'] = JSON.stringify(");
            
            #line 58 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 59 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                    }
                                }

            
            #line default
            #line hidden
            this.Write("        return RestApi.get(\'");
            
            #line 63 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Url));
            
            #line default
            #line hidden
            this.Write("\', urlSearchParams) ;\r\n");
            
            #line 64 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                            }
                            else
                            {

            
            #line default
            #line hidden
            this.Write("        return RestApi.get(\'");
            
            #line 69 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Url));
            
            #line default
            #line hidden
            this.Write("\');\r\n");
            
            #line 70 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                            }
                        break;
                        case "datacreate":

            
            #line default
            #line hidden
            this.Write("        let postData = {};\r\n");
            
            #line 76 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                            if (action.Parameters.AsEnumerable() != null && action.Parameters.AsEnumerable().Count() > 0)
                            {
                                foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                                {
                                    if (apiParameter.Id != null)
                                    {

            
            #line default
            #line hidden
            this.Write("        postData[\'");
            
            #line 84 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\'] = ");
            
            #line 84 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 85 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                    }
                                }
                            }

            
            #line default
            #line hidden
            this.Write("        return RestApi.post(\'");
            
            #line 90 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Url));
            
            #line default
            #line hidden
            this.Write("\', postData);\r\n");
            
            #line 91 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                        break;
                        case "dataupdate":

            
            #line default
            #line hidden
            this.Write("         let putData = {};\r\n");
            
            #line 96 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                            if (action.Parameters.AsEnumerable() != null && action.Parameters.AsEnumerable().Count() > 0)
                            {
                                foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                                {
                                    if (apiParameter.Id != null)
                                    {

            
            #line default
            #line hidden
            this.Write("        putData[\'");
            
            #line 104 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\'] = ");
            
            #line 104 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 105 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                    }
                                }
                            }

            
            #line default
            #line hidden
            this.Write("        return RestApi.put(\'");
            
            #line 110 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Url));
            
            #line default
            #line hidden
            this.Write("\', putData);\r\n");
            
            #line 111 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                        break;
                        case "datadelete":

            
            #line default
            #line hidden
            this.Write("        let urlSearchParams = {};\r\n");
            
            #line 116 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                            if (action.Parameters.AsEnumerable() != null && action.Parameters.AsEnumerable().Count() > 0)
                            {
                                foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                                {
                                    if (apiParameter.Id != null)
                                    {

            
            #line default
            #line hidden
            this.Write("        urlSearchParams[\'");
            
            #line 124 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\'] = JSON.stringify(");
            
            #line 124 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 125 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                                    }
                                }
                            }

            
            #line default
            #line hidden
            this.Write("         return RestApi.delete(\'");
            
            #line 130 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Url));
            
            #line default
            #line hidden
            this.Write("\', urlSearchParams);\r\n");
            
            #line 131 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

                        break;
                        default: break;
                    }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n");
            
            #line 138 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Apis\Templates\ApiTemplate.tt"

            }
       }
   }

            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}