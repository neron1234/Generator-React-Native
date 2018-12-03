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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ContainerTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nimport React, { Component } from \'react\';\r\nimport { connect } from \'react-redux" +
                    "\';\r\nimport { bindActionCreators } from \'redux\';\r\n\r\nimport * as ");
            
            #line 6 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Actions from \'../../Actions/");
            
            #line 6 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_concern.Id)));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 6 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Actions\'; \r\n/*import {\r\n");
            
            #line 8 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    foreach(var action in _layout.Actions.AsEnumerable())
    {
        if(!action.Type.ToLower().Equals("navigation"))
        {
            if(action.Id.ToLower().Equals("delete"))
            {
                action.Id = TextConverter.CamelCase(action.Id)+TextConverter.PascalCase(_concern.Id);
            }

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 18 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 19 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("    } from \'../../Actions/");
            
            #line 23 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_concern.Id)));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 23 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Actions\';*/\r\n\r\n");
            
            #line 25 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    if(_layout != null)
    {

            
            #line default
            #line hidden
            this.Write("class ");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Container extends Component {\r\n    componentDidMount() {\r\n");
            
            #line 31 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    foreach(var action in _layout.Actions.AsEnumerable())
    {
        if(action.Type.ToLower().Equals("datalist"))
        {

            
            #line default
            #line hidden
            this.Write("        this.props.");
            
            #line 37 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 38 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n");
            
            #line 44 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    if(_navigationActions != null && _navigationActions.Count > 0)
    {
        foreach(var action in _layout.Actions.AsEnumerable())
        {
            if(action.Type.ToLower().Equals("navigation"))
            {

            
            #line default
            #line hidden
            this.Write("    on");
            
            #line 52 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(" = () => {\r\n        this.props.navigation.navigate(\'");
            
            #line 53 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.Target));
            
            #line default
            #line hidden
            this.Write("\');\r\n    }\r\n");
            
            #line 55 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write(@"
    render() {
        if (this.props.hasErrored) {
            return <p>Sorry! There was an error loading the items</p>;
        }

        if (this.props.isLoading) {
            return <p>Loading…</p>;
        }

        return (
            <");
            
            #line 71 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Screen items={this.props.data} \r\n");
            
            #line 72 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    if(_navigationActions != null && _navigationActions.Count > 0)
    {
        foreach(var action in _layout.Actions.AsEnumerable())
        {
            if(action.Type.ToLower().Equals("navigation"))
            {

            
            #line default
            #line hidden
            this.Write("                on");
            
            #line 80 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("={ this.on");
            
            #line 80 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(" }\r\n");
            
            #line 81 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write(@"            />
        );
  }
}

const mapStateToProps = (state) => {
    return {
        navigation: state.navigation,
        data: state.data,
        hasErrored: state.itemsHasErrored,
        isLoading: state.itemsIsLoading
    };
};

const mapDispatchToProps = (dispatch) => {
    return {
");
            
            #line 102 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    foreach(var action in _layout.Actions.AsEnumerable())
    {
        if(!action.Type.ToLower().Equals("navigation"))
        {

            
            #line default
            #line hidden
            this.Write("        //");
            
            #line 108 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write(": () => dispatch(");
            
            #line 108 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("()),\r\n");
            
            #line 109 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("        actions:bindActionCreators(");
            
            #line 113 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Actions, dispatch)\r\n    };\r\n};\r\n\r\nexport default connect(mapStateToProps, mapDisp" +
                    "atchToProps)(");
            
            #line 117 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_layout.Id)));
            
            #line default
            #line hidden
            this.Write("Container);\r\n");
            
            #line 118 "D:\Working\Mobioos\Generators new changes\React-Native\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Containers\Templates\ContainerTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
