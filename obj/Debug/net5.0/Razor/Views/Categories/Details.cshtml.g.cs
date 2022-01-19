#pragma checksum "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f21032a6d19d3a28970a41f2f9d95a46854364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f21032a6d19d3a28970a41f2f9d95a46854364", @"/Views/Categories/Details.cshtml")]
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Category Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This category does not contain any items</p>\n");
#nullable restore
#line 14 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Items the category contains:</h4>\n  <ul>\n");
#nullable restore
#line 19 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
   Write(join.Item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 24 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 26 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 27 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Edit Category", "Edit", new { id = Model.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 28 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Delete Category", "Delete", new { id = Model.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 29 "C:\Users\brook\Desktop\authentication-with-identity-test\ToDoList\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
