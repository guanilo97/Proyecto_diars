#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576178779ff5179b7d56f29f7cd1255028886bc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Moso), @"mvc.1.0.view", @"/Views/Personal/Moso.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576178779ff5179b7d56f29f7cd1255028886bc6", @"/Views/Personal/Moso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Moso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Usuario</th>
                <th>Nª Personas</th>
                <th>Mesa</th>
                <th>Detalle</th>
                <th>Finalizar atención</th>
            </tr>

        </thead>
        <tbody>
");
#nullable restore
#line 16 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
                   Write(item.usuario.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
                   Write(item.N_personas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
                   Write(item.mesa.N_Mesa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 625, "\"", 667, 2);
            WriteAttributeValue("", 632, "/Personal/detallepedido?id=", 632, 27, true);
#nullable restore
#line 22 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
WriteAttributeValue("", 659, item.Id, 659, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detalle Pedido</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 744, "\"", 790, 2);
            WriteAttributeValue("", 751, "/Personal/finalizaratencion?id=", 751, 31, true);
#nullable restore
#line 23 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"
WriteAttributeValue("", 782, item.Id, 782, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Finalizar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\Personal\Moso.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</section>");
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