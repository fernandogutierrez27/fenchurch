#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8875ce3674b1d746f2d9e93e5c9b20377f41b6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
       

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                 
	        await js.InvokeVoidAsync("loadScript","js/jquery.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                        
            await js.InvokeVoidAsync("loadScript","js/jquery.sticky.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                        
            await js.InvokeVoidAsync("loadScript","js/jquery.easing.1.3.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                    
            await js.InvokeVoidAsync("loadScript","js/bootstrap.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                    
            await js.InvokeVoidAsync("loadScript","js/jquery.waypoints.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                           
            await js.InvokeVoidAsync("loadScript","js/jquery.stellar.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                   
            await js.InvokeVoidAsync("loadScript","js/owl.carousel.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                     
            await js.InvokeVoidAsync("loadScript","js/jquery.flexslider-min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                  
            await js.InvokeVoidAsync("loadScript","js/jquery.countTo.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                         
            await js.InvokeVoidAsync("loadScript","js/jquery.magnific-popup.min.js");
            await js.InvokeVoidAsync("loadScript","js/magnific-popup-options.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                                     
            await js.InvokeVoidAsync("loadScript","js/sticky-kit.min.js");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Shared\MainLayout.razor"
                               
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
