#pragma checksum "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752bea87e831b77c5441a917123cbca01a703719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recette_Detail), @"mvc.1.0.view", @"/Views/Recette/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recette/Detail.cshtml", typeof(AspNetCore.Views_Recette_Detail))]
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
#line 1 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\_ViewImports.cshtml"
using FicheRecette;

#line default
#line hidden
#line 2 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\_ViewImports.cshtml"
using FicheRecette.Models;

#line default
#line hidden
#line 1 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
using FicheRecette.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752bea87e831b77c5441a917123cbca01a703719", @"/Views/Recette/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5425f42997736aa433d17d6122635e5f6bab4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recette_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recette>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 37, true);
            WriteLiteral("\r\n\r\n<div class=\"Container Recette\">\r\n");
            EndContext();
#line 6 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
     foreach (Recette r in Model)
    {

#line default
#line hidden
            BeginContext(131, 45, true);
            WriteLiteral("        <div class=\"Titre\">\r\n            <h2>");
            EndContext();
            BeginContext(177, 12, false);
#line 9 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
           Write(r.NomRecette);

#line default
#line hidden
            EndContext();
            BeginContext(189, 416, true);
            WriteLiteral(@"</h2>
        </div>
        <div class=""row RecetteLine"">
            <div class=""CorpsRecette"">
                <div class=""col-lg-12"">
                    <div class=""TitreBlanc"">
                        <h3>Informations :</h3>
                    </div>
                    <div class=""col-lg-8"">
                        <div class=""row1"">
                            <div class=""col-lg-12"">Catégorie :");
            EndContext();
            BeginContext(606, 12, false);
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                         Write(r.IdCategory);

#line default
#line hidden
            EndContext();
            BeginContext(618, 159, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row1\">\r\n                            <div class=\"col-lg-12\">Nombre de personne(s) : ");
            EndContext();
            BeginContext(778, 12, false);
#line 22 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                      Write(r.NbPersonne);

#line default
#line hidden
            EndContext();
            BeginContext(790, 158, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row1\">\r\n                            <div class=\"col-lg-12\">Niveau de difficulté : ");
            EndContext();
            BeginContext(949, 12, false);
#line 25 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                     Write(r.Difficulte);

#line default
#line hidden
            EndContext();
            BeginContext(961, 149, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row1\">\r\n                            <div class=\"col-lg-12\">Ajoutée par : ");
            EndContext();
            BeginContext(1111, 16, false);
#line 28 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                            Write(r.NomUtilisateur);

#line default
#line hidden
            EndContext();
            BeginContext(1127, 200, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-4 imagedroite\">\r\n                        <div class=\"imgFiche\">\r\n                            ");
            EndContext();
            BeginContext(1327, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75e6d3b171684445aa10b67738337bf1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1337, "~/", 1337, 2, true);
#line 33 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
AddHtmlAttributeValue("", 1339, r.Images[0].Url, 1339, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1359, 357, true);
            WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class=""row RecetteLine"">
            <div class=""row1"">
                <div class=""col-lg-12"">
                    <div class=""TitreBlanc"">
                        <h3>Ingrédients : </h3>
                    </div>");
            EndContext();
            BeginContext(1717, 12, false);
#line 45 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                     Write(r.Ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1793, 185, true);
            WriteLiteral("        <div class=\"row RecetteLine\">\r\n            <div class=\"row1\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"TitreBlanc\"><h3>Réalisation : </h3></div>");
            EndContext();
            BeginContext(1979, 13, false);
#line 53 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                    Write(r.Realisation);

#line default
#line hidden
            EndContext();
            BeginContext(1992, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 57 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(2061, 16, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Recette>> Html { get; private set; }
    }
}
#pragma warning restore 1591
