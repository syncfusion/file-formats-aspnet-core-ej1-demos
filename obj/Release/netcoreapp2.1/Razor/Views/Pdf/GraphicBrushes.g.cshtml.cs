#pragma checksum "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\GraphicBrushes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e17355f7cab6bd8721dffcf7f2ec70488907bcc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_GraphicBrushes), @"mvc.1.0.view", @"/Views/Pdf/GraphicBrushes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/GraphicBrushes.cshtml", typeof(AspNetCore.Views_Pdf_GraphicBrushes))]
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
#line 1 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e17355f7cab6bd8721dffcf7f2ec70488907bcc9", @"/Views/Pdf/GraphicBrushes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_GraphicBrushes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 66, true);
                WriteLiteral(" <span class=\"sampleName\">Graphics / Graphic Brushes Sample</span>");
                EndContext();
            }
            );
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(119, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 4 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\GraphicBrushes.cshtml"
      Html.BeginForm("GraphicBrushes", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(197, 928, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates drawing of shapes with different brushes such as solid, tiling, Linear gradient, Radial gradient, and with different <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-colorspace"">color spaces.</a> such as Cal RGB, ICC, Exponential interpolation, pantone, and indexed color space.
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
                EndContext();
#line 21 "D:\Samples_19.4.0.48\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\GraphicBrushes.cshtml"
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
