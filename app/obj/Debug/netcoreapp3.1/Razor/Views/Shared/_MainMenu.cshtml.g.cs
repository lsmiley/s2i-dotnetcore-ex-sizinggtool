#pragma checksum "C:\Users\LARRYSMILEY\source\repos\s2i-dotnetcore-ex-sizinggtool\s2i-dotnetcore-ex-sizinggtool\app\Views\Shared\_MainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b98601c346e65005508a6ea00f386e417579eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainMenu), @"mvc.1.0.view", @"/Views/Shared/_MainMenu.cshtml")]
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
#line 1 "C:\Users\LARRYSMILEY\source\repos\s2i-dotnetcore-ex-sizinggtool\s2i-dotnetcore-ex-sizinggtool\app\Views\_ViewImports.cshtml"
using app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LARRYSMILEY\source\repos\s2i-dotnetcore-ex-sizinggtool\s2i-dotnetcore-ex-sizinggtool\app\Views\_ViewImports.cshtml"
using app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b98601c346e65005508a6ea00f386e417579eb3", @"/Views/Shared/_MainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""sidebar-menu"" data-widget=""tree"">
  <li class=""header"">HEADER</li>
  <!-- Optionally, you can add icons to the links -->
  <li class=""active""><a href=""#""><i class=""fa fa-link""></i> <span>Link</span></a></li>
  <li><a href=""#""><i class=""fa fa-link""></i> <span>Another Link</span></a></li>
  <li class=""treeview"">
    <a href=""#"">
      <i class=""fa fa-link""></i> <span>Multilevel</span>
      <span class=""pull-right-container"">
        <i class=""fa fa-angle-left pull-right""></i>
      </span>
    </a>
    <ul class=""treeview-menu"">
      <li><a href=""#"">Link in level 2</a></li>
      <li><a href=""#"">Link in level 2</a></li>
    </ul>
  </li>
</ul>
");
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
