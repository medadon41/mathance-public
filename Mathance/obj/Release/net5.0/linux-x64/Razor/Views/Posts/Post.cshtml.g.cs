#pragma checksum "D:\itra\Mathance\Views\Posts\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1ece9d020e51b2dd1363286d751f1ea3125a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Post), @"mvc.1.0.view", @"/Views/Posts/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1ece9d020e51b2dd1363286d751f1ea3125a70", @"/Views/Posts/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bae84fa658e76327405ec7bfd2af2c2e63792d", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mathance.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Identity/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentDislike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/comments.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"post-container\">\r\n    <div class=\"post-header\">\r\n        <div class=\"post-title\">\r\n         <h1>");
#nullable restore
#line 6 "D:\itra\Mathance\Views\Posts\Post.cshtml"
        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "D:\itra\Mathance\Views\Posts\Post.cshtml"
             if(ViewBag.isSolved)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <button type=\"button\" class=\"btn btn-green-light float-right\">\r\n                    <i class=\"bi bi-check2\"></i> Solved!\r\n                </button>\r\n");
#nullable restore
#line 12 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            } 
            else if(ViewBag.currentUser == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-red-light-secondary float-right\" data-toggle=\"modal\" data-target=\"#answerSubmit\" disabled>\r\n                    <i class=\"bi bi-lightbulb\"></i> Submit a solution\r\n                </button>\r\n");
#nullable restore
#line 17 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-red-light float-right\" data-toggle=\"modal\" data-target=\"#answerSubmit\">\r\n                    <i class=\"bi bi-lightbulb\"></i> Submit a solution\r\n                </button>\r\n");
#nullable restore
#line 23 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""modal fade"" id=""answerSubmit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                             <h5 class=""modal-title"" id=""exampleModalLabel"">Submit an answer</h5>
                             <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                             </button>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a708496", async() => {
                WriteLiteral(@"
                        <div class=""modal-body"">
                        <input type=""text"" class=""form-control"" placeholder=""Your answer""/ name=""answer"">
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button type=""submit"" class=""btn btn-red-light-secondary"">Check</button>
                        </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n         </div>\r\n         <p>Posted on ");
#nullable restore
#line 46 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                 Write(Model.PostedDate.ToString("HH:mm MM.dd.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" by <a href=\"#\">");
#nullable restore
#line 46 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                               Write(Model.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n         <p>Topic: <a href=\"#\">");
#nullable restore
#line 47 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                          Write(Model.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\r\n    </div>\r\n    <div class=\"post-body\">\r\n         <p>");
#nullable restore
#line 51 "D:\itra\Mathance\Views\Posts\Post.cshtml"
       Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n         <ul class=\"navbar-nav flex-grow-1 post-images\">\r\n");
#nullable restore
#line 53 "D:\itra\Mathance\Views\Posts\Post.cshtml"
             foreach(var i in Model.Images)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item img-small\" data-toggle=\"modal\" data-target=\"#imgFullSize_");
#nullable restore
#line 55 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                                        Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><img");
            BeginWriteAttribute("src", " src=\"", 2810, "\"", 2823, 1);
#nullable restore
#line 55 "D:\itra\Mathance\Views\Posts\Post.cshtml"
WriteAttributeValue("", 2816, i.Link, 2816, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></li>\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2889, "\"", 2911, 2);
            WriteAttributeValue("", 2894, "imgFullSize_", 2894, 12, true);
