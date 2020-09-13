#pragma checksum "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\Dynamic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2cc5579b426c7c9d785021289e4c551a992d1c"
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
#nullable restore
#line 1 "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Dynamic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\olaba\Projects\DynamicBlazorComponent\DynamicComponent\Dynamic.razor"
            
    /// <summary>
    /// Type of the blazor component to be rendered
    /// </summary>
    [Parameter]
    public Type ComponentType { get; set; }

    /// <summary>
    /// Properties on the created component to be set
    /// </summary>
    [Parameter]
    public List<DynamicComponentAttribute> ComponentAttributes { get; set; }

    private RenderFragment CreateDynamicComponent() => builder =>
    {
        builder.OpenComponent(0, ComponentType);

        if(ComponentAttributes != null)
        {
            ComponentAttributes.ForEach(attr =>
            {
                builder.AddAttribute(attr.Sequence, attr.Name, attr.Sequence);
            });
        }

        builder.CloseComponent();
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
