#pragma checksum "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2f9adb9e762fde47c30776622ed3f658d75986"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
using TrotIS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "method", "post");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"email\">Email </label>");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "email");
            __builder.AddAttribute(13, "type", "email");
            __builder.AddAttribute(14, "name", "email");
            __builder.AddAttribute(15, "placeholder", "Email...");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                user.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "<br>\r\n            ");
            __builder.AddMarkupContent(19, "<label for=\"password\">Password </label>");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "id", "password");
            __builder.AddAttribute(22, "type", "password");
            __builder.AddAttribute(23, "name", "password");
            __builder.AddAttribute(24, "placeholder", "Password...");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                               user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<br>\r\n            ");
            __builder.AddMarkupContent(28, "<label for=\"firstname\">First name </label>");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "id", "firstname");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "name", "firstname");
            __builder.AddAttribute(33, "placeholder", "First Name");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                                user.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FirstName = __value, user.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "<br>\r\n            ");
            __builder.AddMarkupContent(37, "<label for=\"lastname\">Last name </label>");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "id", "lastname");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "name", "lastname");
            __builder.AddAttribute(42, "placeholder", "Last Name");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                            user.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.LastName = __value, user.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "<br>\r\n            ");
            __builder.AddMarkupContent(46, "<label for=\"phone\">Phone </label>");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "id", "phone");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "name", "phone");
            __builder.AddAttribute(51, "placeholder", "Phone...");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                               user.Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Phone = __value, user.Phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "<br>\r\n            ");
            __builder.AddMarkupContent(55, "<label for=\"birthday\">Email </label>");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "id", "birthday");
            __builder.AddAttribute(58, "type", "date");
            __builder.AddAttribute(59, "name", "birthday");
            __builder.AddAttribute(60, "placeholder", "Birthday");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                        user.BirthDay

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.BirthDay = __value, user.BirthDay, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "<br>\r\n            ");
            __builder.AddMarkupContent(64, "<label for=\"socialclass\">Social class </label>");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "id", "socialclass");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "name", "socialclass");
            __builder.AddAttribute(69, "placeholder", "Social class");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                                                                        user.SocialClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.SocialClass = __value, user.SocialClass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "<br>\r\n            ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                               RegisterUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddMarkupContent(81, "\r\n    Already have an account?       ");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "btn btn-primary");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
                                                                             NavigateToLoginComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "\r\n        Login\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Andrei\Desktop\salll\TrotIS\Client.Blazor\Pages\Register.razor"
       

    private string apiUrl = "https://localhost:5002/api/user";
    private User user = new User();
    private void RegisterUser()
    {
        user.UserId = Guid.NewGuid();
        user.Address = null;
        Http.PostAsJsonAsync(apiUrl, user);
        navManager.NavigateTo("/", true);
    }
    private void NavigateToLoginComponent()
    {
        navManager.NavigateTo("/login", true);
    }

    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
        public virtual Address Address { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
