#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3164ddee90e5ef1e601383bbe227b2b179a1cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inicio_detallepedido), @"mvc.1.0.view", @"/Views/Inicio/detallepedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3164ddee90e5ef1e601383bbe227b2b179a1cb2", @"/Views/Inicio/detallepedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Inicio_detallepedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
   Layout = "_LayoutUsuario"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Producto</th>\r\n            <th>Cantidad</th>\r\n            <th>Precio</th>\r\n            <th>Subtotal</th>\r\n\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
               Write(item.productos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
               Write(item.productos.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
               Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 581, "\"", 634, 2);
            WriteAttributeValue("", 588, "/Reserva/AgregarProducto?id=", 588, 28, true);
#nullable restore
#line 32 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Inicio\detallepedido.cshtml"
WriteAttributeValue("", 616, ViewBag.Idreserva, 616, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Agregar Platos</a>\r\n\r\n");
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
