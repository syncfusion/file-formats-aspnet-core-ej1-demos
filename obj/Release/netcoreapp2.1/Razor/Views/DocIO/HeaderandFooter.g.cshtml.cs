#pragma checksum "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611526d2bfccf9c866ae6493bfb6203dddf4a9e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_HeaderandFooter), @"mvc.1.0.view", @"/Views/DocIO/HeaderandFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/HeaderandFooter.cshtml", typeof(AspNetCore.Views_DocIO_HeaderandFooter))]
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
#line 1 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611526d2bfccf9c866ae6493bfb6203dddf4a9e5", @"/Views/DocIO/HeaderandFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_HeaderandFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 63, true);
                WriteLiteral(" <span class=\"sampleName\">Insert Content/HeaderandFooter</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml"
      ViewBag.Title = "   Essential DocIO (Word) : Header, Footer : Syncfusion";

#line default
#line hidden
                BeginContext(278, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml"
      Html.BeginForm("HeaderandFooter", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(357, 3627, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to insert headers and footers to the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-ali");
                WriteLiteral(@"gn:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""marg");
                WriteLiteral(@"in-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        With DocIO, you can insert all possible types of header and footer in the Word document like first page, odd page and even page header and footer.
                        <ul>
                            <li>
                                You can add text, tables, pictures, page numbers, fields etc., to the header and footer.
                            </li>
                            <li>
                                Previous section header and footer contents can be linked and repeated for the next section.
                            </li>
                            <li>
                                You can define different header and footer for the first page, odd");
                WriteLiteral(@" pages and even pages in the document.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the headers and footers can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-sections#working-with-headers-and-footers"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 55 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\HeaderandFooter.cshtml"

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
