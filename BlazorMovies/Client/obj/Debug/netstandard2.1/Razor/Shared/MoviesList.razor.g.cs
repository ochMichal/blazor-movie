#pragma checksum "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d766b89884c7ce96c3209793cc273d0c505621c"
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
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "checkbox");
            __builder.AddAttribute(2, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                              displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayButtons = __value, displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __Blazor.BlazorMovies.Client.Shared.MoviesList.TypeInference.CreateGenericList_0(__builder, 5, 6, 
#nullable restore
#line 5 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                   Movies

#line default
#line hidden
#nullable disable
            , 7, (movie) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.IndividualMovie>(9);
                __builder2.AddAttribute(10, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 7 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                       displayButtons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovies.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovies.Shared.Entities.Movie>(this, 
#nullable restore
#line 8 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                      DeleteMovie

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.Confirmation>(15);
            __builder.AddAttribute(16, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                              onCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                                   onConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddContent(21, "Do you wish to delete ");
                __builder2.AddContent(22, 
#nullable restore
#line 14 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                movieToBeDeleted.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(23, " ?");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(25, (__value) => {
#nullable restore
#line 12 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                      confirmation = (BlazorMovies.Client.Shared.Confirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Dev\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
       

    Confirmation confirmation;
    Movie movieToBeDeleted;

    [Parameter] public List<Movie> Movies { get; set; }


    bool displayButtons = true;

    private async Task DeleteMovie(Movie movie)
    {
        movieToBeDeleted = movie;
        confirmation.Show();
        //await js.MyFunction("custom message");
        //var confirmed = await js.Confirm($"Are you sure you want to delete {movie.Title}?");

        //if(confirmed)
        //{
        //    Movies.Remove(movie);
        //}

    }

    void onConfirm()
    {
        Movies.Remove(movieToBeDeleted);
        confirmation.Hide();
        movieToBeDeleted = null;
    }

    void onCancel()
    {
        confirmation.Hide();
        movieToBeDeleted = null;
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized. Movies.Count = " + Movies.Count.ToString());
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet. Movies.Count = " + Movies.Count.ToString());
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("OnAfterRender. First Render = " + firstRender.ToString());
    }

    protected override bool ShouldRender()
    {
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Shared.MoviesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
