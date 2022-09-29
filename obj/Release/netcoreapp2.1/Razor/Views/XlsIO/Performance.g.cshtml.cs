#pragma checksum "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Performance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650d2bed0fcd3f0158d771da3242eb0d86065e5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_Performance), @"mvc.1.0.view", @"/Views/XlsIO/Performance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/Performance.cshtml", typeof(AspNetCore.Views_XlsIO_Performance))]
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
#line 1 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Performance.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"650d2bed0fcd3f0158d771da3242eb0d86065e5f", @"/Views/XlsIO/Performance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_Performance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 65, true);
                WriteLiteral(" <span class=\"sampleName\">XlsIO/GettingStarted/Performance</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(166, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Performance.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : CreateSpreadsheet : Syncfusion";

#line default
#line hidden
                BeginContext(256, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Performance.cshtml"
      Html.BeginForm("Performance", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(331, 3936, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <p>Essential XlsIO is known for its high performance and simple APIs that have most of the functionalities of Excel.</p>
						<br />
						<br />
						<b>Features:</b>
						<br />
						<br />
						<ul>
							<li>Creating rich, large reports with styles.</li>
							<li>Performance optimization methods.</li>
							<li>Import on Save option to serialize data while saving the workbook, which is recommended for imprting large data without formatting.</li>
						</ul>
						<b>Notes:</b>
						<br />
						<br />
						<ul>
							<li>When more styles are added, it is recommended that you use global styles within BeginUpdate and EndUpdate calls.</li>
							<li>The use of IMigrant Range will reduce the amount of memory used when large amounts of strings are involved.</li>
						</ul>
                        <p>This sample demonstrates how to increase t");
                WriteLiteral(@"he performance of XlsIO. </p>
                        <p>
                            Click the button to view the Excel document generated by Essential XlsIO.
                            Please note that Microsoft Excel is required to view the resultant document.
                        </p>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <label>Enter the number of rows</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id=""row"" name=""rowCount"" type=""text"" value=""50000"" size=""7"" />
                        <br />
                        <br />
                        <label>Enter the number of columns</label>
                        <input id=""column"" name=""colCount"" type=""text"" value=""50"" size=""7""/>
                        <br />
                        <br />
                        <div class=""celldiv"">
                            <label>
                                <strong>  Save As :</stro");
                WriteLiteral(@"ng>
                            </label>&nbsp;&nbsp;
                            <input id=""rbtn2003"" type=""radio"" name=""SaveOption"" value=""ExcelXls"" onclick=""Disable()"" />
                            <label for=""rbtn2003"">
                                XLS
                            </label>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <input id=""rbtn2007"" type=""radio"" name=""SaveOption"" value=""ExcelXlsx"" checked=""checked"" onclick=""Enable()"" />
                            <label for=""rbtn2007"">
                                XLSX
                            </label>
                        </div>
                        <br />
                        <div class=""option"">
                            <input id=""import"" type=""checkbox"" name=""Import"" value=""importonsave"" />
                            <label for=""import"">
                                Import on Save
                            </label>
                            <br />
      ");
                WriteLiteral(@"                      <p style=""font-size:small"">Import on Save option directly serialize data while saving the workbook.</p>
                        </div>
                        <br />
                        <div class=""celldiv"">
                            <input class=""buttonStyle"" type=""submit"" value=""Create Document"" style="" width:200px;"" />
                        </div>
                    </div>
                    <br />
                </div>
            </div>
            <script>
                function Disable() {
                    document.getElementById(""import"").checked = false;
                    document.getElementById(""import"").disabled = true;
                }
                function Enable() {
                    document.getElementById(""import"").disabled = false;
                }
            </script>
");
                EndContext();
#line 85 "D:\Samples_20.3.0.47\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Performance.cshtml"
            Html.EndForm();
        }

#line default
#line hidden
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4335, 4, true);
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
