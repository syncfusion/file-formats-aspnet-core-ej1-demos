#pragma checksum "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c94510516987ab721280b1ff291a2ced1d1612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_Watermark), @"mvc.1.0.view", @"/Views/DocIO/Watermark.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/Watermark.cshtml", typeof(AspNetCore.Views_DocIO_Watermark))]
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
#line 1 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c94510516987ab721280b1ff291a2ced1d1612", @"/Views/DocIO/Watermark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_Watermark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 54, true);
                WriteLiteral(" <span class=\"sampleName\">Page Layout/Watermark</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(184, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Watermark : Syncfusion";

#line default
#line hidden
                BeginContext(265, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml"
      Html.BeginForm("Watermark", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(338, 3798, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to insert text and picture watermark into the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Watermark :
                                <input type=""radio"" id=""Radio1"" name=""Group2"" value=""Picture"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""Radio1"" style=""font-size:13px;font-wei");
                WriteLiteral(@"ght:normal;text-align:match-parent"" data-toggle=""tooltip"">Picture</label>
                                &nbsp;
                                <input type=""radio"" id=""Radio2"" name=""Group2"" value=""text"" style=""margin-left: 7px"" />
                                <label for=""Radio2"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Text</label>
                            </div>
                            <div class=""celldiv"" style=""margin-top: 10px"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDoc");
                WriteLiteral(@"x"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
            ");
                WriteLiteral(@"        <br />
                    <div class=""rowdiv"">
                        Watermark will be displayed behind the document content and usually it shows the trademark, copyright or ownership details of the document. With the help of DocIO, you can add and modify the text and image watermarks in the Word document.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the watermarks can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/applying-watermark"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 52 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\Watermark.cshtml"

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
