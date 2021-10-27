// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\hansl\RiderProjects\Assignment 2\Assignment 2\Pages\AddInformationAboutAdult.razor"
       
    private Boolean buttonPressed = false;

    [Required]
    [NotNull]
    private String firstName;
    [Required]
    [NotNull]
    private String lastName;
    [Required]
    [NotNull]
    private String hairColor;
    [Required]
    [NotNull]
    private String eyeColor;
    [Required]
    [Range(18, Int32.MaxValue)]
    private int? age;
    [Required]
    [Range(0, Int32.MaxValue)]
    private int? weight;
    [Required]
    [Range(0,Int32.MaxValue)]
    private int? height;
    [Required]
    [NotNull]
    private String sex;
    [Required]
    [NotNull]
    private String jobTitle;
    [Required]
    [Range(0,Int32.MaxValue)]
    private int? salary;
    

    public async void addButtonPressed()
    {
        buttonPressed = true;
        Adult adult = new Adult();
        IList<Adult> adults = await AdultsService.GetAdultsAsync();
        int maxID = adults.Count;
        adult.Id = maxID+1;
        adult.FirstName = firstName;
        adult.LastName = lastName;
        adult.HairColor = hairColor;
        adult.EyeColor = eyeColor;
        adult.Age = (int)age;
        adult.Weight = (int)weight;
        adult.Height = (int)height;
        adult.Sex = sex;
        Job job = new Job();
        job.JobTitle = jobTitle;
        job.Salary = (int)salary;
        adult.JobTitle = job;

        AdultsService.AddAdultAsync(adult);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591