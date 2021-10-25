#pragma checksum "D:\Blazor\BlazorFront\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f580f3ea2b9a6f7e39713e62588a4946b1f191"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\BlazorFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\BlazorFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\BlazorFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\BlazorFront\_Imports.razor"
using BlazorFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor\BlazorFront\_Imports.razor"
using BlazorFront.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\" style=\"font-weight:bold;\">LIST EMPLOYEES</h3>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a href=\"employeepage\" class=\"btn btn-primary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\" title=\"Add Employee\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add Employee\r\n</a>\r\n\r\n<br><br>");
#nullable restore
#line 12 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"spinner\"></div>");
#nullable restore
#line 15 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-deck");
#nullable restore
#line 20 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
         foreach (var emp in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card m-3");
            __builder.AddAttribute(7, "style", "min-width: 18rem; max-width: 30.5%;");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 24 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
                         emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 24 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
                                        emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 25 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
                                                                   emp.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer text-center");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 27 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
                                   $"employeedetail/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "btn btn-success");
            __builder.AddAttribute(24, "data-bs-toggle", "tooltip");
            __builder.AddAttribute(25, "data-bs-placement", "top");
            __builder.AddAttribute(26, "title", "Detail");
            __builder.AddMarkupContent(27, "<span class=\"oi oi-eye\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                        ");
            __builder.AddMarkupContent(29, "<a href=\"employeepage\" class=\"btn btn-danger\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\" title=\"Delete\"><span class=\"oi oi-trash\" aria-hidden=\"true\"></span></a>\r\n\r\n                        ");
            __builder.AddMarkupContent(30, "<a href=\"employeepage\" class=\"btn btn-warning\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\" title=\"Edit\"><span class=\"oi oi-cog\" aria-hidden=\"true\"></span></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 46 "D:\Blazor\BlazorFront\Pages\EmployeePage.razor"
                        
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
