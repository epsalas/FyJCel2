#pragma checksum "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9446b351a79429b5b5b6c24330437f63d1f6dc83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Pedido), @"mvc.1.0.view", @"/Views/Pedido/Pedido.cshtml")]
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
#line 1 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\_ViewImports.cshtml"
using FyJCel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\_ViewImports.cshtml"
using FyJCel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9446b351a79429b5b5b6c24330437f63d1f6dc83", @"/Views/Pedido/Pedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba09d8f07e0801623da7733e814a171bdcd5c0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedido_Pedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FyJCel.Models.Pedido>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pedidofecha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- bootstrap Navbar  !-->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<!--
<h2>Lista Productos</h2>
!-->
<style>
* {
  box-sizing: border-box;
}

.zoom {
  padding: 50px;
  background-color: white;
  transition: transform .2s;
  width: 200px;
  height: 100px;
  margin: 0 auto;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.5); 
}
</style>

<script language='JavaScript'>
    function Buscar(){
        var txt = document.getElementById(""txtBuscar"").value;

        if(txt == """" ){
            alert(""Fecha no encontrada"");
        }
        else{
         ");
            WriteLiteral("   window.location.href = \"/Pedido/Buscar?texto=\" + txt;\r\n        }      \r\n    }\r\n               \r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9446b351a79429b5b5b6c24330437f63d1f6dc835013", async() => {
                WriteLiteral(@"
<table border=""1"" width=""1100"">
    <tr>
        <!-- <td width=""200"">Logo EASYMARKET</td> -->
        <td wisth=""900"">
            <nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">
                <!--<form class=""form-inline"" action=""/action_page.php"">-->
                    <input width=""700"" name=""fecha"" id=""txtBuscar"" class=""form-control mr-sm-2"" type=""date"" placeholder=""Search"">
                    <button type=""submit""  class=""btn btn-success"" >Search</button>&nbsp
                    
                    
               <!-- </form>-->
            </nav>
        </td>
    </tr>
</table>

<br>

");
#nullable restore
#line 65 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
  
    if(ViewBag.mensajeGrabar != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-primary alert-dismissible fade show\" role=\"alert\">\r\n        <strong>");
#nullable restore
#line 69 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(ViewBag.mensajeGrabar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        </div>\r\n");
#nullable restore
#line 74 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
                
                <th scope=""col"">
                   Nombre del Producto 
                </th>

                <th scope=""col"">
                    Precio del Producto Unidad.
                </th>
                <th scope=""col"">
                    Cantidad
                </th>
                <th scope=""col"">
                    Nombre Usuario
                </th>
                <th scope=""col"">
                    Fecha
                </th>
                <th scope=""col"">
                    Estado
                </th>
                
                
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 107 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n \t\t\t\t");
#nullable restore
#line 111 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
            Write(Html.DisplayFor(modelItem => item.pedi_nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(Html.DisplayFor(modelItem => item.pedi_precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 117 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(Html.DisplayFor(modelItem => item.pedi_cantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 121 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(Html.DisplayFor(modelItem => item.pedi_nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(Html.Encode(item.pedi_fecha.ToShortDateString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
           Write(Html.DisplayFor(modelItem => item.pedi_estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n             \r\n        </tr>\r\n");
#nullable restore
#line 131 "E:\GITHUB\CLON\FYJCEL\FyJCel2\Views\Pedido\Pedido.cshtml"
}        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FyJCel.Models.Pedido>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
