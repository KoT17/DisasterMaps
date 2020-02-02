#pragma checksum "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb979350f4a0cf453a8d00b0ad00672edf6b97d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hazards), @"mvc.1.0.view", @"/Views/Home/Hazards.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\_ViewImports.cshtml"
using DisasterMaps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\_ViewImports.cshtml"
using DisasterMaps.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb979350f4a0cf453a8d00b0ad00672edf6b97d", @"/Views/Home/Hazards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f33c954ac1cb1ad6bc375e061ef712552dc5943", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hazards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HazardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
  
    ViewData["Title"] = "Hazards";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Hazards</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Hazard</th>
            <th scope=""col"">Distance</th>
            <th scope=""col"">Positive Reports</th>
            <th scope=""col"">Negative Reports</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
      
    for(int i = 0; i < 5; i++)
    {
    double distance = Math.Pow(Math.Pow(Model.Hazards[i].Longitude - Model.userLongitude, 2)+Math.Pow(Model.Hazards[i].Latitude - Model.userLatitude, 2), .5);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr scope=\"row\">\r\n        <th scope=\"col\">");
#nullable restore
#line 22 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                   Write(Model.Hazards[i].Haz);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th scope=\"col\">");
#nullable restore
#line 23 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                   Write(distance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th style=\"background-color: red\" scope=\"col\">");
#nullable restore
#line 24 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                                                 Write(Model.Hazards[i].PosReport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th style=\"background-color: red\" scope=\"col\">");
#nullable restore
#line 25 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                                                 Write(Model.Hazards[i].NegReport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HazardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591