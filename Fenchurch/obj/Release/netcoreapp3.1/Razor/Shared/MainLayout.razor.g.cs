#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204e5e702e5f3d2cae435cf20c835153ac74074f"
// <auto-generated/>
#pragma warning disable 1591
namespace Fenchurch.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"qbootstrap-loader\"></div>\r\n\r\n\t");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "page");
            __builder.AddMarkupContent(3, "\r\n\t\t");
            __builder.AddMarkupContent(4, "<nav class=\"qbootstrap-nav\" role=\"navigation\">\r\n\t\t\t<div class=\"top-menu small\">\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-xs-12\">\r\n\t\t\t\t\t\t\t<div class=\"top\">\r\n\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-md-4 col-md-push-4 text-center\">\r\n\t\t\t\t\t\t\t\t\t\t<div id=\"qbootstrap-logo\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"/\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"anagrama small titulo-anagrama\">FENCHURCH</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"anagrama small bajada-1\">Corporate Finance</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"anagrama small bajada-2\">1989 - 2020</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t<div class=\"menu-1\">\r\n\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"servicios.html\">Fenchurch</a>\r\n\t\t\t\t\t\t\t\t\t\t<ul class=\"dropdown\">\r\n                                            <li><a href=\"/Fenchurch\">Fenchurch</a></li>\r\n                                            <li><a href=\"/Curriculum\">Curriculum</a></li>\r\n                                        </ul>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n                                    <li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"servicios.html\">Servicios</a>\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">Red Internacional</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">Operaciones</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"articulos.html\">Artículos</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">Preguntas</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"has-dropdown\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">Contacto</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</nav>\r\n\r\n        ");
            __builder.AddContent(5, 
#nullable restore
#line 74 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n\t\r\n\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n\r\n\t");
            __builder.AddMarkupContent(8, @"<footer id=""qbootstrap-footer2"" role=""contentinfo"">
		<div class=""row copyright"">
			<div class=""col-md-12 text-center"">
				<p>
					<small class=""block"">FENCHURCH<span class=""footer-separador"">|</span>MALDONADO, 13<span class=""footer-separador"">|</span>28006 - MADRID<span class=""footer-separador footer-separador-sm"">|</span><br class=""footer-salto-linea""><a style=""color: white"" href=""tel:+34911406490"">+34 911 406
							490</a></small>
				</p>
			</div>
		</div>
	</footer>

	");
            __builder.AddMarkupContent(9, "<div class=\"gototop js-top\">\r\n\t\t<a href=\"#\" class=\"js-gotop\"><i class=\"icon-arrow-up\"></i></a>\r\n\t</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
       

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                 
	        await js.InvokeVoidAsync("loadScript","js/jquery.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                        
            await js.InvokeVoidAsync("loadScript","js/jquery.sticky.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                        
            await js.InvokeVoidAsync("loadScript","js/jquery.easing.1.3.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                    
            await js.InvokeVoidAsync("loadScript","js/bootstrap.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                    
            await js.InvokeVoidAsync("loadScript","js/jquery.waypoints.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                           
            await js.InvokeVoidAsync("loadScript","js/jquery.stellar.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                   
            await js.InvokeVoidAsync("loadScript","js/owl.carousel.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                     
            await js.InvokeVoidAsync("loadScript","js/jquery.flexslider-min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                  
            await js.InvokeVoidAsync("loadScript","js/jquery.countTo.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                         
            await js.InvokeVoidAsync("loadScript","js/jquery.magnific-popup.min.js");
            await js.InvokeVoidAsync("loadScript","js/magnific-popup-options.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                     
            await js.InvokeVoidAsync("loadScript","js/sticky-kit.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                               
            await js.InvokeVoidAsync("loadScript","js/main.js");

            Console.WriteLine("JS should be invoked");

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591