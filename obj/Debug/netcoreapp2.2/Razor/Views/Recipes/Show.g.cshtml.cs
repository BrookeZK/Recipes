#pragma checksum "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f790ca00631db58f5c7bbd16bb05e20633c5020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Show), @"mvc.1.0.view", @"/Views/Recipes/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Show.cshtml", typeof(AspNetCore.Views_Recipes_Show))]
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
#line 1 "/Users/Guest/Desktop/Recipes/Views/_ViewImports.cshtml"
using Recipes;

#line default
#line hidden
#line 1 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
using Recipes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f790ca00631db58f5c7bbd16bb05e20633c5020", @"/Views/Recipes/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(23, 53, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(77, 10, false);
#line 4 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                     Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(87, 38, true);
            WriteLiteral("</h1>\n    <h2>Category:</h2>\n    <ul>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
       foreach(Category category in @Model.ShowCategories())
      {

#line default
#line hidden
            BeginContext(194, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 208, "\'", 239, 2);
            WriteAttributeValue("", 215, "/categories/", 215, 12, true);
#line 9 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
WriteAttributeValue("", 227, category.id, 227, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(240, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(242, 13, false);
#line 9 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                                          Write(category.name);

#line default
#line hidden
            EndContext();
            BeginContext(255, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
      }

#line default
#line hidden
            BeginContext(273, 45, true);
            WriteLiteral("    </ul>\n    <h2>Instructions:</h2>\n    <h3>");
            EndContext();
            BeginContext(319, 18, false);
#line 13 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
   Write(Model.instructions);

#line default
#line hidden
            EndContext();
            BeginContext(337, 112, true);
            WriteLiteral("</h3>\n\n    <a class=\"btn btn-dark\" href=\"/recipes/new\">Add a new recipe!</a><br><br>\n    <a class=\"btn btn-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 449, "\"", 470, 2);
#line 16 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
WriteAttributeValue("", 456, Model.id, 456, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 465, "/edit", 465, 5, true);
            EndWriteAttribute();
            BeginContext(471, 29, true);
            WriteLiteral(">Edit recipe</a><br><br>\n    ");
            EndContext();
            BeginContext(500, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f790ca00631db58f5c7bbd16bb05e20633c50206018", async() => {
                BeginContext(556, 82, true);
                WriteLiteral("\n      <button type=\"submit\" class=\"btn btn-dark\">Delete this recipe</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 514, "/recipes/", 514, 9, true);
#line 17 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
AddHtmlAttributeValue("", 523, Model.id, 523, 9, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 532, "/delete", 532, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(645, 8, true);
            WriteLiteral("\n</div>\n");
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
