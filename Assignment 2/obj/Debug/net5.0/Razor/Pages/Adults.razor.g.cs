#pragma checksum "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81fd1eb670ae29285a9dd242ee2d56a0979aa74a"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_2.Pages
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
#line 2 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
using Assignment_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
using Assignment_2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Adult list</h1>\r\n\r\nHere you can view information of every registered adults.\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "search-container");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "placeholder", "Search..");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                                                                searchedText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchedText = __value, searchedText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "submit");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                                             Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "table");
            __builder.AddMarkupContent(17, @"<tr><th>ID</th>
            <th>First name</th>
            <th>Last Name</th>
            <th>Hair color</th>
            <th>Eye color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Job title</th>
            <th>Salary</th></tr>");
#nullable restore
#line 40 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
 if (visible == true)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
     foreach (var adult in allAdults)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 45 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 46 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 47 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 48 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 49 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 50 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 51 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 52 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 53 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 54 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 55 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                 adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
 if (visible == false)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
     foreach (var adult in allAdults)
    {
        if (adult.FirstName.Contains(searchedText) || adult.LastName.Contains(searchedText) || adult.HairColor.Contains(searchedText)
        ||adult.EyeColor.Contains(searchedText) || adult.Age.ToString().Contains(searchedText) ||adult.Weight.ToString().Contains(searchedText) 
        || adult.Height.ToString().Contains(searchedText) || adult.Sex.Contains(searchedText) || adult.JobTitle.JobTitle.Contains(searchedText)
        || adult.JobTitle.Salary.ToString().Contains(searchedText))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "tr");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 70 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 71 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 72 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 73 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 74 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 75 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 76 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 77 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 78 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 79 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 80 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
                     adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\Adults.razor"
 
    private String searchedText {get; set; }
    private Boolean visible = true;
    private IList<Adult> allAdults = new Collection<Adult>();

    public void Search()
    {
        visible = false;
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            allAdults = await AdultsService.GetAdultsAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591