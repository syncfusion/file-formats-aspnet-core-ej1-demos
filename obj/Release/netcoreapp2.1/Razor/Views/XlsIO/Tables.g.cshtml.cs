#pragma checksum "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Tables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6a8690343c02ded90dab4fb3e88061e5f77e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_Tables), @"mvc.1.0.view", @"/Views/XlsIO/Tables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/Tables.cshtml", typeof(AspNetCore.Views_XlsIO_Tables))]
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
#line 1 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Tables.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6a8690343c02ded90dab4fb3e88061e5f77e13", @"/Views/XlsIO/Tables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_Tables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 46, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / Tables</span>");
                EndContext();
            }
            );
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(152, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Tables.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) : Excel 2007, Tables, Table Styles : Syncfusion";

#line default
#line hidden
                BeginContext(292, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Tables.cshtml"
  Html.BeginForm("Tables", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(352, 961, true);
                WriteLiteral(@"    <div class=""Common1"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                <label>
                    Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                    note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <input class=""checkboxStyle"" name=""checkbox"" type=""checkbox"" value=""Apply custom style"" style=""width:25px;"" />Apply custom style
                </div>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <input class=""buttonStyle"" type=""submit"" name=""button"" value=""Create Document"" style=""width:200px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 33 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\XlsIO\Tables.cshtml"
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
