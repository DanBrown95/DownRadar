#pragma checksum "C:\Users\dan\Documents\Side\DownRadarCore\DownRadar\DownRadar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bb54952b335fffbb3f61f2333e74f7d47a6993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\dan\Documents\Side\DownRadarCore\DownRadar\DownRadar\Views\_ViewImports.cshtml"
using DownRadar;

#line default
#line hidden
#line 2 "C:\Users\dan\Documents\Side\DownRadarCore\DownRadar\DownRadar\Views\_ViewImports.cshtml"
using DownRadar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bb54952b335fffbb3f61f2333e74f7d47a6993", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2eefd05225b49e68f179a7a9a3978b3230311e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return pingUrl()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return subscribe();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dan\Documents\Side\DownRadarCore\DownRadar\DownRadar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 269, true);
            WriteLiteral(@"
<div class=""jumbotron"" style=""text-align: center;"">
    <h2>Down Radar</h2>
    <p>Check the status of a domain or set up mobile alerts to be notified when that domain goes down</p>
</div>
<div class=""row"">
    <div class=""col-md-7"">
        <div>
            ");
            EndContext();
            BeginContext(314, 616, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7bb54952b335fffbb3f61f2333e74f7d47a69934507", async() => {
                BeginContext(348, 575, true);
                WriteLiteral(@"
                <h6 for=""url"">Enter the url you wish to check</h6>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">http://</span>
                    </div>
                    <input type=""text"" class=""input-group-text"" id=""url"" min=""7"" required>
                    <span class=""input-group-btn pull-left"">
                        <button class=""btn btn-success"" type=""submit"">Go!</button>
                    </span>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(930, 77, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <br />\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1007, 1334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7bb54952b335fffbb3f61f2333e74f7d47a69936718", async() => {
                BeginContext(1044, 1290, true);
                WriteLiteral(@"
                <h6 for=""subscribe-url"">Subscribe to a url and receive alerts to your cell?</h6>
                <div class=""input-group mb-1"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">http://</span>
                    </div>
                    <input type=""text"" class=""input-group-text"" id=""subscribe-url"" min=""7"" required>
                </div><br />
                <div class=""input-group mb-1"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">(  + 1  )</span>
                    </div>
                    <input type=""text"" class=""input-group-text"" id=""mobile"" minLenth=""10"" maxlength=""10"" pattern=""[1-9]{1}[0-9]{9}"" required>
                </div><br />

                <p for=""hours"">Be notified for how many hours?</p>
                <div class=""input-group col-sm-2 mb-2"" style=""padding-left: 0;"">
                    <input class=""form-control"" id=""hours"" ty");
                WriteLiteral(@"pe=""number"" min=""1"" max=""48"" value=""1"" required />
                </div>
                <div class=""input-group"" style=""margin-top: 1em;"">
                    <button class=""btn btn-success"" type=""submit"">Subscribe</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2341, 1453, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group col-md-5 pull-left"">
        <h4 for=""result-window"">Status Results</h4>
        <textarea id=""result-window"" rows=""20"" class=""form-control"" style=""background-color: black; min-width: 100%; resize: none;"" readonly></textarea>
    </div>
</div>

<script type=""text/javascript"">
    function pingUrl() {
        var url = document.getElementById(""url"").value;
        $.ajax({
            type: ""GET"",
            url: ""/Detector/PingUrl"",
            data: { url: url },
            success: function (data) {
                $('#result-window').html($('#result-window').val() + '&#10;' + data.url + '&#10;' + data.result);
            }
        })
        return false;
    }

    function subscribe() {
        var url = document.getElementById(""subscribe-url"").value;
        var phone = document.getElementById(""mobile"").value;
        var hours = document.getElementById(""hours"").value;

        $.ajax({
            type: ""POST"",
     ");
            WriteLiteral(@"       url: ""/SMS/Subscribe"",
            data: {
                url: url,
                phone: phone,
                hours: hours
            },
            success: function (data) {
                $('#result-window').html($('#result-window').val() + '&#10;' + ""Successfully subscribed to "" + data.url);
                console.log(""data"", data);
            }
        })
        return false;
    }
</script>");
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
