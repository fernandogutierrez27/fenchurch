#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Pages\Articulos\15-Ebitda.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec007f99610f7e108b7d5ca829c2ebaabbe1cf67"
// <auto-generated/>
#pragma warning disable 1591
namespace Fenchurch.Pages.Articulos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Fenchurch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\www\fenchurchApp\Fenchurch\Fenchurch\_Imports.razor"
using Fenchurch.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Articulos/Ebitda")]
    public partial class _15_Ebitda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #page {\r\n        background-color: #ccc;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<article class=\"container texto-cajas p-top no-header text-justified\">\r\n  <h1 class=\"text-center dark-red\">\r\n      ¿CUÁNTO VALE MI EMPRESA? VALORACIÓN POR EL MÚLTIPLO DE EBITDA\r\n  </h1>\r\n  <p>\r\n      Si está pensando en vender su empresa, sin duda se habrá preguntado cuanto puede valer. Un factor clave en una venta exitosa es saber cómo maximizar y justificar el precio que se pide. El método de valoración más utilizado por la banca de inversión, capital riesgo, auditores y bancos es el Múltiplo de Ebitda, que está basado en la premisa de que empresas del mismo sector tienen múltiplos similares porque operan en un entorno económico similar.\r\n  </p>\r\n  <p>\r\n      El Ebitda (por sus siglas en inglés: el Beneficio antes de Impuestos, Intereses, Depreciaciones y Amortizaciones) se usa para valorar empresas ya que este valor excluye los gastos no-operativos, como son los gastos financieros, los impuestos y las amortizaciones/depreciaciones. El Ebitda nos permite comparar exclusivamente los beneficios operativos de empresas similares, con lo cual se pueden comparar los múltiplos de Ebitda que se pagan en la bolsa o han sido pagados por la compra de empresas similares.\r\n  </p>\r\n  <p>\r\n      El Valor de Empresa es el resultado de aplicar el Múltiplo “correcto” al Ebitda “correcto”.\r\n  </p>\r\n    <h4 class=\"text-center\">\r\n        Valor Empresa = Ebitda x Múltiplo\r\n    </h4>\r\n  <p>\r\n      Sin embargo, no se puede aplicar mecánicamente el múltiplo medio del Ebitda de las empresas similares adquiridas o cotizadas para llegar al Valor de Empresa. Entre empresas similares puede haber diferencias importantes en tasas de crecimiento, tamaño, concentración de clientes, equipo directivo, márgenes de rentabilidad, etc. Es, por lo tanto, esencial hacer ajustes al múltiplo teniendo en cuentas estas diferencias.\r\n  </p>\r\n  <p>\r\n      Para determinar el Ebitda “correcto” también es necesario hacer ajustes para eliminar el efecto de eventos extraordinarios, así como ajustar ingresos o gastos que están por encima o debajo de su precio de mercado.\r\n  </p>\r\n  <p>\r\n      El Valor de Empresa está compuesto de la suma del Valor de Mercado del Capital (lo que recibirían los accionistas a la venta de la empresa) más la Deuda Financiera Neta (bancos menos tesorería) de la empresa.\r\n  </p>\r\n    <h4 class=\"text-center\">\r\n        Valor de Empresa = Valor de Mercado del Capital + Deuda Financiera Neta\r\n    </h4>\r\n  <p>\r\n      El Valor de Mercado del Capital se calcula restando la Deuda Financiera Neta del Valor de Empresa.\r\n  </p>\r\n    <h4 class=\"text-center\">\r\n        Valor de Mercado del Capital = Valor de Empresa – Deuda Financiera Neta\r\n    </h4>\r\n  <p>\r\n      Por ejemplo, si la empresa tiene un Ebitda de €6 millones, y un comprador ofrece comprarle su empresa por un múltiplo de 5X, el Valor de Empresa sería € 30 millones (5x€6 millones = €30 millones). Si la empresa tiene Deuda Financiera Neta de €5 millones, entonces los accionistas percibirían €25 millones (€30 millones menos €5 millones = €25 millones) y el comprador asumiría la Deuda de €5 millones que tiene la empresa.\r\n  </p>\r\n  <p>\r\n      En el primer semestre de 2020, el Índice Argos Soditic, de empresas medianas vendidas (con valor de entre €15 y €500 millones en la zona €uro) alcanzó un múltiplo medio de Ebitda de 9.3X.\r\n  </p>\r\n</article>\r\n<p style=\"height:100px\"></p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
