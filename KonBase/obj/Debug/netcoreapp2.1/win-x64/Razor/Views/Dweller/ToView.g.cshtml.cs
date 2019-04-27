#pragma checksum "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dweller\ToView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ddf9c7440667c44ca9c15dd76904d5ad6a77e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dweller_ToView), @"mvc.1.0.view", @"/Views/Dweller/ToView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dweller/ToView.cshtml", typeof(AspNetCore.Views_Dweller_ToView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ddf9c7440667c44ca9c15dd76904d5ad6a77e7", @"/Views/Dweller/ToView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4887f0e8c68bad4b956646c185182abde3d54fee", @"/Views/_ViewImports.cshtml")]
    public class Views_Dweller_ToView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dweller\ToView.cshtml"
  
    ViewData["Title"] = "Visualizar Morador";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("breadcrumb", async() => {
                BeginContext(77, 485, true);
                WriteLiteral(@"
    <h6 class=""h2 text-white d-inline-block mb-0"">Visão Geral</h6>
    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
            <li class=""breadcrumb-item""><a href=""#"">Moradores</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Visualizar</li>
        </ol>
    </nav>
");
                EndContext();
            }
            );
            BeginContext(565, 10115, true);
            WriteLiteral(@"    <div class=""col-md-12 row"">
        <div class=""col-lg-8"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card bg-gradient-info border-0"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Pago</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">R$ 350,897</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-dark rounded-circle shadow"">
                                        <i class=""ni ni-fat-add""></i>
                                    </div>
                                </div>
                            </div>
             ");
            WriteLiteral(@"               <p class=""mt-3 mb-0 text-sm"">
                                <span class=""text-white mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                                <span class=""text-nowrap text-light"">Desde o último mês</span>
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""card bg-gradient-danger border-0"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Em Atraso</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">R$ 0,00</span>
                                </div>
                                <div class=""col-auto"">
                                    <div cl");
            WriteLiteral(@"ass=""icon icon-shape bg-white text-dark rounded-circle shadow"">
                                        <i class=""ni ni-fat-delete""></i>
                                    </div>
                                </div>
                            </div>
                            <p class=""mt-3 mb-0 text-sm"">
                                <span class=""text-white mr-2""><i class=""fa fa-arrow-up""></i> 78.48%</span>
                                <span class=""text-nowrap text-light"">Desde o último mês</span>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h3 class=""mb-0"">Perfil </h3>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
  ");
            WriteLiteral(@"                  <h6 class=""heading-small text-muted mb-4"">
                        INFORMAÇÃO DO MORADOR
                    </h6>
                    <div class=""pl-lg-4"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-username"">Usuário</label>
                                    <input type=""text"" id=""input-username"" class=""form-control"" placeholder=""Username"" value=""lucky.jesse"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-email"">Email address</label>
                                    <input type=""email"" id=""input-email"" class=""form-control"" placeholder=""jesse@example.com"">
                  ");
            WriteLiteral(@"              </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-first-name"">First name</label>
                                    <input type=""text"" id=""input-first-name"" class=""form-control"" placeholder=""First name"" value=""Lucky"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-last-name"">Last name</label>
                                    <input type=""text"" id=""input-last-name"" class=""form-control"" placeholder=""Last name"" value=""Jesse"">
                                </div>
                            </div>
                   ");
            WriteLiteral(@"     </div>
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
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                   ");
            WriteLiteral(@"                 <label class=""form-control-label"" for=""input-city"">City</label>
                                    <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">Country</label>
                                    <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">Postal code</label>
                                    <input type=""number"" id=""input-postal-code"" c");
            WriteLiteral(@"lass=""form-control"" placeholder=""Postal code"">
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
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">CEP</label>
                                    <input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
   ");
            WriteLiteral(@"                                 <label class=""form-control-label"" for=""input-city"">Cidade</label>
                                    <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">Bairro</label>
                                    <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-address"">Rua</labe");
            WriteLiteral(@"l>
                                    <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                </div>
                            </div>
                        </div>
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
            BeginContext(10680, 571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a25459066447d5804aea7961557cc7", async() => {
                BeginContext(10686, 130, true);
                WriteLiteral("\r\n                                    <select class=\"form-control\" data-toggle=\"select\">\r\n                                        ");
                EndContext();
                BeginContext(10816, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faff8995a08d417481ba1c5315736876", async() => {
                    BeginContext(10824, 6, true);
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
                BeginContext(10839, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(10881, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "371dc83ab5a74354bca2af89d27620c5", async() => {
                    BeginContext(10889, 6, true);
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
                BeginContext(10904, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(10946, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8479c293493c41e5ac4b716dd524c58d", async() => {
                    BeginContext(10954, 7, true);
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
                BeginContext(10970, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(11012, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa038545ab6d421d8c2ef4e1440f3b9a", async() => {
                    BeginContext(11020, 5, true);
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
                BeginContext(11034, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(11076, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921c54e2841f4b5781032667d44aae2c", async() => {
                    BeginContext(11084, 5, true);
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
                BeginContext(11098, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(11140, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7ae49ceae54ab0a1bd7e4f5a884723", async() => {
                    BeginContext(11148, 6, true);
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
                BeginContext(11163, 81, true);
                WriteLiteral("\r\n                                    </select>\r\n                                ");
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
            BeginContext(11251, 6149, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""card"">
                <div class=""card-header bg-transparent"">
                    <h3 class=""mb-0"">Timeline</h3>
                </div>
                <div class=""card-body"">
                    <div class=""timeline timeline-one-side"" data-timeline-content=""axis"" data-timeline-axis-style=""dashed"">
                        <div class=""timeline-block"">
                            <span class=""timeline-step badge-success"">
                                <i class=""ni ni-bell-55""></i>
                            </span>
                            <div class=""timeline-content"">
                                <small class=""text-muted font-weight-bold"">10:30 AM</small>
                                <h5 class="" mt-3 mb-0"">New message</h5>
                                <p class="" text-sm");
            WriteLiteral(@" mt-1 mb-0"">Nullam id dolor id nibh ultricies vehicula ut id elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                <div class=""mt-3"">
                                    <span class=""badge badge-pill badge-success"">design</span>
                                    <span class=""badge badge-pill badge-success"">system</span>
                                    <span class=""badge badge-pill badge-success"">creative</span>
                                </div>
                            </div>
                        </div>
                        <div class=""timeline-block"">
                            <span class=""timeline-step badge-danger"">
                                <i class=""ni ni-html5""></i>
                            </span>
                            <div class=""timeline-content"">
                                <small class=""text-muted font-weight-bold"">10:30 AM</small>
                                <h5 clas");
            WriteLiteral(@"s="" mt-3 mb-0"">Product issue</h5>
                                <p class="" text-sm mt-1 mb-0"">Nullam id dolor id nibh ultricies vehicula ut id elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                <div class=""mt-3"">
                                    <span class=""badge badge-pill badge-danger"">design</span>
                                    <span class=""badge badge-pill badge-danger"">system</span>
                                    <span class=""badge badge-pill badge-danger"">creative</span>
                                </div>
                            </div>
                        </div>
                        <div class=""timeline-block"">
                            <span class=""timeline-step badge-info"">
                                <i class=""ni ni-like-2""></i>
                            </span>
                            <div class=""timeline-content"">
                                <small class=""text-m");
            WriteLiteral(@"uted font-weight-bold"">10:30 AM</small>
                                <h5 class="" mt-3 mb-0"">New likes</h5>
                                <p class="" text-sm mt-1 mb-0"">Nullam id dolor id nibh ultricies vehicula ut id elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                <div class=""mt-3"">
                                    <span class=""badge badge-pill badge-info"">design</span>
                                    <span class=""badge badge-pill badge-info"">system</span>
                                    <span class=""badge badge-pill badge-info"">creative</span>
                                </div>
                            </div>
                        </div>
                        <div class=""timeline-block"">
                            <span class=""timeline-step badge-success"">
                                <i class=""ni ni-bell-55""></i>
                            </span>
                            <div clas");
            WriteLiteral(@"s=""timeline-content"">
                                <small class=""text-muted font-weight-bold"">10:30 AM</small>
                                <h5 class="" mt-3 mb-0"">New message</h5>
                                <p class="" text-sm mt-1 mb-0"">Nullam id dolor id nibh ultricies vehicula ut id elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                <div class=""mt-3"">
                                    <span class=""badge badge-pill badge-success"">design</span>
                                    <span class=""badge badge-pill badge-success"">system</span>
                                    <span class=""badge badge-pill badge-success"">creative</span>
                                </div>
                            </div>
                        </div>
                        <div class=""timeline-block"">
                            <span class=""timeline-step badge-danger"">
                                <i class=""ni ni-html");
            WriteLiteral(@"5""></i>
                            </span>
                            <div class=""timeline-content"">
                                <small class=""text-muted font-weight-bold"">10:30 AM</small>
                                <h5 class="" mt-3 mb-0"">Product issue</h5>
                                <p class="" text-sm mt-1 mb-0"">Nullam id dolor id nibh ultricies vehicula ut id elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                <div class=""mt-3"">
                                    <span class=""badge badge-pill badge-danger"">design</span>
                                    <span class=""badge badge-pill badge-danger"">system</span>
                                    <span class=""badge badge-pill badge-danger"">creative</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </d");
            WriteLiteral("iv>\r\n");
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
