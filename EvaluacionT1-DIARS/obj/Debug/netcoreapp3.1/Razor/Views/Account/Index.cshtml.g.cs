#pragma checksum "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b09629afa4f9486eae878e619b86a16e9d31c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\_ViewImports.cshtml"
using EvaluacionT1_DIARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\_ViewImports.cshtml"
using EvaluacionT1_DIARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b09629afa4f9486eae878e619b86a16e9d31c5", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533cd113ecb6fc9dbbd84fd2c920fac386b815b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Registri Persona</h1>

<a href=""/account/create"">Registrar</a>

<table class=""table"">
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Nacimiento</th>
            <th>DNI</th>
            <th>Sexo</th>
            <th>Ciudad</th>
            <th>Direccion</th>
            <th>Correo</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
          
            var accounts = ((List<Account>)ViewBag.Account);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
         for (var i = 0; i < accounts.Count; i++)
        {
            var item = accounts[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\r\n            <tr>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
                Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Dia);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 30 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
                         Write(item.Mes);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 30 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
                                   Write(item.Anio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
               Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Malca Solis Luis\source\repos\EvaluacionT1-DIARS\EvaluacionT1-DIARS\Views\Account\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n</table>\r\n\r\n");
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