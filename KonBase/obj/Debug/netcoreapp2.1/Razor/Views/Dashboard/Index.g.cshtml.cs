#pragma checksum "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190c6bdead2726344095e00494300d2516a2368a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190c6bdead2726344095e00494300d2516a2368a", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4887f0e8c68bad4b956646c185182abde3d54fee", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\matheus.re\Documents\GitHub\Konbase\KonBase\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Visão Geral";

#line default
#line hidden
            BeginContext(47, 5022, true);
            WriteLiteral(@"
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Visão Geral</h1>
</div>

<div class=""row"">

    <!-- Earnings (Monthly) -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Renda (Mensal)
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">R$40,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-plus fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Spending (Monthly) -->
    <div class=""col-xl-3 col-m");
            WriteLiteral(@"d-6 mb-4"">
        <div class=""card border-left-danger shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Gasto (Mensal)
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">R$20,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-minus fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class");
            WriteLiteral(@"=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Em Caixa
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">R$80,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-box fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Moradores em Atraso
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">32</div>
                    </div>
     ");
            WriteLiteral(@"               <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <!-- Area Chart -->
    <div class=""col-xl-8 col-lg-7"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Renda e Gasto (Mensal)</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row al");
            WriteLiteral(@"ign-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Pagamentos Condomínio</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""myPieChart""></canvas>
                </div>
                <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-success""></i> Em Dia
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-warning""></i> Há Atrasar
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-danger""></i> Em Atraso
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>");
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