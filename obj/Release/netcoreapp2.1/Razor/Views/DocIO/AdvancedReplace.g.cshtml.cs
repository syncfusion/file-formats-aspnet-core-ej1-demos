#pragma checksum "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e071d1471814445fc31657be317fc91508563ac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_AdvancedReplace), @"mvc.1.0.view", @"/Views/DocIO/AdvancedReplace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/AdvancedReplace.cshtml", typeof(AspNetCore.Views_DocIO_AdvancedReplace))]
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
#line 1 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e071d1471814445fc31657be317fc91508563ac7", @"/Views/DocIO/AdvancedReplace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_AdvancedReplace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 79, true);
                WriteLiteral(" <span class=\"sampleName\">AdvancedReplace/Find, Replace with Formatting </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(209, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Find, Replace with Formatting : Syncfusion";

#line default
#line hidden
                BeginContext(310, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml"
      Html.BeginForm("AdvancedReplace", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(389, 3707, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to replace a specific content in the Word document with another document using the Find and Replace functionality of Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""celldiv"" style=""margin-top: 10px"">
                            Save As :
                            <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                            <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align");
                WriteLiteral(@":match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                            &nbsp;
                            <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                            <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                            &nbsp;
                            <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                            <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>                           
                        </div>
                        <div class=""celldiv"" style=""margin-top: 8px"">
                   ");
                WriteLiteral(@"         <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                            &nbsp;
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO allows you to find and replace a specific content in the Word document with another document.
                        <ul>
                            <li>
                                You can replace a specific content with another part of the document or another Word document.
                            </li>
                            <li>
                                You can replace the content by retaining the same formatting for the new content.
                            </li>
                    ");
                WriteLiteral(@"        <li>
                                You can also replace it with any document elements like image, paragraph, table, etc.,
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the Find and Replace functionality can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-find-and-replace"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 55 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\AdvancedReplace.cshtml"
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
