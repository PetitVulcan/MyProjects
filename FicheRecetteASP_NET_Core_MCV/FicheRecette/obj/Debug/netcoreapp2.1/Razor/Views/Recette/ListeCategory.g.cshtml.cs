#pragma checksum "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf07fc4de91447f9061b2288307e24ec93a8a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recette_ListeCategory), @"mvc.1.0.view", @"/Views/Recette/ListeCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recette/ListeCategory.cshtml", typeof(AspNetCore.Views_Recette_ListeCategory))]
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
#line 1 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\_ViewImports.cshtml"
using FicheRecette;

#line default
#line hidden
#line 2 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\_ViewImports.cshtml"
using FicheRecette.Models;

#line default
#line hidden
#line 1 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
using FicheRecette.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf07fc4de91447f9061b2288307e24ec93a8a00", @"/Views/Recette/ListeCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5425f42997736aa433d17d6122635e5f6bab4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recette_ListeCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recette", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "recette", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 129, true);
            WriteLiteral("\r\n<div class=\"Container Recette\">\r\n\r\n    <div class=\"Titre\"> <h2>Liste des Catégories</h2></div>\r\n\r\n    <div class=\"col-lg-12\">\r\n");
            EndContext();
#line 9 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
         if ((ViewBag.errors != null))
        {
            if ((ViewBag.errors as List<string>).Count > 0)
            {

#line default
#line hidden
            BeginContext(308, 154, true);
            WriteLiteral("                <div class=\"row RecetteLine\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-12 alert alert-danger\">\r\n");
            EndContext();
#line 16 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                             foreach (string e in (ViewBag.errors as List<string>))
                            {

#line default
#line hidden
            BeginContext(578, 152, true);
            WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12\">\r\n                                        ");
            EndContext();
            BeginContext(731, 1, false);
#line 20 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                                   Write(e);

#line default
#line hidden
            EndContext();
            BeginContext(732, 86, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 23 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(849, 84, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 27 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(959, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
         if (ViewBag.Categories != null)
        {
            if (ViewBag.Categories)
            {

#line default
#line hidden
            BeginContext(1066, 183, true);
            WriteLiteral("                <div class=\"row RecetteLine\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-12 alert alert-success\">\r\n                            ");
            EndContext();
            BeginContext(1250, 15, false);
#line 37 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 41 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1377, 47, true);
            WriteLiteral("    </div>\r\n    <div class=\"row RecetteLine\">\r\n");
            EndContext();
#line 45 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
            BeginContext(1467, 73, true);
            WriteLiteral("            <div>\r\n                Aucune Catégorie\r\n            </div>\r\n");
            EndContext();
#line 50 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
        }

#line default
#line hidden
            BeginContext(1551, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 51 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
         foreach (Category c in Model)
        {
            

#line default
#line hidden
#line 53 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
             if (ViewBag.Nom == "Admin")
            {

#line default
#line hidden
            BeginContext(1659, 65, true);
            WriteLiteral("                <div>\r\n                    Nom de la catégorie : ");
            EndContext();
            BeginContext(1725, 7, false);
#line 56 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                                     Write(c.Titre);

#line default
#line hidden
            EndContext();
            BeginContext(1732, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1735, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a95ed735ac2414a9dcf683dfe1c6527", async() => {
                BeginContext(1812, 12, true);
                WriteLiteral(" - Supprimer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                                                                                                               WriteLiteral(c.Id);

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
            BeginContext(1828, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 58 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1902, 65, true);
            WriteLiteral("                <div>\r\n                    Nom de la catégorie : ");
            EndContext();
            BeginContext(1968, 7, false);
#line 62 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
                                     Write(c.Titre);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 64 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
            }

#line default
#line hidden
#line 64 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
             

        }

#line default
#line hidden
            BeginContext(2029, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 69 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
     if (ViewBag.Nom == "Admin")
    {

#line default
#line hidden
            BeginContext(2084, 73, true);
            WriteLiteral("        <div class=\"Titre\"><h2>Ajouter une Catégorie</h2></div>\r\n        ");
            EndContext();
            BeginContext(2157, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f0d199e81a4cbb80f6d853d9f34a1b", async() => {
                BeginContext(2232, 304, true);
                WriteLiteral(@"
            <div class=""row RecetteLine"">
                <label>Nom de la Catégorie : </label>
                <div class=""row1"">
                    <input type=""text"" name=""Titre"" />
                    <button type=""submit"">Ajouter</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2543, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Users\Formation\Source\Repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\ListeCategory.cshtml"
    }

#line default
#line hidden
            BeginContext(2552, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
