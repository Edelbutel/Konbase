#pragma checksum "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dweller\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7d7412d8147507ebe5c14f8f6b04cbf2039fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dweller_Add), @"mvc.1.0.view", @"/Views/Dweller/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dweller/Add.cshtml", typeof(AspNetCore.Views_Dweller_Add))]
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
#line 1 "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\_ViewImports.cshtml"
using KonBase;

#line default
#line hidden
#line 2 "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\_ViewImports.cshtml"
using KonBase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7d7412d8147507ebe5c14f8f6b04cbf2039fb3", @"/Views/Dweller/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4887f0e8c68bad4b956646c185182abde3d54fee", @"/Views/_ViewImports.cshtml")]
    public class Views_Dweller_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dweller\Add.cshtml"
  
    ViewData["Title"] = "Adicionar Morador";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("breadcrumb", async() => {
                BeginContext(76, 484, true);
                WriteLiteral(@"
    <h6 class=""h2 text-white d-inline-block mb-0"">Visão Geral</h6>
    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
            <li class=""breadcrumb-item""><a href=""#"">Moradores</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Adicionar</li>
        </ol>
    </nav>
");
                EndContext();
            }
            );
            BeginContext(563, 8882, true);
            WriteLiteral(@"    <div class=""col-md-12"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""card-wrapper"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""row align-items-center"">
                                <div class=""col-md-6 float-left"">
                                    <h3 class=""mb-0"">Perfil </h3>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""alert alert-default alert-dismissible fade show"" role=""alert"">
                                <span class=""alert-icon""><i class=""ni ni-send""></i></span>
                                <span class=""alert-text"">A <strong>SENHA</strong> do morador será enviada através do <strong>EMAIL</strong> cadastrado</span>
                            </div>
                            <h6 class=""heading-sm");
            WriteLiteral(@"all text-muted mb-4"">
                                INFORMAÇÃO DO MORADOR
                            </h6>
                            <div class=""pl-lg-4"">
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-first-name"">Nome</label>
                                            <input type=""text"" id=""input-first-name"" class=""form-control"" placeholder=""First name"" value=""Lucky"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-last-name"">Sobrenome</label>
                                            <input type=""text"" id=""input-last-name"" ");
            WriteLiteral(@"class=""form-control"" placeholder=""Last name"" value=""Jesse"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""exampleDatepicker"">Data Nascimento</label>
                                            <input class=""form-control calendario"" placeholder=""Selecione a Data"" type=""text"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-email"">CPF</label>
                                            <input type=""email"" id=""inpu");
            WriteLiteral(@"t-email"" class=""form-control"" placeholder=""jesse@example.com"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr class=""my-4"" />
                            <!-- Address -->
                            <h6 class=""heading-small text-muted mb-4"">
                                INFORMAÇÕES DE CONTATO
                            </h6>
                            <div class=""pl-lg-4"">
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-address"">Address</label>
                                            <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
 ");
            WriteLiteral(@"                                       </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-city"">City</label>
                                            <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">Country</label>
                                            <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""Unit");
            WriteLiteral(@"ed States"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">Postal code</label>
                                            <input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr class=""my-4"" />
                            <!-- Description -->
                            <h6 class=""heading-small text-muted mb-4"">
                                INFORMAÇÕES DE ENDEREÇO
                            </h6>
                            <div class=""pl-lg-4"">
                                <div class=""row"">
    ");
            WriteLiteral(@"                                <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">CEP</label>
                                            <input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-city"">Cidade</label>
                                            <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                   ");
            WriteLiteral(@"     <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">Bairro</label>
                                            <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-address"">Rua</label>
                                            <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                        </div>
                                    </div>
                            ");
            WriteLiteral(@"    </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-address"">Complemento</label>
                                            <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                        </div>
                                    </div>
                                    <div class=""card-body"">
                                        ");
            EndContext();
            BeginContext(9445, 643, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b09ec87dad5493bb56779d2dc744a3f", async() => {
                BeginContext(9451, 146, true);
                WriteLiteral("\r\n                                            <select class=\"form-control\" data-toggle=\"select\">\r\n                                                ");
                EndContext();
                BeginContext(9597, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a52929b30ecb4cc4be2c77756e8cd063", async() => {
                    BeginContext(9605, 6, true);
                    WriteLiteral("Alerts");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9620, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(9670, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5522739c10f04cfca3fe74653dd35e51", async() => {
                    BeginContext(9678, 6, true);
                    WriteLiteral("Badges");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9693, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(9743, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46e51ae937f54f269c0d880ac1fc9225", async() => {
                    BeginContext(9751, 7, true);
                    WriteLiteral("Buttons");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9767, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(9817, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb2954c57ca84c6a9a3a867f6625e506", async() => {
                    BeginContext(9825, 5, true);
                    WriteLiteral("Cards");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9839, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(9889, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ce5a15d1764e10bcfe0f4c3ca070be", async() => {
                    BeginContext(9897, 5, true);
                    WriteLiteral("Forms");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9911, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(9961, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4405b8489734741a21b9ec49b2e7e46", async() => {
                    BeginContext(9969, 6, true);
                    WriteLiteral("Modals");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9984, 97, true);
                WriteLiteral("\r\n                                            </select>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10088, 1603, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card"">
                    <div class=""card-wrapper"">
                        <div class=""card-header"">
                            <h3 class=""mb-0"">Foto</h3>
                        </div>
                        <div class=""card-body"">
                            <div class=""dropzone dropzone-single mb-3"" data-toggle=""dropzone"" data-dropzone-url=""http://"">
                                <div class=""fallback"">
                                    <div class=""custom-file"">
                                        <input type=""file"" class=""custom-file-input"" id=""projectCoverUploads"">
                                        <label class=""custom-file-label"" for=""projectCoverUploads"">Escolha o Arquivo</label>
         ");
            WriteLiteral(@"                           </div>
                                </div>
                                <div class=""dz-preview dz-preview-single"">
                                    <div class=""dz-preview-cover"">
                                        <img class=""dz-preview-img"" src=""..."" alt=""..."" data-dz-thumbnail>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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