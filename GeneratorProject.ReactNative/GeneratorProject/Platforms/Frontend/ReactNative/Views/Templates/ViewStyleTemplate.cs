﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
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
    using Mobioos.Foundation.Jade.Models;
    using Common.Generator.Framework.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Mobioos_Ver_2.0 --10.11.19\Generator-React-Native-master\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Views\Templates\ViewStyleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ViewStyleTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"import {StyleSheet} from 'react-native';
import {ApplicationStyles, Colors} from '../../Themes';

export default StyleSheet.create({
    ...ApplicationStyles.screen,
    container: {
        flex: 1,
        justifyContent: 'center',
        backgroundColor: Colors.background
    }
});");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
