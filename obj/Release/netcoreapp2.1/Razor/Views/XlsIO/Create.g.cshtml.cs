#pragma checksum "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc9aa326bd33b348ad61dc363c0444fab36933f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_Create), @"mvc.1.0.view", @"/Views/XlsIO/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/Create.cshtml", typeof(AspNetCore.Views_XlsIO_Create))]
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
#line 1 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Create.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc9aa326bd33b348ad61dc363c0444fab36933f3", @"/Views/XlsIO/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 71, true);
                WriteLiteral(" <span class=\"sampleName\">XlsIO/GettingStarted/CreateSpreadsheet</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(172, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Create.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : CreateSpreadsheet : Syncfusion";

#line default
#line hidden
                BeginContext(262, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Create.cshtml"
      Html.BeginForm("Create", "XlsIO", FormMethod.Post);
    {

#line default
#line hidden
                BeginContext(328, 1448, true);
                WriteLiteral(@"        <div class=""Common"">
            <div class=""tablediv"">
                <div class=""rowdiv"">
                    <label>
                        Click the button to view the Excel spreadsheet generated by Essential XlsIO. Please
                        note that Microsoft Excel Viewer or Excel is required to view the resultant document.
                    </label>
                </div>
                <br />
                <div class=""rowdiv"">
                    <div class=""celldiv"">
                        <label>
                            <strong>  Save As :</strong>
                        </label>
                        <input id=""rbtn2003"" type=""radio"" name=""SaveOption"" value=""ExcelXls"" />
                        <label for=""rbtn2003"">
                            XLS
                        </label>
						&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <input id=""rbtn2007"" type=""radio"" name=""SaveOption"" value=""ExcelXlsx"" checked=""checked""/>
                  ");
                WriteLiteral(@"      <label for=""rbtn2007"">
                            XLSX
                        </label>
                    </div>
                    <br />
                    <div class=""celldiv"">
                        <input class=""buttonStyle"" type=""submit"" value=""Create Document"" style="" width:200px;"" />
                    </div>
                </div>
                <br />
            </div>
        </div>
");
                EndContext();
#line 40 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Create.cshtml"
        Html.EndForm();
    }

#line default
#line hidden
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1836, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
