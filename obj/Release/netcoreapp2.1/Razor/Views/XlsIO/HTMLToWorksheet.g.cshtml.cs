#pragma checksum "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\HTMLToWorksheet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c477774b7a29792d6bd1c4a91e2a46dd93a282"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_HTMLToWorksheet), @"mvc.1.0.view", @"/Views/XlsIO/HTMLToWorksheet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/HTMLToWorksheet.cshtml", typeof(AspNetCore.Views_XlsIO_HTMLToWorksheet))]
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
#line 5 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\HTMLToWorksheet.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c477774b7a29792d6bd1c4a91e2a46dd93a282", @"/Views/XlsIO/HTMLToWorksheet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_HTMLToWorksheet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 55, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / HTMLToWorksheet</span>");
                EndContext();
            }
            );
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(160, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\HTMLToWorksheet.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : HTML To Worksheet : Syncfusion";

#line default
#line hidden
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\HTMLToWorksheet.cshtml"
      Html.BeginForm("HTMLToWorksheet", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(331, 1540, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
				<p>
			Essential XlsIO supports importing HTML tables into Excel worksheets. The ImportHtmlTable method loads an HTML file and imports all the tables in the file to the worksheet.
			</p>
			 <br />
                <br />
                <b>Features:</b>
                <br />
                <ul>
                    <li>Imports HTML table</li>
                    <li>Imports with table formatting </li>
                </ul>
                <br />
                        <br />
                        <label>
                            Click the ""Input Template"" button to view the HTML input document and click the ""Import"" button to view the output Excel document. Please
                            note that Microsoft Excel Viewer or Microsoft Excel is required to view the Excel document.
                        </label>
                    </div>
                    <br /");
                WriteLiteral(@">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <input id=""viewtemplate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:125px;"" />
                            &nbsp;&nbsp;&nbsp;
                            <input class=""buttonStyle"" type=""submit"" name=""button"" value=""Import"" style=""width:125px;"" />
                        </div>
                    </div>
                </div>
            </div>
");
                EndContext();
#line 42 "D:\Samples_19.3.0.53\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\HTMLToWorksheet.cshtml"
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
