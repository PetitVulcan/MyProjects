#pragma checksum "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db13c912b3626a8ad8c81e520f785693a574b71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilisateur_Connection), @"mvc.1.0.view", @"/Views/Utilisateur/Connection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilisateur/Connection.cshtml", typeof(AspNetCore.Views_Utilisateur_Connection))]
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
#line 1 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
using FicheRecette.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db13c912b3626a8ad8c81e520f785693a574b71c", @"/Views/Utilisateur/Connection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5425f42997736aa433d17d6122635e5f6bab4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilisateur_Connection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Utilisateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AjouterUtilisateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConnectionMdp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 50, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n");
            EndContext();
#line 5 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
         if ((ViewBag.errors != null))
        {
            if ((ViewBag.errors as List<string>).Count > 0)
            {

#line default
#line hidden
            BeginContext(206, 99, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-12 alert alert-danger\">\r\n");
            EndContext();
#line 11 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
                         foreach (string e in (ViewBag.errors as List<string>))
                        {

#line default
#line hidden
            BeginContext(413, 140, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-lg-12\">\r\n                                    ");
            EndContext();
            BeginContext(554, 1, false);
#line 15 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
                               Write(e);

#line default
#line hidden
            EndContext();
            BeginContext(555, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 18 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
                        }

#line default
#line hidden
            BeginContext(660, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(738, 210, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"Inscription\">\r\n            <div class=\"row\">\r\n                <h2 class=\"col-lg-12\">S\'inscrire</h2>\r\n            </div>\r\n\r\n");
            EndContext();
#line 32 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
             if (ViewBag.Inscription != null)
            {
                if (ViewBag.Inscription)
                {

#line default
#line hidden
            BeginContext(1071, 136, true);
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-lg-12 alert alert-success\">\r\n                            ");
            EndContext();
            BeginContext(1208, 15, false);
#line 38 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
                       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 41 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1319, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1339, 2221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff32d90cc2140b2a0deab8c96bb0339", async() => {
                BeginContext(1420, 169, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-12\">\r\n                                <input type=\"text\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1589, "\"", 1607, 1);
#line 46 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
WriteAttributeValue("", 1597, Model.Nom, 1597, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1608, 275, true);
                WriteLiteral(@" name=""nom"" placeholder=""Votre Nom"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <input type=""text"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1883, "\"", 1904, 1);
#line 51 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
WriteAttributeValue("", 1891, Model.Prenom, 1891, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1905, 281, true);
                WriteLiteral(@" name=""prenom"" placeholder=""Votre Prénom"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <input type=""text"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2186, "\"", 2215, 1);
#line 56 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
WriteAttributeValue("", 2194, Model.NomUtilisateur, 2194, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2216, 300, true);
                WriteLiteral(@" name=""NomUtilisateur"" placeholder=""Votre nom d'utilisateur"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <input type=""text"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2516, "\"", 2536, 1);
#line 61 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
WriteAttributeValue("", 2524, Model.EMail, 2524, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2537, 285, true);
                WriteLiteral(@" name=""email"" placeholder=""Votre Email"" />
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <input type=""password"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2822, "\"", 2840, 1);
#line 67 "C:\Users\diper\source\repos\PetitVulcan\MyProjects\FicheRecetteASP_NET_Core_MCV\FicheRecette\Views\Utilisateur\Connection.cshtml"
WriteAttributeValue("", 2830, Model.Mdp, 2830, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2841, 712, true);
                WriteLiteral(@" name=""Mdp"" placeholder=""Votre mot de passe"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <input type=""password"" class=""form-control"" name=""cMdp"" placeholder=""Confirmer votre mot de passe"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <button class=""form-control btn btn-default"" type=""submit"">S'inscrire</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3560, 207, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"Login\">\r\n            <div class=\"row\">\r\n                <h2 class=\"col-lg-12\">Se connecter</h2>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(3767, 831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47656644ed3e47d59f22a1d17ba65811", async() => {
                BeginContext(3829, 762, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <input type=""text"" class=""form-control"" name=""nomUtilisateur"" placeholder=""Votre nom d'utilisateur"" />
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-lg-12"">
                        <input type=""password"" class=""form-control"" name=""mdp"" placeholder=""Votre mot de passe"" />
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""form-control btn btn-default"" type=""submit"">Se connecter</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4598, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
