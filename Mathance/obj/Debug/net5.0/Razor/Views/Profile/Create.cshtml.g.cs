#pragma checksum "D:\itra\Mathance\Views\Profile\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b934e7a0fa780891b16ecea7d128ff07b8c53d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Create), @"mvc.1.0.view", @"/Views/Profile/Create.cshtml")]
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
#nullable restore
#line 1 "D:\itra\Mathance\Views\_ViewImports.cshtml"
using Mathance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\itra\Mathance\Views\_ViewImports.cshtml"
using Mathance.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\itra\Mathance\Views\Profile\Create.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\itra\Mathance\Views\Profile\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b934e7a0fa780891b16ecea7d128ff07b8c53d3", @"/Views/Profile/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bae84fa658e76327405ec7bfd2af2c2e63792d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mathance.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\itra\Mathance\Views\Profile\Create.cshtml"
  
    ViewData["Title"] = @_localizer["PageTitle"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css"">
<link href=""https://cdn.jsdelivr.net/gh/kartik-v/bootstrap-fileinput@5.2.5/css/fileinput.min.css"" media=""all"" rel=""stylesheet"" type=""text/css"" />

<h1 class=""display-4"">");
#nullable restore
#line 14 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                 Write(_localizer["CreateTask"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d36515", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"form-group\">        \r\n            <label for=\"topic\">");
#nullable restore
#line 19 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                          Write(_localizer["Topic"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <select class=\"form-select\" placeholder=\"Topic\" name=\"topic\" id=\"topic\" required>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d37234", async() => {
#nullable restore
#line 21 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                   Write(_localizer["HighMath"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d38396", async() => {
#nullable restore
#line 22 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                   Write(_localizer["MathAnal"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d39558", async() => {
#nullable restore
#line 23 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                   Write(_localizer["Algebra"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d310719", async() => {
#nullable restore
#line 24 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                   Write(_localizer["Geometry"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d311882", async() => {
#nullable restore
#line 25 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                   Write(_localizer["Programming"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        \r\n        <div class=\"form-group\">        \r\n            <label for=\"title\">");
#nullable restore
#line 30 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                          Write(_localizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input type=\"text\" class=\"form-control\" placeholder=\"Title\" name=\"title\" id=\"title\" required>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"mdeContainer\">\r\n                <label for=\"text\">");
#nullable restore
#line 36 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                             Write(_localizer["Text"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                <textarea name=""text"" class=""form-control"" id=""text"" rows=""5"" required></textarea>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""custom-file mt-1"">
                <input name=""images"" type=""file"" id=""inputGroupFile01"" accept="".jpg, .png, .jpeg"" multiple/>
            </div>
        </div>
        
        <div class=""form-group"">        
            <label>");
#nullable restore
#line 48 "D:\itra\Mathance\Views\Profile\Create.cshtml"
              Write(_localizer["Tags"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input type=\"text\" id=\"tag0\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2143, "\"", 2175, 1);
#nullable restore
#line 49 "D:\itra\Mathance\Views\Profile\Create.cshtml"
WriteAttributeValue("", 2157, _localizer["Tag"], 2157, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"tags\" autocomplete=\"off\" required>\r\n            <div id=\"inputTag\"></div>\r\n            <button type=\"button\" id=\"add-tag\" class=\"btn btn-red-light-alt\" onclick=\"addTagInput()\">");
#nullable restore
#line 51 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                                                                                                Write(_localizer["OneMoreTag"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n\r\n        <div class=\"form-group\">        \r\n            <label>");
#nullable restore
#line 55 "D:\itra\Mathance\Views\Profile\Create.cshtml"
              Write(_localizer["PossibleAnswers"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input id=\"answer\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2577, "\"", 2612, 1);
#nullable restore
#line 56 "D:\itra\Mathance\Views\Profile\Create.cshtml"
WriteAttributeValue("", 2591, _localizer["Answer"], 2591, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"rightanswers\" required>\r\n            <div id=\"inputAnswer0\"></div>\r\n            <button type=\"button\" class=\"btn btn-red-light-alt\" onclick=\"addAnswerInput()\">");
#nullable restore
#line 58 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                                                                                      Write(_localizer["OneMoreAnswer"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n        \r\n        <div class=\"form-group text-right\">\r\n            <input type=\"submit\" class=\"btn btn-red-light\"");
                BeginWriteAttribute("value", " value=\"", 2947, "\"", 2976, 1);
#nullable restore
#line 62 "D:\itra\Mathance\Views\Profile\Create.cshtml"
WriteAttributeValue("", 2955, _localizer["Create"], 2955, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                                                                                                                          WriteLiteral(ViewBag.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b934e7a0fa780891b16ecea7d128ff07b8c53d320040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://code.jquery.com/ui/1.13.0-rc.2/jquery-ui.min.js"" ></script>
<script src=""https://cdn.jsdelivr.net/gh/kartik-v/bootstrap-fileinput@5.2.5/js/fileinput.min.js""></script>

<script> 
    let tags = $.ajax('/Posts/GetTagsList', {
        contentType: ""application/json"",
            dataType: ""json"",
            type: ""GET"",
            global: false,
            async:false,
            success: function(response) {
                return response;
        },
        error: function(data) {
            alert(data);
        }
    }).responseText;
    
    $(""#tag0"").autocomplete({ source: JSON.parse(tags) });

    let iteratorForTags = 0;
    $(""#add-tag"").click(() => {
        let el = $('<input type=""text"" class=""form-control mt-2"" id=""tag'+ (iteratorForTags + 1) +'"" placeholder=""Tag"" name=""tags"" required>')
            .on('click', (function(e) { 
                $(this).autocomplete({ source: JSON.parse(tags) })
            }));
        $(""#inputTag"").append(el);");
            WriteLiteral(@"
        iteratorForTags++;
    });
    
    let iteratorForAnswers = 0; 
    function addAnswerInput() {
        document.getElementById('inputAnswer' + iteratorForAnswers).innerHTML = 
            '<input type=""text"" class=""form-control mt-2"" id=""answer"" placeholder=""Your answer"" name=""rightanswers"" required>' +
            '<div id=""inputAnswer' + (iteratorForAnswers + 1) + '""></div>';
        iteratorForAnswers++;
    }

");
#nullable restore
#line 107 "D:\itra\Mathance\Views\Profile\Create.cshtml"
       var requestCulture = Context.Features.Get<IRequestCultureFeature>(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("    let currentLanguage = \'");
#nullable restore
#line 108 "D:\itra\Mathance\Views\Profile\Create.cshtml"
                      Write(requestCulture.RequestCulture.UICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(""#inputGroupFile01"").fileinput({
        allowedFileTypes: ['image'],
        allowedFileExtensions : ['jpg', 'jpeg', 'png'],
        language: currentLanguage,
        showZoom: false,
        uploadAsync: false,
        dropZoneEnabled: true,
        showUpload: false,
        showRemove: true,
        showPreview: true,
        showBrowse: true,
        showCaption: false,
        showUploadStats: false,
        showCancel: false,
        showClose:false,
        browseOnZoneClick: true
    });
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer _localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mathance.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
