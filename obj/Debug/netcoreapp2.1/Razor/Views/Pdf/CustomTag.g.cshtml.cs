#pragma checksum "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\CustomTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e6ed168a798460b1b0834d894c80698b632a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_CustomTag), @"mvc.1.0.view", @"/Views/Pdf/CustomTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/CustomTag.cshtml", typeof(AspNetCore.Views_Pdf_CustomTag))]
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
#line 5 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e6ed168a798460b1b0834d894c80698b632a32", @"/Views/Pdf/CustomTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_CustomTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 61, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">PDF /Customtag Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\CustomTag.cshtml"
      Html.BeginForm("Customtag", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(187, 1196, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to create tagged PDF or accessible PDF from the scratch with custom tags.
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
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">
                    This feature can be used for the people who require assistive technologies when the electronic content is ready.The Essential PDF supports creating tagged PDF with Section 508 compliant.More information about the tagged PDF ca");
                WriteLiteral("n be found in this documentation <a href=\"https://help.syncfusion.com/file-formats/pdf/working-with-tagged-pdf\">section.</a>\r\n\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 28 "D:\Samples_18.4.0.30\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\CustomTag.cshtml"
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
