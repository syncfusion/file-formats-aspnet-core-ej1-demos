#pragma checksum "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c840e0e736bcb411dec88ae09fb3ec0bd0f5563a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_BookmarkNavigation), @"mvc.1.0.view", @"/Views/DocIO/BookmarkNavigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/BookmarkNavigation.cshtml", typeof(AspNetCore.Views_DocIO_BookmarkNavigation))]
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
#line 1 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c840e0e736bcb411dec88ae09fb3ec0bd0f5563a", @"/Views/DocIO/BookmarkNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_BookmarkNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 59, true);
                WriteLiteral(" <span class=\"sampleName\">Editing/BookmarkNavigation</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Bookmark Navigation : Syncfusion";

#line default
#line hidden
                BeginContext(280, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml"
      Html.BeginForm("BookmarkNavigation", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(362, 3580, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to navigate between the bookmarks in a Word document and edit its content using Bookmark Navigation functionality of Essential DocIO. 
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""r");
                WriteLiteral(@"dButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </");
                WriteLiteral(@"div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO allows you to insert or delete bookmarks in the Word document and edit its content.
                        <ul>
                            <li>
                                You can easily identify a part of the document for future reference by adding bookmark.
                            </li>
                            <li>
                                Bookmark navigation lets you navigate to a specific bookmark and get its content as new document.
                            </li>
                            <li>
                                You can insert, replace or delete the contents of a specif");
                WriteLiteral(@"ic bookmark in the Word document.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the bookmarks can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-bookmarks"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 55 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\BookmarkNavigation.cshtml"

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
