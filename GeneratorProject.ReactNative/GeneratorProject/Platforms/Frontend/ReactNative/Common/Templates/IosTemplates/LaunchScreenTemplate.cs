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
    
    #line 1 "D:\Mobioos_Ver_2.0 --10.11.19\Generator-React-Native-master\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\IosTemplates\LaunchScreenTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LaunchScreenTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            #line 1 "D:\Mobioos_Ver_2.0 --10.11.19\Generator-React-Native-master\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\IosTemplates\LaunchScreenTemplate.tt"

    var model = (SmartAppInfo)Model;

            
            #line default
            #line hidden
            this.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n<document type=\"com.apple" +
                    ".InterfaceBuilder3.CocoaTouch.XIB\" version=\"3.0\" toolsVersion=\"7702\" systemVersi" +
                    "on=\"14D136\" targetRuntime=\"iOS.CocoaTouch\" propertyAccessControl=\"none\" useAutol" +
                    "ayout=\"YES\" launchScreen=\"YES\" useTraitCollections=\"YES\">\n    <dependencies>\n   " +
                    "     <deployment identifier=\"iOS\"/>\n        <plugIn identifier=\"com.apple.Interf" +
                    "aceBuilder.IBCocoaTouchPlugin\" version=\"7701\"/>\n        <capability name=\"Constr" +
                    "aints with non-1.0 multipliers\" minToolsVersion=\"5.1\"/>\n    </dependencies>\n    " +
                    "<objects>\n        <placeholder placeholderIdentifier=\"IBFilesOwner\" id=\"-1\" user" +
                    "Label=\"File\'s Owner\"/>\n        <placeholder placeholderIdentifier=\"IBFirstRespon" +
                    "der\" id=\"-2\" customClass=\"UIResponder\"/>\n        <view contentMode=\"scaleToFill\"" +
                    " id=\"iN0-l3-epB\">\n            <rect key=\"frame\" x=\"0.0\" y=\"0.0\" width=\"480\" heig" +
                    "ht=\"480\"/>\n            <autoresizingMask key=\"autoresizingMask\" widthSizable=\"YE" +
                    "S\" heightSizable=\"YES\"/>\n            <subviews>\n                <label opaque=\"N" +
                    "O\" clipsSubviews=\"YES\" userInteractionEnabled=\"NO\" contentMode=\"left\" horizontal" +
                    "HuggingPriority=\"251\" verticalHuggingPriority=\"251\" text=\"Powered by React Nativ" +
                    "e\" textAlignment=\"center\" lineBreakMode=\"tailTruncation\" baselineAdjustment=\"ali" +
                    "gnBaselines\" minimumFontSize=\"9\" translatesAutoresizingMaskIntoConstraints=\"NO\" " +
                    "id=\"8ie-xW-0ye\">\n                    <rect key=\"frame\" x=\"20\" y=\"439\" width=\"441" +
                    "\" height=\"21\"/>\n                    <fontDescription key=\"fontDescription\" type=" +
                    "\"system\" pointSize=\"17\"/>\n                    <color key=\"textColor\" cocoaTouchS" +
                    "ystemColor=\"darkTextColor\"/>\n                    <nil key=\"highlightedColor\"/>\n " +
                    "               </label>\n                <label opaque=\"NO\" clipsSubviews=\"YES\" u" +
                    "serInteractionEnabled=\"NO\" contentMode=\"left\" horizontalHuggingPriority=\"251\" ve" +
                    "rticalHuggingPriority=\"251\" text=\"");
            
            #line 1 "D:\Mobioos_Ver_2.0 --10.11.19\Generator-React-Native-master\GeneratorProject.ReactNative\GeneratorProject\Platforms\Frontend\ReactNative\Common\Templates\IosTemplates\LaunchScreenTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\" textAlignment=\"center\" lineBreakMode=\"middleTruncation\" baselineAdjustment=\"ali" +
                    "gnBaselines\" minimumFontSize=\"18\" translatesAutoresizingMaskIntoConstraints=\"NO\"" +
                    " id=\"kId-c2-rCX\">\n                    <rect key=\"frame\" x=\"20\" y=\"140\" width=\"44" +
                    "1\" height=\"43\"/>\n                    <fontDescription key=\"fontDescription\" type" +
                    "=\"boldSystem\" pointSize=\"36\"/>\n                    <color key=\"textColor\" cocoaT" +
                    "ouchSystemColor=\"darkTextColor\"/>\n                    <nil key=\"highlightedColor" +
                    "\"/>\n                </label>\n            </subviews>\n            <color key=\"bac" +
                    "kgroundColor\" white=\"1\" alpha=\"1\" colorSpace=\"custom\" customColorSpace=\"calibrat" +
                    "edWhite\"/>\n            <constraints>\n                <constraint firstItem=\"kId-" +
                    "c2-rCX\" firstAttribute=\"centerY\" secondItem=\"iN0-l3-epB\" secondAttribute=\"bottom" +
                    "\" multiplier=\"1/3\" constant=\"1\" id=\"5cJ-9S-tgC\"/>\n                <constraint fi" +
                    "rstAttribute=\"centerX\" secondItem=\"kId-c2-rCX\" secondAttribute=\"centerX\" id=\"Koa" +
                    "-jz-hwk\"/>\n                <constraint firstAttribute=\"bottom\" secondItem=\"8ie-x" +
                    "W-0ye\" secondAttribute=\"bottom\" constant=\"20\" id=\"Kzo-t9-V3l\"/>\n                " +
                    "<constraint firstItem=\"8ie-xW-0ye\" firstAttribute=\"leading\" secondItem=\"iN0-l3-e" +
                    "pB\" secondAttribute=\"leading\" constant=\"20\" symbolic=\"YES\" id=\"MfP-vx-nX0\"/>\n   " +
                    "             <constraint firstAttribute=\"centerX\" secondItem=\"8ie-xW-0ye\" second" +
                    "Attribute=\"centerX\" id=\"ZEH-qu-HZ9\"/>\n                <constraint firstItem=\"kId" +
                    "-c2-rCX\" firstAttribute=\"leading\" secondItem=\"iN0-l3-epB\" secondAttribute=\"leadi" +
                    "ng\" constant=\"20\" symbolic=\"YES\" id=\"fvb-Df-36g\"/>\n            </constraints>\n  " +
                    "          <nil key=\"simulatedStatusBarMetrics\"/>\n            <freeformSimulatedS" +
                    "izeMetrics key=\"simulatedDestinationMetrics\"/>\n            <point key=\"canvasLoc" +
                    "ation\" x=\"548\" y=\"455\"/>\n        </view>\n    </objects>\n</document>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
