#pragma checksum "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea8d2aabb525945b92320e4bad7c112da44adb62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_FindandHighlight), @"mvc.1.0.view", @"/Views/DocIO/FindandHighlight.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/FindandHighlight.cshtml", typeof(AspNetCore.Views_DocIO_FindandHighlight))]
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
#line 1 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8d2aabb525945b92320e4bad7c112da44adb62", @"/Views/DocIO/FindandHighlight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_FindandHighlight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(104, 59, true);
                WriteLiteral(" <span class=\"sampleName\">Editing/Find and Highlight</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(191, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Find and Highlight : Syncfusion";

#line default
#line hidden
                BeginContext(281, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 7 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml"
      Html.BeginForm("FindandHighlight", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(361, 4214, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to find a specific text pattern using regular expression and highlight it in an existing Word document using Find functionality of Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <input type=""text"" id=""textBox"" name=""Group2"" value=""Adventure"" />
                            Regular expression to find the text
                        </div>
                        <div class=""rowdiv"" style=""margin-top");
                WriteLiteral(@": 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
   ");
                WriteLiteral(@"                             <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                            &nbsp;
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO allows you to find the text in the Word document and then to manipulate it.
                        <ul>
                            <li>
             ");
                WriteLiteral(@"                   You can find the first occurrence or all the occurrences of the text in the Word document.
                            </li>
                            <li>
                                You can find the static text or text pattern using regular expression.
                            </li>
                            <li>
                                You can find the text by matching case, whole word and all occurrence or first occurrence alone.
                            </li>
                            <li>
                                You can also find the content that spans across several paragraphs.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the Find functionality can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-find-and-replace"">documen");
                WriteLiteral("tation</a>\r\n                        section.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 65 "D:\Samples_19.2.0.44\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\FindandHighlight.cshtml"
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
