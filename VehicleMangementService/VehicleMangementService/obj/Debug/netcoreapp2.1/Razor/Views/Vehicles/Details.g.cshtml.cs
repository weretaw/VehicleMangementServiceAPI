#pragma checksum "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05f846b1f898ee9188ff9aecb9655220cfac8c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Details), @"mvc.1.0.view", @"/Views/Vehicles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicles/Details.cshtml", typeof(AspNetCore.Views_Vehicles_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05f846b1f898ee9188ff9aecb9655220cfac8c0", @"/Views/Vehicles/Details.cshtml")]
    public class Views_Vehicles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleMangementService.Models.Vehicle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(92, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Vehicle</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 41, false);
#line 14 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 37, false);
#line 17 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 41, false);
#line 20 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(465, 37, false);
#line 23 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owner));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(546, 40, false);
#line 26 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 36, false);
#line 29 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(666, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(710, 49, false);
#line 32 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LicenseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(759, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(803, 45, false);
#line 35 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.LicenseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(848, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(892, 41, false);
#line 38 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(933, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(977, 37, false);
#line 41 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1058, 44, false);
#line 44 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TopSpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1146, 40, false);
#line 47 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.TopSpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1230, 45, false);
#line 50 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.kmPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1319, 41, false);
#line 53 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.kmPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1404, 42, false);
#line 56 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Torque));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1490, 38, false);
#line 59 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Torque));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1572, 48, false);
#line 62 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CO2Emissions));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1664, 44, false);
#line 65 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.CO2Emissions));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1752, 50, false);
#line 68 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EuroEmissStand));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1846, 46, false);
#line 71 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.EuroEmissStand));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1936, 48, false);
#line 74 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MilesPerTank));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2028, 44, false);
#line 77 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.MilesPerTank));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2116, 42, false);
#line 80 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2202, 38, false);
#line 83 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2284, 45, false);
#line 86 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wheelbase));

#line default
#line hidden
            EndContext();
            BeginContext(2329, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2373, 41, false);
#line 89 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wheelbase));

#line default
#line hidden
            EndContext();
            BeginContext(2414, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2458, 50, false);
#line 92 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TurningCircile));

#line default
#line hidden
            EndContext();
            BeginContext(2508, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2552, 46, false);
#line 95 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.TurningCircile));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2642, 46, false);
#line 98 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineSize));

#line default
#line hidden
            EndContext();
            BeginContext(2688, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2732, 42, false);
#line 101 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngineSize));

#line default
#line hidden
            EndContext();
            BeginContext(2774, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2818, 45, false);
#line 104 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cylinders));

#line default
#line hidden
            EndContext();
            BeginContext(2863, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2907, 41, false);
#line 107 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cylinders));

#line default
#line hidden
            EndContext();
            BeginContext(2948, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2992, 42, false);
#line 110 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Valves));

#line default
#line hidden
            EndContext();
            BeginContext(3034, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3078, 38, false);
#line 113 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valves));

#line default
#line hidden
            EndContext();
            BeginContext(3116, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3160, 44, false);
#line 116 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FuelType));

#line default
#line hidden
            EndContext();
            BeginContext(3204, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3248, 40, false);
#line 119 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.FuelType));

#line default
#line hidden
            EndContext();
            BeginContext(3288, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3332, 48, false);
#line 122 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Transmission));

#line default
#line hidden
            EndContext();
            BeginContext(3380, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3424, 44, false);
#line 125 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Transmission));

#line default
#line hidden
            EndContext();
            BeginContext(3468, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3512, 43, false);
#line 128 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GearBox));

#line default
#line hidden
            EndContext();
            BeginContext(3555, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3599, 39, false);
#line 131 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.GearBox));

#line default
#line hidden
            EndContext();
            BeginContext(3638, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3682, 47, false);
#line 134 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Drivertrain));

#line default
#line hidden
            EndContext();
            BeginContext(3729, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3773, 43, false);
#line 137 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Drivertrain));

#line default
#line hidden
            EndContext();
            BeginContext(3816, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3860, 42, false);
#line 140 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(3902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3946, 38, false);
#line 143 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(3984, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4051, "\"", 4082, 1);
#line 148 "C:\Users\woretawc\Source\Repos\VehicleMangementService\VehicleMangementService\Views\Vehicles\Details.cshtml"
WriteAttributeValue("", 4066, Model.VehicleId, 4066, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4083, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleMangementService.Models.Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
