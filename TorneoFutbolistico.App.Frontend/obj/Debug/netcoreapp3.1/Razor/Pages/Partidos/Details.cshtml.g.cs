#pragma checksum "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236d43ec3bd992b72445bd7b2967b97affd8da8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolistico.App.Frontend.Pages.Partidos.Pages_Partidos_Details), @"mvc.1.0.razor-page", @"/Pages/Partidos/Details.cshtml")]
namespace TorneoFutbolistico.App.Frontend.Pages.Partidos
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
#line 1 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolistico.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236d43ec3bd992b72445bd7b2967b97affd8da8c", @"/Pages/Partidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9755150b436199d2407957ca9da196c2dd0a17f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Partidos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddEstadio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddArbitro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalles Partidos</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\">FechaHora</th>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
       Write(Model.partido.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">EquipoLocal</th>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
       Write(Model.partido.EquipoLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">MarcadorLocal</th>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
       Write(Model.partido.MarcadorLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">EquipoVisitante</th>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
       Write(Model.partido.EquipoVisitante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">MarcadorVisitante</th>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
       Write(Model.partido.MarcadorVisitante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Estadio</th>\r\n");
#nullable restore
#line 29 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
         if(Model.partido.Estadio == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236d43ec3bd992b72445bd7b2967b97affd8da8c6990", async() => {
                WriteLiteral("Asignar Estadio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
                                                                     WriteLiteral(Model.partido.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 34 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 37 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
           Write(Model.partido.Estadio.NombreEstadio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Arbitro</th>\r\n");
#nullable restore
#line 42 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
         if(Model.partido.Arbitro == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236d43ec3bd992b72445bd7b2967b97affd8da8c10773", async() => {
                WriteLiteral("Asignar Arbitro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
                                                                     WriteLiteral(Model.partido.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 47 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 50 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
           Write(Model.partido.Arbitro.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\TorneoFutbol\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Partidos\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236d43ec3bd992b72445bd7b2967b97affd8da8c14139", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolistico.App.Frontend.Pages.Partidos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Partidos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Partidos.DetailsModel>)PageContext?.ViewData;
        public TorneoFutbolistico.App.Frontend.Pages.Partidos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
