#pragma checksum "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5549c246ad92362ac2427241695df4fe2f47073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Vizualizar), @"mvc.1.0.view", @"/Views/Admin/Vizualizar.cshtml")]
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
#line 1 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\_ViewImports.cshtml"
using Aula1_parte2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\_ViewImports.cshtml"
using Aula1_parte2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5549c246ad92362ac2427241695df4fe2f47073", @"/Views/Admin/Vizualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e4a43bc00e0a5301b086e8bef04ebd4e16c1b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Vizualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
#nullable restore
#line 1 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
       //com essa tag voce pode especificar um layout
    //Layout = null; //tirando o layout padrao
    //Layout = "kemylly";  //carrega outra pag de layout 

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n\r\n\r\n<!--<h1> View do controller vizualizar ");
#nullable restore
#line 7 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
                                  Write(ViewData["helloWorld"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>-->\r\n\r\n<!-- <h1> View do controller vizualizar</h1>\r\n");
#nullable restore
#line 10 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
 if((bool)ViewData["helloWorld"]){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Oi mundo</h1>\r\n");
#nullable restore
#line 12 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>tchau mundo</h1>\r\n");
#nullable restore
#line 15 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\r\n<h1>");
#nullable restore
#line 17 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\estudo_mvc\Aula1_parte2\Views\Admin\Vizualizar.cshtml"
Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
