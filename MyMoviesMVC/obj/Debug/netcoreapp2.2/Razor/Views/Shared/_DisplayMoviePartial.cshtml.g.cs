#pragma checksum "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c315707f5fbeb66b7355062b543f8e1eef601d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayMoviePartial), @"mvc.1.0.view", @"/Views/Shared/_DisplayMoviePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DisplayMoviePartial.cshtml", typeof(AspNetCore.Views_Shared__DisplayMoviePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c315707f5fbeb66b7355062b543f8e1eef601d", @"/Views/Shared/_DisplayMoviePartial.cshtml")]
    public class Views_Shared__DisplayMoviePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMoviesMVC.ModelsDTO.UserMovies.UserMovieDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("movie-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 125, true);
            WriteLiteral("\r\n    <div class=\"movie-span\">\r\n        <div class=\"movie-card\">\r\n            <div class=\"movie-image\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 233, "\"", 271, 2);
            WriteAttributeValue("", 239, "data:image/*;base64,", 239, 20, true);
#line 7 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml"
WriteAttributeValue("", 259, Model.Cover, 259, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 272, "\"", 290, 1);
#line 7 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml"
WriteAttributeValue("", 278, Model.Title, 278, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(291, 120, true);
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"overlay\">\r\n                <div class=\"text\">\r\n                    <h2>");
            EndContext();
            BeginContext(412, 11, false);
#line 11 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(423, 56, true);
            WriteLiteral("</h2>\r\n                    <p class=\"movie-description\">");
            EndContext();
            BeginContext(480, 17, false);
#line 12 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml"
                                            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(497, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(523, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c315707f5fbeb66b7355062b543f8e1eef601d5830", async() => {
                BeginContext(614, 8, true);
                WriteLiteral("See more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\User\Desktop\Marko\Code Academy\MyMoviesMVCgit\MyMoviesMVC\MyMoviesMVC\Views\Shared\_DisplayMoviePartial.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(626, 72, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMoviesMVC.ModelsDTO.UserMovies.UserMovieDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
