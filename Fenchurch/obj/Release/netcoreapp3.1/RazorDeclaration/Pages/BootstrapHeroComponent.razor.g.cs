#pragma checksum "C:\www\fenchurchApp\Fenchurch\Fenchurch\Pages\BootstrapHeroComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047e5a92002f075e77cb58d21cef339b9a19ed66"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class BootstrapHeroComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\www\fenchurchApp\Fenchurch\Fenchurch\Pages\BootstrapHeroComponent.razor"
       
    [Parameter]
    public string BackgroundImage { get; set; }
    [Parameter]
    public string CustomTitle { get; set; }
    public string FullBgImage { get; set; }
    private string defaultBackgroundImage = "header-bg";

    protected override void OnInitialized() {
        BackgroundImage = BackgroundImage ?? defaultBackgroundImage;
        FullBgImage = "../img/"+BackgroundImage+".jpg";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender) {
        await jsRuntime.InvokeVoidAsync("sliderMain");
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
