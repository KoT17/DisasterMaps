#pragma checksum "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56a9c74feb81eafeff3ab79f9e6cd93272c33f5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56a9c74feb81eafeff3ab79f9e6cd93272c33f5", @"/Views/Home/Hazards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f33c954ac1cb1ad6bc375e061ef712552dc5943", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hazards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HazardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("upload.htm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
  
    ViewData["Title"] = "Hazards";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--
<form asp-controller=""Home"" asp-action=""Map"" method=""post"">
    <div id=""padTopBotLg"" class=""form-group text-center font-weight-bold"">

        <label>Address</label>
        <input name=""Address"" id=""AddressForm"" class=""form-control"" placeholder=""101 SwampHack Drive"" maxlength=""30"">

        <label>City</label>
        <input name=""City"" id=""CityForm"" class=""form-control"" placeholder=""Gainseville"" maxlength=""30"">

        <label>State</label>
        <input name=""State"" id=""StateForm"" class=""form-control text-uppercase"" placeholder=""FL"" maxlength=""2"">
    </div>
    <div>
        <input id=""centerDiv"" class=""btn btn-outline-dark btn-lg"" type=""submit"" value=""Submit"" onclick=""submit_by_name()"">
    </div>
</form>
-->

<h1>Hazards</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Hazard Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Positive Reports</th>
            <th scope=""col"">Negative Reports</th>
        <");
            WriteLiteral("/tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
           
            for (int i = 0; i < Model.Hazards.Count; i++)
            {
                double distance = Math.Pow(Math.Pow(Model.Hazards[i].Longitude - Model.userLongitude, 2) + Math.Pow(Model.Hazards[i].Latitude - Model.userLatitude, 2), .5);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr scope=\"row\">\r\n                <th scope=\"col\">");
#nullable restore
#line 45 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                           Write(Model.Hazards[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 46 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                           Write(Model.Hazards[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"background-color: green\" scope=\"col\">");
#nullable restore
#line 47 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                                                           Write(Model.Hazards[i].PosReport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"background-color: red\" scope=\"col\">");
#nullable restore
#line 48 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
                                                         Write(Model.Hazards[i].NegReport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\dieg\source\repos\DisasterMaps\DisasterMaps\Views\Home\Hazards.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>

<div style=""text-align: center;"">
    <button type=""button"" id=""bottomBtn"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">Report a Hazard</button>
</div>

<br />


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">New Hazard</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56a9c74feb81eafeff3ab79f9e6cd93272c33f58531", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""hazard-name"" class=""col-form-label"">Hazard:</label>
                        <input type=""text"" class=""form-control"" id=""hazard-name"">
                    </div>

                    <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Description:</label>
                        <textarea class=""form-control"" id=""message-text""></textarea>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56a9c74feb81eafeff3ab79f9e6cd93272c33f510365", async() => {
                WriteLiteral("\r\n                    <input type=\"file\" accept=\"image/*\" capture>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <br />

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""getLocation()"">Submit</button>
            </div>

        </div>
    </div>
</div>

<script>
function getLocation() {
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(showPosition);
  } else {
    alert(""Geolocation is not supported by this browser"");
  }
}

function showPosition(position) {
  alert(""Latitude: "" + position.coords.latitude + "", Longitude: "" + position.coords.longitude);
}
</script>");
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
