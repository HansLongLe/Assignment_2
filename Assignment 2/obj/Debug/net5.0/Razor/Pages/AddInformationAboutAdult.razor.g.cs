#pragma checksum "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b99398fb1250825b11b35d319c7f7edbfc1b6a2"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
using System.Diagnostics.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
using Assignment_2.Data;

#line default
#line hidden
#nullable disable
    public partial class AddInformationAboutAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
 if (!_buttonPressed)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Add adult</h1>\r\n    ");
            __builder.AddMarkupContent(1, "<h3><b>Adult information</b></h3>\r\n    ");
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "ul");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "First name..");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                                 _firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _firstName = __value, _firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(9, "First name");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "ul");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "placeholder", "Last name..");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                                _lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _lastName = __value, _lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(17, "Last name");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "ul");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "placeholder", "Hair color..");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                                 _hairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _hairColor = __value, _hairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(25, "Hair color");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "ul");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "placeholder", "Eye color..");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                                _eyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _eyeColor = __value, _eyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(33, "Eye color");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "ul");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "number");
            __builder.AddAttribute(38, "placeholder", "Age..");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                            _age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _age = __value, _age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(41, "Age");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "ul");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "number");
            __builder.AddAttribute(46, "placeholder", "Weight..");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                               _weight

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _weight = __value, _weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(49, "Weight");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "ul");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "number");
            __builder.AddAttribute(54, "placeholder", "Height..");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                               _height

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _height = __value, _height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(57, "Height");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "ul");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "placeholder", "Sex..");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                          _sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _sex = __value, _sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(65, "Sex");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "ul");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "placeholder", "Job title..");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                                _jobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _jobTitle = __value, _jobTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(73, "Job title");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "ul");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "number");
            __builder.AddAttribute(78, "placeholder", "Salary..");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                                                               _salary

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _salary = __value, _salary, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(81, "Salary");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
                      AddButtonPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Add");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
 if (_buttonPressed)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Assignment_2.Pages.AddAdults>(86);
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
       
    private bool _buttonPressed = false;

    [Required]
    [NotNull]
    private string _firstName;
    
    [Required]
    [NotNull]
    private string _lastName;
    
    [Required]
    [NotNull]
    private string _hairColor;
    
    [Required]
    [NotNull]
    private string _eyeColor;
    
    [Required]
    [Range(18, int.MaxValue)]
    private int _age;
    
    [Required]
    [Range(0, int.MaxValue)]
    private int _weight;
    
    [Required]
    [Range(0, int.MaxValue)]
    private int _height;
    
    [Required]
    [NotNull]
    private string _sex;
    
    [Required]
    [NotNull]
    private string _jobTitle;
    
    [Required]
    [Range(0, int.MaxValue)]
    private int _salary;


    private async void AddButtonPressed()
    {
        _buttonPressed = true;
        var adults = await _adultsService.GetAdultsAsync();
        var maxId = adults.Count;
        var adult = new Adult
        {
            Id = maxId + 1,
            FirstName = _firstName,
            LastName = _lastName,
            HairColor = _hairColor,
            EyeColor = _eyeColor,
            Age = _age,
            Weight = _weight,
            Height = _height,
            Sex = _sex,
            JobTitle = new Job
            {
                JobTitle = _jobTitle,
                Salary = _salary
            }
        };

        await _adultsService.AddAdultAsync(adult);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService _adultsService { get; set; }
    }
}
#pragma warning restore 1591
