#pragma checksum "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc8d36fae30bd9dfda83bf3d72916d7ab7041a6"
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
#line 1 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
using samplebrowser.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc8d36fae30bd9dfda83bf3d72916d7ab7041a6", @"/Views/Shared/_Layout.cshtml")]
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
            BeginContext(65, 2747, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9af8a004171449b878ca050b775edc8", async() => {
                BeginContext(71, 164, true);
                WriteLiteral("\r\n    <title>ASP.NET Core components rendered with server-side wrapper classes</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("MetaTags"))
    {
        

#line default
#line hidden
                BeginContext(291, 32, false);
#line 9 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(RenderSection("MetaTags", false));

#line default
#line hidden
                EndContext();
#line 9 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                         
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
#line 15 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 678, Url.Content("~/css/images/favicon.ico"), 678, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(719, 12, true);
                WriteLiteral(">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 731, "\"", 777, 1);
#line 16 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 738, Url.Content("~/css/bootstrap.min.css"), 738, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(778, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 809, "\"", 870, 1);
#line 17 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 816, Url.Content("~/css/ejthemes/ej.widgets.core.min.css"), 816, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(871, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 902, "\"", 970, 1);
#line 18 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 909, Url.Content("~/css/ejthemes/ej.reportdesigner.core.min.css"), 909, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(971, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1002, "\"", 1069, 1);
#line 19 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1009, Url.Content("~/css/ejthemes/flat-saffron/ej.theme.min.css"), 1009, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1070, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1101, "\"", 1183, 1);
#line 20 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1108, Url.Content("~/css/ejthemes/flat-saffron/ej.reportdesigner.theme.min.css"), 1108, 75, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1184, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1215, "\"", 1285, 1);
#line 21 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1222, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 1222, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1286, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1317, "\"", 1367, 1);
#line 22 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1324, Url.Content("~/css/samplebrowsersite.css"), 1324, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1368, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1399, "\"", 1460, 1);
#line 23 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1406, Url.Content("~/css/samplebrowsersite-responsive.css"), 1406, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1461, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1492, "\"", 1543, 1);
#line 24 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1499, Url.Content("~/css/sourcetabformatter.css"), 1499, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1544, 26, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    ");
                EndContext();
                BeginContext(1571, 46, false);
#line 25 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
Write(RenderSection("StyleSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1617, 42, true);
                WriteLiteral("\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(1660, 45, false);
#line 27 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(1705, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1776, "\"", 1827, 1);
#line 30 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1782, Url.Content("~/Scripts/jquery-3.4.1.min.js"), 1782, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1828, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1873, "\"", 1919, 1);
#line 32 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1879, Url.Content("~/scripts/jsviews.min.js"), 1879, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1920, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1943, "\"", 1986, 1);
#line 33 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1949, Url.Content("~/scripts/jsrender.js"), 1949, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1987, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2010, "\"", 2064, 1);
#line 34 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2016, Url.Content("~/scripts/jquery.validate.min.js"), 2016, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2065, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2088, "\"", 2154, 1);
#line 35 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2094, Url.Content("~/scripts/jquery.validate.unobtrusive.min.js"), 2094, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2155, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2178, "\"", 2227, 1);
#line 36 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2184, Url.Content("~/scripts/ej.web.all.min.js"), 2184, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2228, 52, true);
                WriteLiteral("></script>\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2280, "\"", 2336, 1);
#line 38 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2286, Url.Content("~/scripts/ej.reportdesigner.min.js"), 2286, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2337, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2382, "\"", 2434, 1);
#line 40 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2388, Url.Content("~/scripts/sampleBrowserSite.js"), 2388, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2435, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2458, "\"", 2504, 1);
#line 41 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2464, Url.Content("~/scripts/sampleslist.js"), 2464, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2505, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2528, "\"", 2573, 1);
#line 42 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2534, Url.Content("~/scripts/properties.js"), 2534, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2574, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2597, "\"", 2645, 1);
#line 43 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2603, Url.Content("~/scripts/zeroclipboard.js"), 2603, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2646, 27, true);
                WriteLiteral("></script>    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2673, "\"", 2729, 1);
#line 44 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2679, Url.Content("~/scripts/CodeMirror/codemirror.js"), 2679, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2730, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(2747, 56, false);
#line 45 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
Write(RenderSection("ScriptReferenceSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2803, 2, true);
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
            BeginContext(2812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2814, 11737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "516ff837dfd84b13bb4b86393fb37794", async() => {
                BeginContext(2846, 57, true);
                WriteLiteral("\r\n    <div class=\"htmljssamplebrowser saffron\">\r\n        ");
                EndContext();
                BeginContext(2904, 28, false);
#line 49 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(Html.Partial("LayoutHeader"));

#line default
#line hidden
                EndContext();
                BeginContext(2932, 96, true);
                WriteLiteral("\r\n        <div class=\"content-container-fluid\">\r\n            <div class=\"row\">\r\n                ");
                EndContext();
                BeginContext(3029, 35, false);
#line 52 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
           Write(Html.Partial("LayoutLeftAccordion"));

#line default
#line hidden
                EndContext();
                BeginContext(3064, 227, true);
                WriteLiteral("\r\n                <span class=\"navigation collapsePanel\"></span>\r\n                <div id=\"controlarea\" class=\"control-panel scrollit\" style=\"visibility:hidden;\">\r\n                    <div class=\"row\">\r\n                        ");
                EndContext();
                BeginContext(3292, 12, false);
#line 56 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3304, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                         if (IsSectionDefined("ControlsSection"))
                        {

#line default
#line hidden
                BeginContext(3400, 55, true);
                WriteLiteral("                            <div class=\"cols-iframe\">\r\n");
                EndContext();
#line 60 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                 if (IsSectionDefined("SampleHeading"))
                                {

#line default
#line hidden
                BeginContext(3563, 159, true);
                WriteLiteral("                                    <div>\r\n                                        <h1 class=\"sampleheadingtext\">\r\n                                            ");
                EndContext();
                BeginContext(3723, 47, false);
#line 64 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                       Write(RenderSection("SampleHeading", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3770, 93, true);
                WriteLiteral("\r\n                                        </h1>\r\n                                    </div>\r\n");
                EndContext();
#line 67 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
                BeginContext(3898, 462, true);
                WriteLiteral(@"                                <div>
                                    <div id=""samplefile"" class=""sample-container"">

                                        <div>
                                            <div class=""content-container-fluid"">
                                                <div class=""row"">
                                                    <div class=""cols-sample-area"">
                                                        ");
                EndContext();
                BeginContext(4361, 49, false);
#line 75 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                   Write(RenderSection("ControlsSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4410, 62, true);
                WriteLiteral("\r\n                                                    </div>\r\n");
                EndContext();
#line 77 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                     if (IsSectionDefined("PropertiesSection"))
                                                    {

#line default
#line hidden
                BeginContext(4624, 243, true);
                WriteLiteral("                                                        <div id=\"sampleProperties\">\r\n                                                            <div class=\"prop-grid keyboard\">\r\n                                                                ");
                EndContext();
                BeginContext(4868, 51, false);
#line 81 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                           Write(RenderSection("PropertiesSection", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4919, 134, true);
                WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n");
                EndContext();
#line 84 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(5108, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
#line 85 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                     if (IsSectionDefined("EventsDropDown"))
                                                    {

#line default
#line hidden
                BeginContext(5257, 513, true);
                WriteLiteral(@"                                                        <div class=""cols-prop-area event-tracer"">
                                                            <div>
                                                                <div class=""heading"">
                                                                    <span>Event Trace</span>
                                                                    <div class=""pull-right"">
                                                                        ");
                EndContext();
                BeginContext(5771, 48, false);
#line 92 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                                   Write(RenderSection("EventsDropDown", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(5819, 1132, true);
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
#line 106 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(7006, 379, true);
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
                BeginContext(7387, 55, false);
#line 115 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                            Write(new HtmlString(Html.RenderSourceCodeTab("CodeViewTab")));

#line default
#line hidden
                EndContext();
                BeginContext(7443, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 117 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(7508, 1392, true);
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
                                    Copyright © 2001-2021 Syncfusion Inc.
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
                BeginContext(8900, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11431ad20b88446fb3e50fcf9d4240b7", async() => {
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
                BeginContext(8939, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
#line 151 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ScriptSection"))
    {
        

#line default
#line hidden
                BeginContext(9008, 47, false);
#line 153 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ScriptSection", required: false));

#line default
#line hidden
                EndContext();
#line 153 "D:\Samples_19.1.0.63\FileFormats\ASPNETCORE\IOsamplebrowser\Views\Shared\_Layout.cshtml"
                                                        
    }

#line default
#line hidden
                BeginContext(9064, 5480, true);
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
            BeginContext(14551, 11, true);
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
