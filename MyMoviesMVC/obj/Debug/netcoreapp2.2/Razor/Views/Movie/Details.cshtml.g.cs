#pragma checksum "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52364d52019bf0e4099ff71ee497497772e710a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Details.cshtml", typeof(AspNetCore.Views_Movie_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52364d52019bf0e4099ff71ee497497772e710a5", @"/Views/Movie/Details.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMoviesMVC.ModelsDTO.Movie.MovieMainDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Movies/Details/details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/views.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("views"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(`Do you want to remove this movie?`)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("loader"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove-comment-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Movies/Details/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
   
    Layout = "_Layout";
    ViewData["Title"] = Model.Title;

#line default
#line hidden
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(194, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(201, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52364d52019bf0e4099ff71ee497497772e710a59486", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(282, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(287, 65, true);
            WriteLiteral("\r\n<div id=\"movie-info\">\r\n    <div id=\"movie-cover\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 352, "\"", 390, 2);
            WriteAttributeValue("", 358, "data:image/*;base64,", 358, 20, true);
#line 15 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
WriteAttributeValue("", 378, Model.Cover, 378, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 391, "\"", 409, 1);
#line 15 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
WriteAttributeValue("", 397, Model.Title, 397, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(410, 42, true);
            WriteLiteral(" />\r\n    </div>\r\n    <h2 id=\"movie-title\">");
            EndContext();
            BeginContext(453, 11, false);
#line 17 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(464, 82, true);
            WriteLiteral("</h2>\r\n    <div id=\"genre\">\r\n        <h4 id=\"movie-genre\">Genre:</h4>\r\n        <p>");
            EndContext();
            BeginContext(547, 11, false);
#line 20 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
      Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(558, 48, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <p id=\"movie-description\">");
            EndContext();
            BeginContext(607, 17, false);
#line 22 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                         Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(624, 42, true);
            WriteLiteral("</p>\r\n    <div id=\"movie-views\">\r\n        ");
            EndContext();
            BeginContext(666, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52364d52019bf0e4099ff71ee497497772e710a513233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(710, 13, true);
            WriteLiteral("\r\n        <p>");
            EndContext();
            BeginContext(724, 26, false);
#line 25 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
      Write(Model.Views.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(750, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(809, 123, true);
            WriteLiteral("        <div id=\"admin-action\">\r\n            <h4>Admin section</h4>\r\n            <div id=\"admin-section\">\r\n                ");
            EndContext();
            BeginContext(932, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52364d52019bf0e4099ff71ee497497772e710a515306", async() => {
                BeginContext(1001, 6, true);
                WriteLiteral("Modify");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1011, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1029, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52364d52019bf0e4099ff71ee497497772e710a517910", async() => {
                BeginContext(1162, 6, true);
                WriteLiteral("Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1172, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1217, 164, true);
            WriteLiteral("    <div id=\"user-section\">\r\n        <h4>Manage movie for your watchlist</h4>\r\n        <div id=\"loading-data\">\r\n            <input id=\"movie-id-input\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1381, "\"", 1398, 1);
#line 40 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
WriteAttributeValue("", 1389, Model.Id, 1389, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 17, true);
            WriteLiteral(" />\r\n            ");
            EndContext();
            BeginContext(1416, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52364d52019bf0e4099ff71ee497497772e710a521498", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 249, true);
            WriteLiteral("\r\n        </div>\r\n        <div id=\"user-actions-movie\">\r\n\r\n        </div>\r\n        <div id=\"data-errors\">\r\n\r\n        </div>\r\n        <div id=\"view-comments\">\r\n            <p><b>Comments:</b></p>\r\n        </div>\r\n        <div id=\"comments-section\">\r\n");
            EndContext();
#line 53 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
            if (Model.Comments.Count == 0)
            {

#line default
#line hidden
            BeginContext(1770, 83, true);
            WriteLiteral("                <p style=\"margin-top: 10px; color: #ff6a00;\">Nothing to show.</p>\r\n");
            EndContext();
#line 56 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
            }
            else
            {
               

#line default
#line hidden
#line 59 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                foreach (var comment in Model.Comments)
                {

#line default
#line hidden
            BeginContext(1977, 185, true);
            WriteLiteral("                    <div class=\"comment-wrapper\">\r\n                        <div class=\"movie-comment\">\r\n                        <div class=\"user-info\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2162, "\"", 2215, 2);
            WriteAttributeValue("", 2168, "data:image*;base64,", 2168, 19, true);
#line 64 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
WriteAttributeValue("", 2187, comment.User.ProfilePicture, 2187, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2216, 80, true);
            WriteLiteral(" alt=\"user\" />\r\n                            <p class=\"comment-user-fullname\"><b>");
            EndContext();
            BeginContext(2297, 22, false);
#line 65 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                                           Write(comment.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2319, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2321, 21, false);
#line 65 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                                                                   Write(comment.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 43, true);
            WriteLiteral(":</b></p>\r\n                        </div>\r\n");
            EndContext();
#line 67 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                        if (User.IsInRole("admin") && Convert.ToInt32(User.FindFirst("Id").Value) == comment.User.Id)
                        {

#line default
#line hidden
            BeginContext(2531, 27, true);
            WriteLiteral("                           ");
            EndContext();
            BeginContext(2558, 306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52364d52019bf0e4099ff71ee497497772e710a526095", async() => {
                BeginContext(2673, 187, true);
                WriteLiteral("\r\n                               <div class=\"remove-comment\">\r\n                                    <span>&times;</span>\r\n                               </div>\r\n                           ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                                                                                                     WriteLiteral(comment.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2864, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(2893, 109, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"comment\">\r\n                           <p>");
            EndContext();
            BeginContext(3003, 15, false);
#line 77 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                         Write(comment.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 66, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 80 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                }

#line default
#line hidden
#line 80 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3118, 60, true);
            WriteLiteral("        </div>\r\n        <div id=\"add-comment\">\r\n            ");
            EndContext();
            BeginContext(3178, 533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52364d52019bf0e4099ff71ee497497772e710a530404", async() => {
                BeginContext(3267, 72, true);
                WriteLiteral("\r\n                <input id=\"movie-id-form\" name=\"MovieId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3339, "\"", 3356, 1);
#line 85 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
WriteAttributeValue("", 3347, Model.Id, 3347, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3357, 347, true);
                WriteLiteral(@" />
                <div class=""form-inputs"">
                    <textarea id=""comment-field"" name=""Comment"" placeholder=""Add Comment"" rows=""5"" required maxlength=""400""></textarea>
                </div>
                <div>
                    <input id=""post-comment"" type=""submit"" value=""Comment"" />
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3711, 42, true);
            WriteLiteral("\r\n            <div id=\"add-movie-alert\">\r\n");
            EndContext();
#line 94 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                if (ViewData["AddNote"] != null)
                {

#line default
#line hidden
            BeginContext(3822, 50, true);
            WriteLiteral("                    <p style=\"color:forestgreen;\">");
            EndContext();
            BeginContext(3873, 30, false);
#line 96 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                             Write(ViewData["AddNote"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3903, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 97 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                }
                else if (ViewData["AddError"] != null)
                {

#line default
#line hidden
            BeginContext(4003, 42, true);
            WriteLiteral("                    <p style=\"color:red;\">");
            EndContext();
            BeginContext(4046, 31, false);
#line 100 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                                     Write(ViewData["AddError"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4077, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 101 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Movie\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(4102, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4178, 77, true);
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/axios/dist/axios.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(4255, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52364d52019bf0e4099ff71ee497497772e710a535653", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4309, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMoviesMVC.ModelsDTO.Movie.MovieMainDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
