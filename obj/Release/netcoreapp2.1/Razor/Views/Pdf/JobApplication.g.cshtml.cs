#pragma checksum "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\JobApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8089af2d8c62b295d577dc811a9344e1da29a9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_JobApplication), @"mvc.1.0.view", @"/Views/Pdf/JobApplication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/JobApplication.cshtml", typeof(AspNetCore.Views_Pdf_JobApplication))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8089af2d8c62b295d577dc811a9344e1da29a9f0", @"/Views/Pdf/JobApplication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_JobApplication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 79, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Product ShowCase/Job Application Sample</span>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(130, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 6 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\JobApplication.cshtml"
      Html.BeginForm("JobApplication", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(210, 1155, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates the creation of job application form from the scratch using <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-forms"">form fields.</a> The user can fill the online job application, then download as a PDF document.
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

                    This is a good example that illustrates how to use the Essential PDF in ");
                WriteLiteral("any requirements like invoice, job applications, pay slips, bank statements and more.\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 28 "D:\Samples_20.3.0.56\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\JobApplication.cshtml"
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
