#pragma checksum "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d37a69173f1e0b77ecd77084ce1c021e78e9329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Index), @"mvc.1.0.view", @"/Views/Ingredients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredients/Index.cshtml", typeof(AspNetCore.Views_Ingredients_Index))]
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
#line 2 "/Users/Guest/Desktop/Recipes/Views/_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d37a69173f1e0b77ecd77084ce1c021e78e9329", @"/Views/Ingredients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 78, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Ingredients</h1>\n    <ul>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
       if (@Model.Count == 0)
      {

#line default
#line hidden
            BeginContext(116, 53, true);
            WriteLiteral("        <h2>Currently there are no ingredients.</h2>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
      }

#line default
#line hidden
            BeginContext(177, 6, true);
            WriteLiteral("      ");
            EndContext();
#line 8 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
       foreach (Ingredient ingredient in Model)
      {

#line default
#line hidden
            BeginContext(233, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 247, "\"", 280, 2);
            WriteAttributeValue("", 254, "ingredients/", 254, 12, true);
#line 10 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
WriteAttributeValue("", 266, ingredient.id, 266, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(281, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(283, 15, false);
#line 10 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
                                            Write(ingredient.name);

#line default
#line hidden
            EndContext();
            BeginContext(298, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Index.cshtml"
      }

#line default
#line hidden
            BeginContext(316, 70, true);
            WriteLiteral("    </ul>\n    <a href=\"ingredients/new\">Add an ingredient!</a>\n</div>\n");
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
