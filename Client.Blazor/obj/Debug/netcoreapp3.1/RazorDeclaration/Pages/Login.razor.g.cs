#pragma checksum "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9cacec7e733be70e2e70c4961b1921f2521235"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\Pages\Login.razor"
using TrotIS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Andrei\Desktop\trotis sa moara mama\TrotIS\Client.Blazor\Pages\Login.razor"
       
    private void NavigateToRegisterComponent()
    {

        NavigationManager.NavigateTo("/register", true);
    }
    private User user = new User();
    private void LoginUser()
    {

    }
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
