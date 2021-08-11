#pragma checksum "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "464155912b37d122df9a525380503502947b3cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_WordtoWordML), @"mvc.1.0.view", @"/Views/DocIO/WordtoWordML.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/WordtoWordML.cshtml", typeof(AspNetCore.Views_DocIO_WordtoWordML))]
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
#line 1 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"464155912b37d122df9a525380503502947b3cae", @"/Views/DocIO/WordtoWordML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_WordtoWordML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 63, true);
                WriteLiteral(" <span class=\"sampleName\">Import and Export/WordToWordML</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Export, Word to Word XML, Conversion : Syncfusion";

#line default
#line hidden
                BeginContext(301, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
      Html.BeginForm("WordToWordML", "DocIO", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(418, 756, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to convert the Word document to Word processing XML using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the resultant WordML document generated by Essential DocIO.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Select Document :
                                ");
                EndContext();
                BeginContext(1175, 102, false);
#line 19 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
                           Write(Html.TextBox("file", "", new { type = "file", accept = ".doc,.docx,.rtf,.dot,.dotm,.dotx,docm,.xml" }));

#line default
#line hidden
                EndContext();
                BeginContext(1277, 422, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Convert to WordML"" style=""width:150px;height:27px"" />
                            <br />
                            <div class=""text-danger"">
                                ");
                EndContext();
                BeginContext(1700, 15, false);
#line 26 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1715, 692, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO provides support to convert the Word document to Word processing XML document and vice versa.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about WordML conversion can be found on this
                        <a href=""https://help.syncfusion.com/file-formats/docio/conversion"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 41 "D:\Samples_19.2.0.55\FileFormats\ASPNETCORE\IOsamplebrowser\Views\DocIO\WordtoWordML.cshtml"

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
