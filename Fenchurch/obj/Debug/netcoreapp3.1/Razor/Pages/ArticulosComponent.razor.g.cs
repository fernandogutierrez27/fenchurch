#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Pages\ArticulosComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa7d7525f2e34809402bcd808ad60c4fbcc6f55"
// <auto-generated/>
#pragma warning disable 1591
namespace Fenchurch.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Articulos")]
    public partial class ArticulosComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
  .item-apuntes {
    cursor: pointer;
    text-transform: inherit !important;
    font-size: 24px;
    font-weight: 700;
    font-family: ""Exo 2"" !important;
  }

  .item-apuntes:hover a {
    color: red !important;
  }

  .contenedor-items-apuntes {
    display: flex;
    justify-content: center;
  }
</style>


");
            __builder.OpenComponent<Fenchurch.Pages.BootstrapHeroComponent>(1);
            __builder.AddAttribute(2, "BackgroundImage", "bg-apuntes");
            __builder.AddAttribute(3, "CustomTitle", "ARTÍCULOS");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddMarkupContent(5, "<div class=\"container texto-cajas p-top\">\r\n  <div class=\"contenedor-items-apuntes\">\r\n    <table>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/necesita-un-asesor-para-vender-su-empresa\">\r\n              ¿Necesita un asesor para vender su empresa?\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/calendario-de-actividad\">\r\n              Calendario del proceso de una compraventa\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/definiciones-financieras\">\r\n              Definiciones financieras\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/valuation-truths\">\r\n              Verdades y mentiras sobre valoraciones de empresas\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/why-deals-fails\">\r\n              10 Equivocaciones en la compraventa de empresas\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/reflexiones-sobre-el-proceso-de-venta\">\r\n              Como maximizar el precio de venta de su empresa\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/10-mandamientos\">\r\n              Los 10 mandamientos para vender una empresa con éxito\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/Ebitda\">\r\n              Valoración por el múltiplo de EBITDA\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/proceso-de-compraventa-de-una-empresa\">\r\n              El proceso de venta de una empresa\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n      <tr>\r\n        <td class=\"item-apuntes\">\r\n          <li>\r\n            <a href=\"/Articulos/faq\">\r\n              Preguntas más frecuentes\r\n            </a>\r\n          </li>\r\n        </td>\r\n      </tr>\r\n    </table>\r\n  </div>\r\n</div>\r\n<div style=\"height:100px\"></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
