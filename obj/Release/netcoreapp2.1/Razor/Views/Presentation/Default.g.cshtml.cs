#pragma checksum "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9833c6c97d0c476073d561429faad34e2f3189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presentation_Default), @"mvc.1.0.view", @"/Views/Presentation/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Presentation/Default.cshtml", typeof(AspNetCore.Views_Presentation_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9833c6c97d0c476073d561429faad34e2f3189", @"/Views/Presentation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Presentation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 70, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">File Formats / Getting Started</span>\r\n");
                EndContext();
            }
            );
            BeginContext(96, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(125, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\Default.cshtml"
      Html.BeginForm("Default", "Presentation", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(205, 2819, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                This sample demonstrates how to create slides with simple text in a PowerPoint presentation.
                <br />
                &nbsp;
                <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                    Click the button to view a PowerPoint presentation generated by Essential Presentation.
                    Please note that Microsoft PowerPoint viewer or its equivalent is required to view the resultant document.
                    <br />
                    <div class=""rowdiv"" style=""margin-top: 10px"">
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input type=""submit"" class=""Button"" value=""Create Presentation"" style=""width: 150px; height: 27px"" />
                        </div>
                    </div>
                </div>
            </div>
 ");
                WriteLiteral(@"           <br />
            <div class=""rowdiv"">
                <b>Features:</b>
                <br />
                <ul>
                    <li>
                        Create a PowerPoint presentation from scratch with few lines of code.
                    </li>
                    <li>
                        Open the existing PowerPoint presentation from file system or stream, modify and save it back.
                    </li>
                    <li>
                        Save the PowerPoint presentation to a local file, stream, or stream it to the client browser.
                    </li>
                    <li>
                        Create and edit shapes.
                    </li>
                    <li>
                        Create and edit text.
                    </li>
                    <li>
                        Add and manipulate single-level and multilevel lists equivalent to Microsoft PowerPoint.
                    </li>
                    <li>
   ");
                WriteLiteral(@"                     Create, edit and convert charts.
                    </li>
                    <li>
                        Create and edit tables with different styles.
                    </li>
                    <li>
                        Copy and paste PowerPoint slides with source and destination paste options
                    </li>
                    <li>
                        Create, reply and edit comments.
                    </li>
                    <li>
                        Create and edit notes pages.
                    </li>
                    <li>
                        Apply and edit formatting of slide elements.
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
                EndContext();
#line 71 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\Default.cshtml"
            Html.EndForm();
        }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
