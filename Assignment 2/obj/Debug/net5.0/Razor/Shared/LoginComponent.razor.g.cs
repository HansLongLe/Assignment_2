#pragma checksum "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c449100ef83b8b5d0ddce5f586d9935e164f7f"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Assignment_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\_Imports.razor"
using Assignment_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
using Assignment_2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
 if (!_validator.GetAuthorization())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddContent(1, " Username ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
                                             _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(6, " Password ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
                                                                                            _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(11, " ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
                                                                                                                          Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
 if (_validator.GetAuthorization())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
                      Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Logout");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Shared\LoginComponent.razor"
     
        private string _username;
        private string _password;
        private bool _authorized;
        

        private async void Login()
        {
            var user = new User
            {
                UserName = _username,
                Password = _password
            };
            
            _validator.Set(await _userService.GetResult(user));
        }

    private void Logout()
    {
        _validator.Set(false);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IValidator _validator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
#pragma warning restore 1591
