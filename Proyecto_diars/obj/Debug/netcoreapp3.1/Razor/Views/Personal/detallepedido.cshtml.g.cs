#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b85ddce317e9a7c30213f3bac0ad5533217efc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_detallepedido), @"mvc.1.0.view", @"/Views/Personal/detallepedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b85ddce317e9a7c30213f3bac0ad5533217efc6", @"/Views/Personal/detallepedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_detallepedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Personal/Moso\">volver</a>\r\n<div class=\"container\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 99, "\"", 165, 2);
            WriteAttributeValue("", 106, "/Personal/AgregarProducto_Moso?idreserva=", 106, 41, true);
#nullable restore
#line 4 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
WriteAttributeValue("", 147, ViewBag.Idreserva, 147, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary pull-right"">Agregar producto</a>
</div>
<br />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Producto</th>
            <th>Cantidad</th>
            <th>Precio</th>
            <th>Subtotal</th>
            <th>Eliminar</th>

        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.productos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.productos.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
               Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 795, "\"", 852, 2);
            WriteAttributeValue("", 802, "/Personal/EliminarDetallePedido?iddetalle=", 802, 42, true);
#nullable restore
#line 28 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"
WriteAttributeValue("", 844, item.Id, 844, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\detallepedido.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
