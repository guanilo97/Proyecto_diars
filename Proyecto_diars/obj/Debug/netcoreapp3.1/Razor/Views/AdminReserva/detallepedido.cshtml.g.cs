#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2fed2b234052abc7a313dce151ef8094f97196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminReserva_detallepedido), @"mvc.1.0.view", @"/Views/AdminReserva/detallepedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2fed2b234052abc7a313dce151ef8094f97196", @"/Views/AdminReserva/detallepedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminReserva_detallepedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a href=""/AdminReserva/Index"">volver</a>

<br />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Producto</th>
            <th>Cantidad</th>
            <th>Precio</th>
            <th>Subtotal</th>
        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
               Write(item.productos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
               Write(item.productos.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
               Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminReserva\detallepedido.cshtml"
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