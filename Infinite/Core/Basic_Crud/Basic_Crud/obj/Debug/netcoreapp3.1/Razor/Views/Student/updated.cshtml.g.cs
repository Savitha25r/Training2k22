#pragma checksum "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\Student\updated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c75bef6ec06a13e4d056caa7c1ca3336aac091b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_updated), @"mvc.1.0.view", @"/Views/Student/updated.cshtml")]
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
#line 1 "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\_ViewImports.cshtml"
using Basic_Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\_ViewImports.cshtml"
using Basic_Crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c75bef6ec06a13e4d056caa7c1ca3336aac091b", @"/Views/Student/updated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4907de93ec383d87afacb4dec5155009cf38fc3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_updated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\Student\updated.cshtml"
  
    ViewData["Title"] = "updated";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>updated</h1>\r\n<p>");
#nullable restore
#line 7 "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\Student\updated.cshtml"
Write(Model.StdName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 7 "D:\Training\Infinite\Core\Basic_Crud\Basic_Crud\Views\Student\updated.cshtml"
              Write(Model.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
