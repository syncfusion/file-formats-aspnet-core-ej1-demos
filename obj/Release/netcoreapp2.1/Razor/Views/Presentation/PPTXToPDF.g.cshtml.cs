#pragma checksum "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\PPTXToPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d84c5a22d840f420fdbe83c1ef1edec5300fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presentation_PPTXToPDF), @"mvc.1.0.view", @"/Views/Presentation/PPTXToPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Presentation/PPTXToPDF.cshtml", typeof(AspNetCore.Views_Presentation_PPTXToPDF))]
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
#line 1 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\PPTXToPDF.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\PPTXToPDF.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d84c5a22d840f420fdbe83c1ef1edec5300fb0", @"/Views/Presentation/PPTXToPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Presentation_PPTXToPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 64, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Presentation / PPTXToPDF</span>\r\n");
                EndContext();
            }
            );
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\PPTXToPDF.cshtml"
      Html.BeginForm("PPTXToPDF", "Presentation", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(278, 2336, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to convert a PowerPoint presentation to PDF.
                        <br />
                        &nbsp;
                        <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                            Click the button to convert the PowerPoint presentation to PDF document by using Essential Presentation and Essential PDF.
                            <br />
                            <b>Note:</b> Adobe Reader or its equivalent is required to view the resultant document.
                            <br />
                            <div class=""rowdiv"" style=""margin-top: 10px"">
                                <div class=""rowdiv"" style=""margin-top: 8px"">
                                    <input id=""viewtemplate"" name=""view"" class=""buttonStyle"" type=""submit"" ");
                WriteLiteral(@"value=""Input Template"" style=""width: 150px; height: 27px"" />
                                    &nbsp;
                                    <input id=""generate"" name=""view"" class=""buttonStyle"" type=""submit"" value=""Convert to PDF"" style=""width:150px;height:27px"" />
                                </div>
                                </div>
                            </div>
                        </div>
                    <br />
                    <div class=""rowdiv"">
                        <b>Features:</b>
                        <br />
                        <ul>
                            <li>
                                Convert all slide elements like text, shape, SmartArt diagram, table, etc., along with its formatting.
                            </li>
                            <li>
                                Convert with handouts option.
                            </li>
                            <li>
                                Convert the notes pages to PDF.");
                WriteLiteral(@"
                            </li>
                            <li>
                                Converted PDF document size can be optimized.
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
");
                EndContext();
#line 51 "D:\Samples_19.3.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Presentation\PPTXToPDF.cshtml"
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
