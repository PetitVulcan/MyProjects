#pragma checksum "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5accb7e6a5ee2e59994f0c4e348661093753b040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilisateur_ListeUtilisateur), @"mvc.1.0.view", @"/Views/Utilisateur/ListeUtilisateur.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilisateur/ListeUtilisateur.cshtml", typeof(AspNetCore.Views_Utilisateur_ListeUtilisateur))]
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
#line 1 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
using FicheRecette.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5accb7e6a5ee2e59994f0c4e348661093753b040", @"/Views/Utilisateur/ListeUtilisateur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5425f42997736aa433d17d6122635e5f6bab4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilisateur_ListeUtilisateur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Utilisateur>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SupprimerUtilsateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Utilisateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AjouterUtilisateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 163, true);
            WriteLiteral("\r\n<div class=\"Container Recette\">\r\n    <div class=\"Titre\">\r\n        <h2>Liste des Utilisateurs</h2>\r\n    </div>\r\n    <div class=\"row RecetteLine\">\r\n        <div>\r\n");
            EndContext();
#line 10 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
            BeginContext(269, 86, true);
            WriteLiteral("                <div>\r\n                    Aucun Utilisateur\r\n                </div>\r\n");
            EndContext();
#line 15 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
            }

#line default
#line hidden
            BeginContext(370, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 16 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
             foreach (Utilisateur u in Model)
            {

#line default
#line hidden
            BeginContext(432, 63, true);
            WriteLiteral("                <div>\r\n                    Nom d\'utilisateur : ");
            EndContext();
            BeginContext(496, 16, false);
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
                                   Write(u.NomUtilisateur);

#line default
#line hidden
            EndContext();
            BeginContext(512, 20, true);
            WriteLiteral("  - Adresse email : ");
            EndContext();
            BeginContext(533, 7, false);
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
                                                                        Write(u.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(540, 36, true);
            WriteLiteral(" - Nombre de recettes(s) crée(s) :  ");
            EndContext();
            BeginContext(577, 15, false);
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
                                                                                                                    Write(u.NbRecettecree);

#line default
#line hidden
            EndContext();
            BeginContext(592, 20, true);
            WriteLiteral(" - Administrateur : ");
            EndContext();
            BeginContext(613, 7, false);
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
                                                                                                                                                        Write(u.Admin);

#line default
#line hidden
            EndContext();
            BeginContext(620, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(623, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f95613b725a4498bc9ecfc790341de8", async() => {
                BeginContext(709, 9, true);
                WriteLiteral("Supprimer");
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
#line 19 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
                                                                                                                                                                                                                                           WriteLiteral(u.Id);

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
            BeginContext(722, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\ListeUtilisateur.cshtml"
            }

#line default
#line hidden
            BeginContext(763, 133, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"Titre\"><h2>Ajouter un Utilisateur</h2></div>\r\n    <div class=\"row RecetteLine\">\r\n        ");
            EndContext();
            BeginContext(896, 1123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6831f8ec3a784a51a633724a2b116068", async() => {
                BeginContext(977, 774, true);
                WriteLiteral(@"
            <div>
                <label>Nom : </label>
                <input type=""text"" name=""Nom"" />
                <label>Prénom : </label>
                <input type=""text"" name=""Prenom"" />
                <label>Nom d'Utilisateur : </label>
                <input type=""text"" name=""NomUtilisateur"" />
                <label>email : </label>
                <input type=""text"" name=""Email"" />
                <label>Mot de Passe : </label>
                <input type=""password"" name=""Mdp"" />
                <label>Confirmer le mot de passe : </label>
                <input type=""password"" name=""cMdp"" />
                <label>Administrateur : </label>
                <select type=""text"" name=""Admin"" size=""1"" value=""Admin"">
                    ");
                EndContext();
                BeginContext(1751, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5630cd2dbac4772aee2339c8f828f87", async() => {
                    BeginContext(1772, 3, true);
                    WriteLiteral("Oui");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1784, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1806, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a789f1d4f956449384899afdb71a400e", async() => {
                    BeginContext(1828, 3, true);
                    WriteLiteral("Non");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1840, 172, true);
                WriteLiteral("                    \r\n                </select>\r\n            </div>\r\n            <div>\r\n                <button type=\"submit\">Ajouter</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2019, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Utilisateur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
