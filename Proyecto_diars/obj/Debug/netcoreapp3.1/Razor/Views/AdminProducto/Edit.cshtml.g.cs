#pragma checksum "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6feee541d3b6694f7c34caf74ab0ba9105c6d5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProducto_Edit), @"mvc.1.0.view", @"/Views/AdminProducto/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6feee541d3b6694f7c34caf74ab0ba9105c6d5db", @"/Views/AdminProducto/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa32c44af9a927778dfa16a1d1887e7461af7b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProducto_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6feee541d3b6694f7c34caf74ab0ba9105c6d5db3802", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">Nombre</label>\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 220, "\"", 241, 1);
#nullable restore
#line 10 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
WriteAttributeValue("", 228, Model.Nombre, 228, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Nombre\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">Precio</label>\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 382, "\"", 403, 1);
#nullable restore
#line 14 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
WriteAttributeValue("", 390, Model.Precio, 390, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Precio\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">Descripcion</label>\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 549, "\"", 575, 1);
#nullable restore
#line 18 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
WriteAttributeValue("", 557, Model.Descripcion, 557, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Descripcion\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Imagen</label>\r\n        <input type=\"file\" name=\"file\" />\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 740, "\"", 759, 1);
#nullable restore
#line 23 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
WriteAttributeValue("", 746, Model.Imagen, 746, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n    </div>\r\n    <button>Guardar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 69, "/AdminProducto/Edit?Id_Producto=", 69, 32, true);
#nullable restore
#line 7 "C:\Users\HP\Documents\04-06-2021\Proyecto_diars\Proyecto_diars\Views\AdminProducto\Edit.cshtml"
AddHtmlAttributeValue("", 101, Model.Id_producto, 101, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
