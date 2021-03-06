#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Pages\Articulos\16-proceso-de-compraventa-de-una-empresa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ea423a9ff711016afa95c1bd0537663e34fdfa"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Articulos/proceso-de-compraventa-de-una-empresa")]
    public partial class _16_proceso_de_compraventa_de_una_empresa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #page {\r\n        background-color: #ccc;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<article class=\"container texto-cajas p-top no-header text-justified\">\r\n  <h1 class=\"text-center\">\r\n    EL PROCESO DE VENTA DE UNA EMPRESA\r\n  </h1>\r\n  <p>\r\n      <strong>\r\n          1. Desarrollar una Estrategia\r\n      </strong>\r\n      <ul>\r\n          <li>Establecer los objetivos que se quieren conseguir.</li>\r\n          <li>Desarrollar las tácticas de venta.</li>\r\n          <li>Identificar a los asesores adecuados para el proceso de venta.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>2. Maximizar el valor de la empres</strong>\r\n      <ul>\r\n          <li>Determinar que medidas se pueden tomar para maximizar el precio de venta.</li>\r\n          <li>Resolver todas las posibles contingencias (fiscales, legales, laborales, medioambientales).</li>\r\n          <li>Ajustar los estados financieros para que reflejen la realidad económica de la empresa.</li>\r\n          <li>Maximizar el valor de la empresa.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>3. Valorar a la empresa</strong>\r\n      <ul>\r\n          <li>El propietario debe tener una idea clara del valor de su empresa y que entienda el razonamiento detrás del mismo.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>4. Redactar el Cuaderno de Venta</strong>\r\n      <ul>\r\n          <li>El cuaderno de venta es un instrumento que resalta los aspectos más atractivos de la empresa y suaviza sus puntos más débiles.</li>\r\n      </ul>\r\n  </p>    \r\n  <p>\r\n      <strong>5. Identificar y contactar con todos los compradores potenciales</strong>\r\n      <ul>\r\n          <li>Identificar y contactar al máximo número de posibles compradores cualificados es una de las piedras angulares del proceso de venta.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>6. Perfil Ciego y el Acuerdo de Confidencialidad</strong>\r\n      <ul>\r\n          <li>Enviar el Perfil Ciego y el Acuerdo de Confidencialidad a todos los compradores potenciales</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>7. Visitas</strong>\r\n      <ul>\r\n          <li>Organizar visitas para aquellos compradores potenciales que indiquen interés para que puedan examinar las instalaciones, entrevistarse con el propietario y hacer preguntas.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>8. Recibir Ofertas de Compra</strong>\r\n      <ul>\r\n          <li>Todas las ofertas se analizan en detalle para poder escoger al comprador que ha hecho la oferta más ventajosa.</li>\r\n          <li>La oferta seleccionada queda reflejada en una “Carta de Intenciones”, que plasma sobre el papel los acuerdos verbales alcanzados entre el comprador y el vendedor.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>9. Due Diligence</strong>\r\n      <ul>\r\n          <li>El proceso de “due diligence” consiste en un estudio en profundidad de la empresa para verificar lo que se está comprando, confirmar que el negocio funciona como se ha dicho que funciona e identificar todos los riesgos asociados a la operación.</li>\r\n      </ul>\r\n  </p>\r\n  <p>\r\n      <strong>10. Contrato de Compraventa y Cierre de la Operación</strong>\r\n      <ul>\r\n          <li>El contrato de compraventa es el documento legal que detalla los términos y condiciones de la operación: el precio, la forma de pago, la estructura de la operación, las garantías requeridas por el comprador y las indemnificaciones, entre otros muchos temas.</li>\r\n          <li>Una vez que ambas partes están de acuerdo con las condiciones del contrato, estos se firman y el comprador entrega al vendedor el dinero acordado y recibe título de la empresa.</li>\r\n      </ul>\r\n  </p>\r\n</article>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"col-md-12 contenedor-btn-print\"><button type=\"button\" class=\"btn-submit\" onclick=\"imprimir()\">Imprimir <i class=\"material-icons\">print</i></button></div>\r\n<div class=\"bottom-placeholder\"></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
