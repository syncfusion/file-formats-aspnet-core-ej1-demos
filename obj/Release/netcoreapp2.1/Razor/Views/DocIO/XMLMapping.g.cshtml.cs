#pragma checksum "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104066d52d67ef6f5946052b0becefd7346f782e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_XMLMapping), @"mvc.1.0.view", @"/Views/DocIO/XMLMapping.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/XMLMapping.cshtml", typeof(AspNetCore.Views_DocIO_XMLMapping))]
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
#line 1 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104066d52d67ef6f5946052b0becefd7346f782e", @"/Views/DocIO/XMLMapping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_XMLMapping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 51, true);
                WriteLiteral(" <span class=\"sampleName\">>DocIO/XML Mapping</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(181, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : XML Mapping : Syncfusion";

#line default
#line hidden
                BeginContext(264, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml"
      Html.BeginForm("XMLMapping", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(338, 1684, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to map custom XML parts to content controls in the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Group"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        Doc");
                WriteLiteral(@"IO allows you to bind content controls to XML elements that are embedded in the document. When you bind a content control to a custom XML part, two-way data binding is automatically enabled.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the content controls can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-content-controls#data-binding-with-content-controls-xml-mapping"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 31 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\XMLMapping.cshtml"

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
