#pragma checksum "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\ExtractText.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66982c2bea5043a2f817102c5501ac2d6e6b4dbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_ExtractText), @"mvc.1.0.view", @"/Views/Pdf/ExtractText.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/ExtractText.cshtml", typeof(AspNetCore.Views_Pdf_ExtractText))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66982c2bea5043a2f817102c5501ac2d6e6b4dbc", @"/Views/Pdf/ExtractText.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_ExtractText : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 59, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Extract Text Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(85, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\ExtractText.cshtml"
      Html.BeginForm("ExtractText", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(189, 1722, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <label class=""rowdiv"" style = ""font-size: 17px;font-weight: 400;"">
                        This sample demonstrates how to extract the text from the PDF document.
                    </label>
                </div>
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px;"">
                                <table style=""width:100%"">
                                    <tr>
                                        <td align=""right"">
                                            <input type=""submit"" class=""Button"" value=""View Template"" name=""ViewTemplate"" />
                                            <input type=""submit"" class=""Button"" value=""Extract Text"" name=""Extract"" />
                                        </td>
                               ");
                WriteLiteral(@"     </tr>
                                </table>
                            </div>

                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">

                    This feature can be used to extract information such as user data, billing information from invoice, address, and so on from the PDF document for indexing and archiving.
                    More information about the text extraction can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-text-extraction"">section.</a>
                </div>
            </div>
");
                EndContext();
#line 39 "D:\Samples_19.1.0.54\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Pdf\ExtractText.cshtml"
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