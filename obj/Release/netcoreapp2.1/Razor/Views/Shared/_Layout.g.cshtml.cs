#pragma checksum "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "761d161300f62dd33d83d87798999650c89a6588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
using samplebrowser.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761d161300f62dd33d83d87798999650c89a6588", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488cf0859d769c989f74107804b8f1f79d7d5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility:hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Syncfusion.JavaScript.TagHelperScriptManager __Syncfusion_JavaScript_TagHelperScriptManager;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(65, 2402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8e2c82d121d459fb4c34fae47256a06", async() => {
                BeginContext(71, 164, true);
                WriteLiteral("\r\n    <title>ASP.NET Core components rendered with server-side wrapper classes</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
                EndContext();
#line 7 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("MetaTags"))
    {
        

#line default
#line hidden
                BeginContext(291, 32, false);
#line 9 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(RenderSection("MetaTags", false));

#line default
#line hidden
                EndContext();
#line 9 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                         
    }

#line default
#line hidden
                BeginContext(332, 339, true);
                WriteLiteral(@"    <meta name=""author"" content=""Syncfusion"">
	<meta name=""description"" content=""Essential Studio for ASP.NET Core to add Syncfusion ASP.NET Core components with the help of the server-side wrapper classes."">
    <link rel=""canonical"" href=""https://aspnetcore.syncfusion.com"" />
    <meta charset=""utf-8"">
    <link rel=""shortcut icon""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 671, "\"", 718, 1);
#line 15 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 678, Url.Content("~/css/images/favicon.ico"), 678, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(719, 12, true);
                WriteLiteral(">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 731, "\"", 777, 1);
#line 16 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 738, Url.Content("~/css/bootstrap.min.css"), 738, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(778, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 809, "\"", 870, 1);
#line 17 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 816, Url.Content("~/css/ejthemes/ej.widgets.core.min.css"), 816, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(871, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 902, "\"", 969, 1);
#line 18 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 909, Url.Content("~/css/ejthemes/flat-saffron/ej.theme.min.css"), 909, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(970, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1001, "\"", 1071, 1);
#line 19 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1008, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 1008, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1072, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1103, "\"", 1153, 1);
#line 20 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1110, Url.Content("~/css/samplebrowsersite.css"), 1110, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1154, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1185, "\"", 1246, 1);
#line 21 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1192, Url.Content("~/css/samplebrowsersite-responsive.css"), 1192, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1247, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1278, "\"", 1329, 1);
#line 22 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1285, Url.Content("~/css/sourcetabformatter.css"), 1285, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1330, 26, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    ");
                EndContext();
                BeginContext(1357, 46, false);
#line 23 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
Write(RenderSection("StyleSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1403, 42, true);
                WriteLiteral("\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(1446, 45, false);
#line 25 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(1491, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1562, "\"", 1613, 1);
#line 28 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1568, Url.Content("~/Scripts/jquery-3.4.1.min.js"), 1568, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1614, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1659, "\"", 1705, 1);
#line 30 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1665, Url.Content("~/scripts/jsviews.min.js"), 1665, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1706, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1729, "\"", 1772, 1);
#line 31 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1735, Url.Content("~/scripts/jsrender.js"), 1735, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1773, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1796, "\"", 1850, 1);
#line 32 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1802, Url.Content("~/scripts/jquery.validate.min.js"), 1802, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1851, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1874, "\"", 1940, 1);
#line 33 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1880, Url.Content("~/scripts/jquery.validate.unobtrusive.min.js"), 1880, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1941, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1964, "\"", 2013, 1);
#line 34 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1970, Url.Content("~/scripts/ej.web.all.min.js"), 1970, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2014, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2037, "\"", 2089, 1);
#line 35 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2043, Url.Content("~/scripts/sampleBrowserSite.js"), 2043, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2090, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2113, "\"", 2159, 1);
#line 36 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2119, Url.Content("~/scripts/sampleslist.js"), 2119, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2160, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2183, "\"", 2228, 1);
#line 37 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2189, Url.Content("~/scripts/properties.js"), 2189, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2229, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2252, "\"", 2300, 1);
#line 38 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2258, Url.Content("~/scripts/zeroclipboard.js"), 2258, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2301, 27, true);
                WriteLiteral("></script>    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2328, "\"", 2384, 1);
#line 39 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2334, Url.Content("~/scripts/CodeMirror/codemirror.js"), 2334, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2385, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(2402, 56, false);
#line 40 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
Write(RenderSection("ScriptReferenceSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2458, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2467, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2469, 11737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec24acfc3234982b88a31fa452375d6", async() => {
                BeginContext(2501, 57, true);
                WriteLiteral("\r\n    <div class=\"htmljssamplebrowser saffron\">\r\n        ");
                EndContext();
                BeginContext(2559, 28, false);
#line 44 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(Html.Partial("LayoutHeader"));

#line default
#line hidden
                EndContext();
                BeginContext(2587, 96, true);
                WriteLiteral("\r\n        <div class=\"content-container-fluid\">\r\n            <div class=\"row\">\r\n                ");
                EndContext();
                BeginContext(2684, 35, false);
#line 47 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
           Write(Html.Partial("LayoutLeftAccordion"));

#line default
#line hidden
                EndContext();
                BeginContext(2719, 227, true);
                WriteLiteral("\r\n                <span class=\"navigation collapsePanel\"></span>\r\n                <div id=\"controlarea\" class=\"control-panel scrollit\" style=\"visibility:hidden;\">\r\n                    <div class=\"row\">\r\n                        ");
                EndContext();
                BeginContext(2947, 12, false);
#line 51 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2959, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                         if (IsSectionDefined("ControlsSection"))
                        {

#line default
#line hidden
                BeginContext(3055, 55, true);
                WriteLiteral("                            <div class=\"cols-iframe\">\r\n");
                EndContext();
#line 55 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                 if (IsSectionDefined("SampleHeading"))
                                {

#line default
#line hidden
                BeginContext(3218, 159, true);
                WriteLiteral("                                    <div>\r\n                                        <h1 class=\"sampleheadingtext\">\r\n                                            ");
                EndContext();
                BeginContext(3378, 47, false);
#line 59 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                       Write(RenderSection("SampleHeading", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3425, 93, true);
                WriteLiteral("\r\n                                        </h1>\r\n                                    </div>\r\n");
                EndContext();
#line 62 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
                BeginContext(3553, 462, true);
                WriteLiteral(@"                                <div>
                                    <div id=""samplefile"" class=""sample-container"">

                                        <div>
                                            <div class=""content-container-fluid"">
                                                <div class=""row"">
                                                    <div class=""cols-sample-area"">
                                                        ");
                EndContext();
                BeginContext(4016, 49, false);
#line 70 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                   Write(RenderSection("ControlsSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4065, 62, true);
                WriteLiteral("\r\n                                                    </div>\r\n");
                EndContext();
#line 72 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                     if (IsSectionDefined("PropertiesSection"))
                                                    {

#line default
#line hidden
                BeginContext(4279, 243, true);
                WriteLiteral("                                                        <div id=\"sampleProperties\">\r\n                                                            <div class=\"prop-grid keyboard\">\r\n                                                                ");
                EndContext();
                BeginContext(4523, 51, false);
#line 76 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                           Write(RenderSection("PropertiesSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4574, 134, true);
                WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n");
                EndContext();
#line 79 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(4763, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
#line 80 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                     if (IsSectionDefined("EventsDropDown"))
                                                    {

#line default
#line hidden
                BeginContext(4912, 513, true);
                WriteLiteral(@"                                                        <div class=""cols-prop-area event-tracer"">
                                                            <div>
                                                                <div class=""heading"">
                                                                    <span>Event Trace</span>
                                                                    <div class=""pull-right"">
                                                                        ");
                EndContext();
                BeginContext(5426, 48, false);
#line 87 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                                   Write(RenderSection("EventsDropDown", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(5474, 1132, true);
                WriteLiteral(@"
                                                                    </div>
                                                                </div>
                                                                <div class=""prop-grid content"">
                                                                    <div class=""eventarea"">
                                                                        <div class=""EventLog"" id=""EventLog"">
                                                                        </div>
                                                                    </div>
                                                                    <div class=""evtbtn"">
                                                                        <input type=""button"" class=""eventclear e-btn"" value=""Clear"" onclick=""onClear()"" />
                                                                    </div>
                                                                </div>
                        ");
                WriteLiteral("                                    </div>\r\n                                                        </div>\r\n");
                EndContext();
#line 101 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(6661, 379, true);
                WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""cols-source sourcecodeTab"">
                                ");
                EndContext();
                BeginContext(7042, 55, false);
#line 110 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                            Write(new HtmlString(Html.RenderSourceCodeTab("CodeViewTab")));

#line default
#line hidden
                EndContext();
                BeginContext(7098, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 112 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(7163, 1392, true);
                WriteLiteral(@"                        <div class=""control_ref"">
                            <span class=""ref_header"">OTHER RESOURCES</span>
                            <div class=""ref_options"">
                                <a id=""ref_document"">Documentation</a>
                                <a id=""ref_forums"">Forums</a>
                                <a id=""ref_kb"">Knowledge base</a>
                                <a id=""ref_support"" href=""https://www.syncfusion.com/support/directtrac"">Support</a>
                            </div>
                        </div>
                    </div>

                    <div id=""footer"">
                        <div class=""bottom-links"">
                            <div class=""left"">
                                <div class=""sync-text"">
                                    Copyright © 2001-2022 Syncfusion Inc.
                                </div>
                            </div>
                            <div class=""right"">
                           ");
                WriteLiteral(@"     <a href=""https://www.syncfusion.com"">
                                    <div class=""syncfusion-image"">
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    ");
                EndContext();
                BeginContext(8555, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a693be948fe442d2aaf209ad3a21bd22", async() => {
                }
                );
                __Syncfusion_JavaScript_TagHelperScriptManager = CreateTagHelper<global::Syncfusion.JavaScript.TagHelperScriptManager>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TagHelperScriptManager);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8594, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
#line 146 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ScriptSection"))
    {
        

#line default
#line hidden
                BeginContext(8663, 47, false);
#line 148 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ScriptSection", required: false));

#line default
#line hidden
                EndContext();
#line 148 "D:\Samples_20.2.0.43\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                        
    }

#line default
#line hidden
                BeginContext(8719, 5480, true);
                WriteLiteral(@"    <script>
        $(function () {
            if ($(""#CodeViewTab"").length > 0) {
                $(""#CodeViewTab"").addClass(""selectable"");
                $(""<span>"").attr(""id"", ""newcodewindow"").attr('title', 'New Window').addClass(""e-icon e-select newsrcwindow "").appendTo($(""#CodeViewTab .e-header""));
                if (!$(""#copyclipboard"").length) $(""<span>"").attr(""id"", ""copyclipboard"").attr('title', 'Copy To Clipboard').addClass("" e-icon e-select copycodeicon copycode"").appendTo($(""#CodeViewTab .e-header""));

                $("".sourcecodeTab"").on(""click"", '#newcodewindow', function () {
                    var popupWin = window.open();
                    var head = '<title> Essential JS 1 for ASP.NET Core </title>' + '<meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">' + '<meta content=""Essential JS 1 for ASP.NET Core"" name=""description"">' + '<meta content=""Syncfusion"" name=""author"">' + '<meta charset=""utf-8"">'
                    var links = $(document.head || document");
                WriteLiteral(@".getElementsByTagName('head')[0]).find(""link"");
                    var serverconfig = links[0].href.substr(0, links[0].href.indexOf(""Content"") - 1);
                    var scriptendtag = ""<"" + ""/"" + ""script"" + "">"";
                    var scripttag = '<script type=""text/javascript"" src=""' + serverconfig + '/scripts/jquery-1.11.3.min.js"">' + scriptendtag;
                    scripttag += '<script type=""text/javascript"" src=""' + serverconfig + '/scripts/ej.web.all.min.js"">' + scriptendtag;
                    scripttag += '<script type=""text/javascript"" src=""' + serverconfig + '/scripts/jquery.easing-1.3.min.js"">' + scriptendtag;
                    var linkelement = $(links).clone();
                    var linktag = """";
                    for (i = 0; i < linkelement.length; i++) {
                        linktag += $(linkelement[i]).wrap(""<p>"").parent().html();
                    }
                    var tabcontent = $("".sourcecodeTab"").clone();
                    tabcontent.find("".newsrcwin");
                WriteLiteral(@"dow"").remove();
                    $(tabcontent).find("".copycode"").each(function () { $(this).remove(); });
                    $(tabcontent).find(""script"").each(function () { $(this).remove(); });
                    tabcontent = tabcontent.html();
                    var a = $(""#CodeViewTab"").ejTab(""instance"");
                    a = parseInt(a.option(""selectedItemIndex""))
                    popupWin.document.writeln('<!doctype html><html><head>' + head + linktag + scripttag + '</head><body><div id=""windowOpen"" style=""width: 97%""><div class=""cols-source sourcecodeTab"">' + tabcontent + '</div></div>' + '<script type=""text/javascript"">$(function(){$(""#CodeViewTab"").ejTab({  selectedItemIndex:' + a + '});});' + scriptendtag + '</body></html>');
                    popupWin.document.close();

                });
                appendcopybutton();
            }
           // Copy to clipboard behavior


            if (!window.copytoclip) {
                copytoclip = {};
            }
   ");
                WriteLiteral(@"         copytoclip.Selector = {};
            copytoclip.Selector.getSelected = function () {
                var t = '';
                if (window.getSelection) {
                    t = window.getSelection();
                } else if (document.getSelection) {
                    t = document.getSelection();
                } else if (document.selection) {
                    t = document.selection.createRange().text;
                }
                return t;
            }
            initiateCopyHandler();
        });
        function appendcopybutton() {

            if (!$(""#clipboard"").length) {
                $(""<div>"").insertAfter($(""#CodeViewTab"")).attr(""id"", ""clipboard"");
                $(""<textarea>"").attr(""style"", ""display:none"").attr(""id"", ""copytextarea"").appendTo($(""#clipboard""));
                initiateCopyHandler();
            }
        }
        function initiateCopyHandler(e) {
            $('.copycode').on(""mouseover"", function () {
                $(""#copyte");
                WriteLiteral(@"xtarea"").val(copytoclip.Selector.getSelected());
            });
            try {
                var client = new ZeroClipboard($('.copycode'));

                client.on('ready', function (event) {
                    client.on('copy', function (event) {
                        event.clipboardData.setData('text/plain', copycontent());
                    });
                });

                client.on('error', function (event) {
                    console.log('ZeroClipboard error of type ""' + event.name + '"": ' + event.message);
                    ZeroClipboard.destroy();
                });

                function copycontent(e) {
                    if ($(""#copytextarea"").val() == """" || $(""#copytextarea"").val() == null) {
                        $(""#copytextarea"").val("""");
                        $(""#CodeViewTab >div:visible"").each(function () { $(""#copytextarea"").val($(""#copytextarea"").val() + $(this).text().replace(""COPY TO CLIPBOARD"", """").replace(""initiateCopyHandler();"", """"");
                WriteLiteral(@")); });
                    }
                    return $(""#copytextarea"").val();
                }

            }
            catch (e) { }
        }

        $(document).ready(function () {
            $(this).find('body').css('visibility', 'visible');
            $('.sbheader .themeswitch').css('display', 'inline-block');
});
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14206, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
