#pragma checksum "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\DynamicComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81523753735e1838797c8485f9069adbe58e7c06"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DynamicComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class DynamicComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 3 "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\DynamicComponent.razor"
            
    [Parameter]
    public Type ComponentType { get; set; }

    private RenderFragment CreateDynamicComponent() => builder =>
    {
        builder.OpenComponent(0, ComponentType);
        builder.AddAttribute(1, "Title", "Some title");
        builder.CloseComponent();
    };

#line default
#line hidden
    }
}
#pragma warning restore 1591