#pragma checksum "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d416ff91fc7f1e759daeed62a7bc5798deb8fdf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d416ff91fc7f1e759daeed62a7bc5798deb8fdf", @"/Views/Recette/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5425f42997736aa433d17d6122635e5f6bab4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recette_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recette>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recette", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SupprimerRecette", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(189, 525, true);
            WriteLiteral(@"</h2>
        </div>
        <div class=""row RecetteLine"">
            <div class=""CorpsRecette"">
                <div class=""col-lg-12"">
                    <div>
                        <h3 class=""Recette"">Informations :</h3>
                    </div>
                    <div class=""col-lg-8"">
                        <div class=""row1"">
                            <div class=""col-lg-6"">
                                <div class=""row1"">
                                    <div class=""col-lg-12"">Catégorie :");
            EndContext();
            BeginContext(715, 13, false);
#line 21 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                 Write(r.NomCategory);

#line default
#line hidden
            EndContext();
            BeginContext(728, 183, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row1\">\r\n                                    <div class=\"col-lg-12\">Nombre de personne(s) : ");
            EndContext();
            BeginContext(912, 12, false);
#line 24 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                              Write(r.NbPersonne);

#line default
#line hidden
            EndContext();
            BeginContext(924, 182, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row1\">\r\n                                    <div class=\"col-lg-12\">Niveau de difficulté : ");
            EndContext();
            BeginContext(1107, 12, false);
#line 27 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                             Write(r.Difficulte);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 173, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row1\">\r\n                                    <div class=\"col-lg-12\">Ajoutée par : ");
            EndContext();
            BeginContext(1293, 16, false);
#line 30 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                    Write(r.NomUtilisateur);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 189, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"Titre\">\r\n");
            EndContext();
#line 35 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                     if (@ViewBag.Nom == "Admin")
                                    {

#line default
#line hidden
            BeginContext(1604, 151, true);
            WriteLiteral("                                        <div class=\"col-lg-6\">\r\n                                            <button class=\"TitreCentrer\" type=\"submit\">");
            EndContext();
            BeginContext(1755, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0eddb5f0b914cb89983e88c6a70471e", async() => {
                BeginContext(1818, 8, true);
                WriteLiteral("Modifier");
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
#line 38 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                                                                                   WriteLiteral(r.Id);

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
            BeginContext(1830, 210, true);
            WriteLiteral("</button>\r\n                                        </div>\r\n                                        <div class=\"col-lg-6\">\r\n                                            <button class=\"TitreCentrer\" type=\"submit\">");
            EndContext();
            BeginContext(2040, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4db5eccf7149599b05e035dddf5c3f", async() => {
                BeginContext(2119, 9, true);
                WriteLiteral("Supprimer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                                                                                                   WriteLiteral(r.Id);

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
            BeginContext(2132, 59, true);
            WriteLiteral("</button>\r\n                                        </div>\r\n");
            EndContext();
#line 43 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2230, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 44 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                     if (@ViewBag.nom == r.NomUtilisateur)
                                    {


#line default
#line hidden
            BeginContext(2347, 151, true);
            WriteLiteral("                                        <div class=\"col-lg-6\">\r\n                                            <button class=\"TitreCentrer\" type=\"submit\">");
            EndContext();
            BeginContext(2498, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbfcd3320bc14591a54128d250f43a09", async() => {
                BeginContext(2561, 8, true);
                WriteLiteral("Modifier");
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
#line 48 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                                                                                   WriteLiteral(r.Id);

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
            BeginContext(2573, 210, true);
            WriteLiteral("</button>\r\n                                        </div>\r\n                                        <div class=\"col-lg-6\">\r\n                                            <button class=\"TitreCentrer\" type=\"submit\">");
            EndContext();
            BeginContext(2783, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec7f3ca6fda4bd88b686210a115c446", async() => {
                BeginContext(2862, 9, true);
                WriteLiteral("Supprimer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                                                                                                                                   WriteLiteral(r.Id);

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
            BeginContext(2875, 59, true);
            WriteLiteral("</button>\r\n                                        </div>\r\n");
            EndContext();
#line 53 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2973, 268, true);
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 imagedroite"">
                        <div class=""imgFiche"">
                            ");
            EndContext();
            BeginContext(3241, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d297b9e6a9f448eaa2ab43480ba820b3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3251, "~/", 3251, 2, true);
#line 60 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
AddHtmlAttributeValue("", 3253, r.Images[0].Url, 3253, 16, false);

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
            BeginContext(3273, 418, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row RecetteLine"">
            <div class=""row1"">
                <div class=""col-lg-12"">
                    <div>
                        <h3 class=""Recette"">Ingrédients : </h3>
                    </div>
                    <div class=""row1"">
                        ");
            EndContext();
            BeginContext(3692, 12, false);
#line 73 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                   Write(r.Ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(3704, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(3796, 248, true);
            WriteLiteral("        <div class=\"row RecetteLine\">\r\n            <div class=\"row1\">\r\n                <div class=\"col-lg-12\">\r\n                    <div><h3 class=\"Recette\">Réalisation : </h3></div>\r\n                    <div class=\"row1\">\r\n                        ");
            EndContext();
            BeginContext(4045, 13, false);
#line 84 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
                   Write(r.Realisation);

#line default
#line hidden
            EndContext();
            BeginContext(4058, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 89 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Recette\Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(4155, 16, true);
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
