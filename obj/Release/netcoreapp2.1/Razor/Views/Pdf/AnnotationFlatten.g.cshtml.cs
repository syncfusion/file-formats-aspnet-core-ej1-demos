#pragma checksum "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\AnnotationFlatten.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88110bcb19e3f57e894743230b8e08045263e7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_AnnotationFlatten), @"mvc.1.0.view", @"/Views/Pdf/AnnotationFlatten.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/AnnotationFlatten.cshtml", typeof(AspNetCore.Views_Pdf_AnnotationFlatten))]
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
#line 1 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88110bcb19e3f57e894743230b8e08045263e7a1", @"/Views/Pdf/AnnotationFlatten.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_AnnotationFlatten : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 73, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Graphics/AnnotationFlatten Sample</span>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(126, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\AnnotationFlatten.cshtml"
      Html.BeginForm("AnnotationFlatten", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(207, 1554, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates the creation of different type of annotations such as ink, free text, pop up, text markup annotation and more. The Essential PDF supports  <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-annotations#supported-annotation-types"">20+ annotations</a> with create, edit, and delete support.
                </div>
                <br />
                <div>
                    <input id=""checkboxFlatten"" type=""checkbox"" name=""checkboxFlatten"" value=""Flatten"">
                    <label for=""Opentype"">Flatten annotation</label>
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""w");
                WriteLiteral(@"idth: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">
                    This feature can be used for reviewing purpose.
                    More information about the annotations can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-annotations""> section. </a>
                </div>
            </div>
");
                EndContext();
#line 33 "D:\Samples_19.4.0.38\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\AnnotationFlatten.cshtml"
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
