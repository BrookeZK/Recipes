#pragma checksum "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99da13a454def2761ea8f737bd526b014860dc2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99da13a454def2761ea8f737bd526b014860dc2", @"/Views/Recipes/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 54, true);
            WriteLiteral("\n<div class=\"text-center\">\n\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(78, 10, false);
#line 5 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                     Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(88, 39, true);
            WriteLiteral("</h1>\n    <h2>Category:</h2>\n\n    <ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
       foreach(Category category in @Model.ShowCategories())
      {

#line default
#line hidden
            BeginContext(196, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 210, "\'", 241, 2);
            WriteAttributeValue("", 217, "/categories/", 217, 12, true);
#line 11 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
WriteAttributeValue("", 229, category.id, 229, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(244, 13, false);
#line 11 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                                          Write(category.name);

#line default
#line hidden
            EndContext();
            BeginContext(257, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
      }

#line default
#line hidden
            BeginContext(275, 15, true);
            WriteLiteral("    </ul>\n\n    ");
            EndContext();
            BeginContext(290, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc25557", async() => {
                BeginContext(343, 159, true);
                WriteLiteral("\n      <button type=\"submit\" class=\"btn btn-dark\">ADD this Recipe to a category:</button>\n      <select id=\'categoryId\' name=\'categoryId\' type=\'text\'>\n        ");
                EndContext();
                BeginContext(502, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc26103", async() => {
                    BeginContext(520, 4, true);
                    WriteLiteral("None");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("0", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(533, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 19 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
         foreach (var category in @Category.GetAll())
        {

#line default
#line hidden
                BeginContext(598, 10, true);
                WriteLiteral("          ");
                EndContext();
                BeginContext(608, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc28128", async() => {
                    BeginContext(638, 13, false);
#line 21 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                                  Write(category.name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
             WriteLiteral(category.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(660, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 22 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
        }

#line default
#line hidden
                BeginContext(671, 28, true);
                WriteLiteral("      </select><br><br>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 304, "/recipes/", 304, 9, true);
#line 15 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
AddHtmlAttributeValue("", 313, Model.id, 313, 9, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 322, "/add", 322, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(706, 6, true);
            WriteLiteral("\n\n    ");
            EndContext();
            BeginContext(712, 438, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc212069", async() => {
                BeginContext(777, 164, true);
                WriteLiteral("\n      <button type=\"submit\" class=\"btn btn-dark\">REMOVE this Recipe from a category:</button>\n      <select id=\'categoryId\' name=\'categoryId\' type=\'text\'>\n        ");
                EndContext();
                BeginContext(941, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc212621", async() => {
                    BeginContext(959, 4, true);
                    WriteLiteral("None");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("0", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(972, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 30 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
         foreach (var category in @Model.ShowCategories())
        {

#line default
#line hidden
                BeginContext(1042, 10, true);
                WriteLiteral("          ");
                EndContext();
                BeginContext(1052, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc214654", async() => {
                    BeginContext(1082, 13, false);
#line 32 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
                                  Write(category.name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
             WriteLiteral(category.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1104, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 33 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
        }

#line default
#line hidden
                BeginContext(1115, 28, true);
                WriteLiteral("      </select><br><br>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 726, "/recipes/", 726, 9, true);
#line 26 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
AddHtmlAttributeValue("", 735, Model.id, 735, 9, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 744, "/delete-category", 744, 16, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1150, 37, true);
            WriteLiteral("\n\n    <h2>Instructions:</h2>\n    <h3>");
            EndContext();
            BeginContext(1188, 18, false);
#line 38 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
   Write(Model.instructions);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 112, true);
            WriteLiteral("</h3>\n\n    <a class=\"btn btn-dark\" href=\"/recipes/new\">Add a new recipe!</a><br><br>\n    <a class=\"btn btn-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1339, 2);
#line 41 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
WriteAttributeValue("", 1325, Model.id, 1325, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1334, "/edit", 1334, 5, true);
            EndWriteAttribute();
            BeginContext(1340, 29, true);
            WriteLiteral(">Edit recipe</a><br><br>\n    ");
            EndContext();
            BeginContext(1369, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d99da13a454def2761ea8f737bd526b014860dc219513", async() => {
                BeginContext(1425, 82, true);
                WriteLiteral("\n      <button type=\"submit\" class=\"btn btn-dark\">Delete this recipe</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1383, "/recipes/", 1383, 9, true);
#line 42 "/Users/Guest/Desktop/Recipes/Views/Recipes/Show.cshtml"
AddHtmlAttributeValue("", 1392, Model.id, 1392, 9, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1401, "/delete", 1401, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1514, 8, true);
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
