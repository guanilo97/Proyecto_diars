#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4205e524dca345e2a7c6ab8af1fb3526b2a6b533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminReserva_Reservadia), @"mvc.1.0.view", @"/Views/AdminReserva/Reservadia.cshtml")]
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
#line 1 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\_ViewImports.cshtml"
using Proyecto_diars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\_ViewImports.cshtml"
using Proyecto_diars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4205e524dca345e2a7c6ab8af1fb3526b2a6b533", @"/Views/AdminReserva/Reservadia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminReserva_Reservadia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- JavaScript Bundle with Popper -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4"" crossorigin=""anonymous""></script>
<!-- CSS only -->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"" crossorigin=""anonymous"">

<div class=""container-fluid"">
    <div class=""row page-title clearfix"">
        <div class=""page-title-left"">
            <h6 class=""page-title-heading mr-0 mr-r-5"">Pedidos</h6>
        </div>
    </div>

    <section class=""content"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Usuario</th>
                    <th>N?? Personas</th>
                    <th>Fecha</th>
                    <th>Hora</th>
                    <th>Mesa</th>
                    <th>Es");
            WriteLiteral("tado del pedido</th>\r\n                    <th>Pedido</th>\r\n\r\n                </tr>\r\n\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(item.usuario.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(item.N_personas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(string.Format("{0:d}", item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(item.Hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(item.mesa.N_Mesa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <!-- Button trigger modal -->\r\n                            ");
#nullable restore
#line 42 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                       Write(item.estado_Pedido.Nombre_Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                             if (item.estado_Pedido.Nombre_Estado != "Finalizado" & item.estado_Pedido.Nombre_Estado !="Pagado")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"reservas btn btn-warning\" data-bs-toggle=\"modal\" data-idreserva=\"");
#nullable restore
#line 45 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                                                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-bs-target=\"#exampleModal\">\r\n                                    Cambiar estado\r\n                                </button>\r\n");
#nullable restore
#line 48 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                            }
        

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2852, "\"", 2905, 2);
            WriteAttributeValue("", 2859, "/AdminReserva/detallepedido?idreserva=", 2859, 38, true);
#nullable restore
#line 60 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
WriteAttributeValue("", 2897, item.Id, 2897, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detalle Pedido</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\Reservadia.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

    </section>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Seleccione estado a cambiar</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <button id=""est1"" type=""button"" class=""btn btn-warning"">Reservado</button>
                <button id=""est2"" type=""button"" class=""btn btn-success"">En atenci??n</button>
                <button id=""est3"" type=""button"" class=""btn btn-red"">Finalizado</button>
");
            WriteLiteral("            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Cancelar</button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4205e524dca345e2a7c6ab8af1fb3526b2a6b53310579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var idreserva = 0;

    $(""body"").on(""click"", "".reservas"", function (e) {
        var $this = $(this)

        e.preventDefault();
        idreserva = $this.data(""idreserva"");
    });

    $('#est1').click(function () {
        var request = $.ajax({
            url: '/AdminReserva/CambiarEstado?idreserva=' + idreserva + '&&estadopedido=Reservado'
        });

        request.done(function (resp) {
            if (resp == true) {
                location.reload();
            }
        });
    });
    $('#est2').click(function () {
        var request = $.ajax({
            url: '/AdminReserva/CambiarEstado?idreserva=' + idreserva + '&&estadopedido=En atencion'
        });

        request.done(function (resp) {
            if (resp == true) {
                location.reload();
            }
        });
    });
    $('#est3').click(function () {
        var request = $.ajax({
            url: '/AdminReserva/CambiarEstado?idreserva=' + idreserva + '&&estadopedid");
            WriteLiteral("o=Finalizado\'\r\n        });\r\n\r\n        request.done(function (resp) {\r\n            if (resp == true) {\r\n                location.reload();\r\n            }\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