#nullable restore
#line 56 "D:\itra\Mathance\Views\Posts\Post.cshtml"
WriteAttributeValue("", 2906, i.Id, 2906, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n                    <div class=\"modal-dialog\" role=\"document\">\r\n                        <div class=\"modal-content\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3147, "\"", 3160, 1);
#nullable restore
#line 59 "D:\itra\Mathance\Views\Posts\Post.cshtml"
WriteAttributeValue("", 3153, i.Link, 3153, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 63 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <p>Tags: \r\n");
#nullable restore
#line 66 "D:\itra\Mathance\Views\Posts\Post.cshtml"
             foreach(var t in Model.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\'badge badge-light\'>");
#nullable restore
#line 68 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                        Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 69 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n    </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"post-comments\">\r\n");
#nullable restore
#line 75 "D:\itra\Mathance\Views\Posts\Post.cshtml"
     if(ViewBag.currentUser == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h6 class=\"font-weight-light\">Please ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7016328", async() => {
                WriteLiteral("log in");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to leave a comment</h6>\r\n        </div>\r\n        <hr/>\r\n");
#nullable restore
#line 81 "D:\itra\Mathance\Views\Posts\Post.cshtml"
    } 
    else 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7017646", async() => {
                WriteLiteral("\r\n        <div class=\"input-group mb-3\">\r\n            <input type=\"text\" class=\"form-control comment-input\" id=\"comment-input\"");
                BeginWriteAttribute("name", " name=\"", 3936, "\"", 3972, 1);
#nullable restore
#line 86 "D:\itra\Mathance\Views\Posts\Post.cshtml"
WriteAttributeValue("", 3943, ViewBag.CurrentUser.UserName, 3943, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Leave a comment\" aria-describedby=\"button-addon2\" name=\"text\">\r\n                <button type=\"submit\" class=\"btn btn-red-light\" id=\"button-addon2\"");
                BeginWriteAttribute("name", " name=\"", 4133, "\"", 4149, 1);
#nullable restore
#line 87 "D:\itra\Mathance\Views\Posts\Post.cshtml"
WriteAttributeValue("", 4140, Model.Id, 4140, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">Submit</button>\r\n        </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "D:\itra\Mathance\Views\Posts\Post.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"comments\">\r\n");
#nullable restore
#line 92 "D:\itra\Mathance\Views\Posts\Post.cshtml"
     if(Model.Comments.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\itra\Mathance\Views\Posts\Post.cshtml"
         foreach(var c in Model.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"comment\">\r\n                <div>\r\n");
#nullable restore
#line 98 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                     if (c.Author == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b>DELETED_USER </b>\r\n");
#nullable restore
#line 101 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    } 
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <b>");
#nullable restore
#line 104 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                     Write(c.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> \r\n");
#nullable restore
#line 105 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i class=\"font-weight-light mt-1\">on ");
#nullable restore
#line 106 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                Write(c.PostedTime.ToString("HH:mm MM.dd.yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></div>\r\n            <div>");
#nullable restore
#line 107 "D:\itra\Mathance\Views\Posts\Post.cshtml"
            Write(c.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7022213", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                     if ((c.Likes.Select(a => a.User).ToList()).Contains(ViewBag.CurrentUser))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"bi bi-chevron-double-up\" fill=\"#00BFFF\"></i>\r\n");
#nullable restore
#line 112 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    } else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"bi bi-chevron-up\" fill=\"#00BFFF\"></i>\r\n");
#nullable restore
#line 115 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                                              WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <label>");
#nullable restore
#line 117 "D:\itra\Mathance\Views\Posts\Post.cshtml"
              Write(c.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7026361", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 120 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                     if ((c.Dislikes.Select(a => a.User).ToList()).Contains(ViewBag.CurrentUser))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"bi bi-chevron-double-down\" fill=\"#00BFFF\"></i>\r\n");
#nullable restore
#line 123 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    } else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"bi bi-chevron-down\" fill=\"#00BFFF\"></i>\r\n");
#nullable restore
#line 126 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "D:\itra\Mathance\Views\Posts\Post.cshtml"
                                                                                                 WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <label>");
#nullable restore
#line 128 "D:\itra\Mathance\Views\Posts\Post.cshtml"
              Write(c.Dislikes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <hr/>\r\n");
#nullable restore
#line 131 "D:\itra\Mathance\Views\Posts\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\itra\Mathance\Views\Posts\Post.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7030896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea1ece9d020e51b2dd1363286d751f1ea3125a7031936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mathance.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591