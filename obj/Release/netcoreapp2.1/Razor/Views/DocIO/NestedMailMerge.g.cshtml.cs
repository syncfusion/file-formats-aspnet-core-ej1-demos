#pragma checksum "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc647735112ae71f6a9b332fb00f513396676c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_NestedMailMerge), @"mvc.1.0.view", @"/Views/DocIO/NestedMailMerge.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/NestedMailMerge.cshtml", typeof(AspNetCore.Views_DocIO_NestedMailMerge))]
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
#line 1 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc647735112ae71f6a9b332fb00f513396676c01", @"/Views/DocIO/NestedMailMerge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_NestedMailMerge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 56, true);
                WriteLiteral(" <span class=\"sampleName\">DocIO/Nested Mail merge</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml"
      ViewBag.Title = "Essential DocIO (Word) : Nested Mail merge : Syncfusion";

#line default
#line hidden
                BeginContext(271, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml"
      Html.BeginForm("NestedMailMerge", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(350, 5457, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to perform Mail merge for nested groups in Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Nested Mail merge Template :
                                <br/>
                                <input type=""radio"" id=""rdButtonReport"" name=""Group2"" value=""Report"" style=""margin-left:20px"" />
                                <label f");
                WriteLiteral(@"or=""rdButtonReport"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Report</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonLetter"" name=""Group2"" value=""Letter"" checked=""checked"" style=""margin-left:20px"" />
                                <label for=""rdButtonLetter"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Letter</label>
                            </div>
                            <div class=""celldiv"" style=""margin-top: 10px"">
                                Mail merge Data :
                                <br />
                                <input type=""radio"" id=""rdImplicit"" name=""Group3"" value=""Implicit"" checked=""checked"" style=""margin-left:20px"" />
                                <label for=""rdImplicit"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Implicit Relation</label>
                            ");
                WriteLiteral(@"    &nbsp;
                                <input type=""radio"" id=""rdExplict"" name=""Group3"" value=""Explicit"" style=""margin-left:20px"" />
                                <label for=""rdExplict"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Explicit Relation</label>
                            </div>
                            <div class=""celldiv"" style=""margin-top: 10px"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                              ");
                WriteLiteral(@"  <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                            &nbsp;
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate ");
                WriteLiteral(@"Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO supports to perform mail merge between the nested groups in the Word document, to generate report with hierarchical data.                        
                        <ul>
                            <li>
                                You can create advanced reports by dynamically repeating a region of the document and by nesting mail merge region inside each other to populate hierarchical data.
                            </li>
                            <li>
                                You can define relation between the data tables explicitly or directly use relational data for performing nested mail merge.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                      ");
                WriteLiteral(@"  More information about the nested Mail merge can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge#performing-nested-mail-merge-for-group"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 72 "D:\Samples_18.1.0.52\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\NestedMailMerge.cshtml"

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
