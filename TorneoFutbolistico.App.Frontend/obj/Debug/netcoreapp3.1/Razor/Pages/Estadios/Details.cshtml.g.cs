#pragma checksum "C:\Users\jair.sevillano\Music\ProyectoTorneoFutbolistico\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Estadios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157ddc21c06299b1de5ce804432c44b4eacb26e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolistico.App.Frontend.Pages.Estadios.Pages_Estadios_Details), @"mvc.1.0.razor-page", @"/Pages/Estadios/Details.cshtml")]
namespace TorneoFutbolistico.App.Frontend.Pages.Estadios
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
#line 1 "C:\Users\jair.sevillano\Music\ProyectoTorneoFutbolistico\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolistico.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157ddc21c06299b1de5ce804432c44b4eacb26e0", @"/Pages/Estadios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9755150b436199d2407957ca9da196c2dd0a17f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estadios_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalles Estadios</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\">NombreEstadio</th>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\jair.sevillano\Music\ProyectoTorneoFutbolistico\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Estadios\Details.cshtml"
       Write(Model.estadio.NombreEstadio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Direccion</th>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\jair.sevillano\Music\ProyectoTorneoFutbolistico\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Estadios\Details.cshtml"
       Write(Model.estadio.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">idMunicipio</th>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\jair.sevillano\Music\ProyectoTorneoFutbolistico\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Estadios\Details.cshtml"
       Write(Model.estadio.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157ddc21c06299b1de5ce804432c44b4eacb26e04986", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolistico.App.Frontend.Pages.Estadios.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Estadios.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Estadios.DetailsModel>)PageContext?.ViewData;
        public TorneoFutbolistico.App.Frontend.Pages.Estadios.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
