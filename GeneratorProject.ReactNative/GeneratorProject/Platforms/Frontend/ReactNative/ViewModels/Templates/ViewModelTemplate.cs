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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewModelTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 2 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

    var model = (EntityInfo)Model;

            
            #line default
            #line hidden
            
            #line 5 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

    if(_dataModel != null && _dataModel.Id != null)
    {
        List<string> alreadyImported = new List<string>();
        if(_constructorParametersObj.AsEnumerable() != null)
        {
            foreach(var property in _constructorParametersObj.AsEnumerable())
            {
                if (property.Target != null && property.Type != null && !alreadyImported.AsEnumerable().Contains(property.Type))
                {
                     alreadyImported.Add(property.Type);

            
            #line default
            #line hidden
            this.Write("import ");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(property.Type)));
            
            #line default
            #line hidden
            
            #line 17 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write(" from \'../Models/");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Type)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix.ToLower()));
            
            #line default
            #line hidden
            this.Write("\';\r\n");
            
            #line 18 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                }
            }
        }
     if (_dataModel.References.AsEnumerable() != null)
        {
             foreach (ReferenceInfo reference in _dataModel.References.AsEnumerable())
            {
                if (reference.Target != null && reference.Type != null && !alreadyImported.AsEnumerable().Contains(reference.Type))
                {
                    alreadyImported.Add(reference.Type);

            
            #line default
            #line hidden
            this.Write("import ");
            
            #line 30 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(reference.Type)));
            
            #line default
            #line hidden
            
            #line 30 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write(" from \'../Models/");
            
            #line 30 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Type)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 30 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix.ToLower()));
            
            #line default
            #line hidden
            this.Write("\';\r\n");
            
            #line 31 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\nexport class  ");
            
            #line 37 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_dataModel.Id)));
            
            #line default
            #line hidden
            
            #line 37 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_viewModelSuffix));
            
            #line default
            #line hidden
            this.Write(" {\r\n\r\n    constructor(\r\n");
            
            #line 40 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

     if (_constructorParametersObj.AsEnumerable() != null && _constructorParametersObj.AsEnumerable().Count() > 0)
            {
                int count = _constructorParametersObj.AsEnumerable().Count() - 1;
                int counter = 0;
                Dictionary<string, int> countConstructor = new Dictionary<string, int>();
                foreach (PropertyInfo property in _constructorParametersObj.AsEnumerable())
                {
                    if (property.Id != null && property.TypeScriptType() != null)
                    {
                        string propertyIsModel = IsModel(property);
                        if (!countConstructor.ContainsKey(property.Id))
                            countConstructor.Add(property.Id, 1);
                        else
                            countConstructor[property.Id] = countConstructor[property.Id] + 1;
                        string type =  property.TypeScriptType();
                        if (!propertyIsModel.Equals(""))
                        {
                            type = TextConverter.PascalCase(type);
                        }
                        if (counter == count)
                        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 63 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 64 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                        }
                        else
                        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 69 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 70 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                        }
                    }
                    counter++;
                }
            }

            
            #line default
            #line hidden
            this.Write("    ) {\r\n\r\n    ");
            
            #line 79 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

            Dictionary<string, int> countObj = new Dictionary<string, int>();
            if (_dataModel.Properties.AsEnumerable() != null)
            {
                foreach (PropertyInfo property in _dataModel.Properties.AsEnumerable())
                {
                    if (property.Id != null)
                    {
                        if (!countObj.ContainsKey(property.Id))
                            countObj.Add(property.Id, 1);
                        else
                            countObj[property.Id] = countObj[property.Id] + 1;

            
            #line default
            #line hidden
            this.Write("    this.");
            
            #line 92 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 92 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countObj[property.Id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 93 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                    }
                }
            }

            if (_dataModel.References.AsEnumerable() != null)
            {
                foreach (ReferenceInfo reference in _dataModel.References.AsEnumerable())
                {
                    if (reference.Id != null)
                    {
                        if (!countObj.ContainsKey(reference.Id))
                            countObj.Add(reference.Id, 1);
                        else
                            countObj[reference.Id] = countObj[reference.Id] + 1;

            
            #line default
            #line hidden
            this.Write("    this.");
            
            #line 109 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 109 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id) + countObj[reference.Id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 110 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

                    }
                }
            }

            
            #line default
            #line hidden
            this.Write("  }\r\n}\r\n");
            
            #line 117 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\ViewModels\Templates\ViewModelTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
