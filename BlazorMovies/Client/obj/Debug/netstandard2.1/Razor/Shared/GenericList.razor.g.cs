#pragma checksum "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4dc562dcbf1779872ba4dced77c3e7f4367e1c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
                     
    }
    else
    {
        //Default Content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "        <img src=\"https://kif.info.pl/file/2018/12/lg.ring-loading-gif.gif\" alt=\"Loading...\">\r\n");
#nullable restore
#line 13 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 19 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        //Default Content
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There are no records to show");
#nullable restore
#line 24 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     

}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     foreach (var element in List)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 33 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
         ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }

    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591