#pragma checksum "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc29fc06d8377472eb82d9d76e84253af981a69"
// <auto-generated/>
#pragma warning disable 1591
namespace PwaFoodServiceBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using PwaFoodServiceBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using PwaFoodServiceBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using PwaFoodServiceBlazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Service.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produtoview")]
    public partial class Produtoview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
 if (listProduto == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<label>Carregando...</label>");
#nullable restore
#line 12 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mb-2");
#nullable restore
#line 17 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
         foreach (var item in listProduto)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card flex-md-row mb-4 box-shadow h-md-250");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body d-flex flex-column align-items-start");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "class", "mb-0");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "text-dark");
            __builder.AddAttribute(13, "href", "#");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
                                                           item.nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "card-text mb-auto");
            __builder.AddContent(18, 
#nullable restore
#line 25 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
                                                      item.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
                                                          () => AdicionarProduto(item.codigo)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-warning");
            __builder.AddAttribute(24, "data-toggle", "modal");
            __builder.AddAttribute(25, "data-target", "#MesaModal");
            __builder.AddMarkupContent(26, "\r\n                            Pedir\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, @"
                    <img class=""card-img-right flex-auto d-none d-md-block"" data-src=""holder.js/200x250?theme=thumb"" alt=""Thumbnail [200x250]"" style=""width: 200px; height: 250px;"" src=""data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22200%22%20height%3D%22250%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20200%20250%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_175093e0379%20text%20%7B%20fill%3A%23eceeef%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A13pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_175093e0379%22%3E%3Crect%20width%3D%22200%22%20height%3D%22250%22%20fill%3D%22%2355595c%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2256.1953125%22%20y%3D%22131%22%3EThumbnail%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E"" data-holder-rendered=""true"">");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Tees\source\repos\PwaFoodServiceBlazor\PwaFoodServiceBlazor\Pages\Produtoview.razor"
       

    public List<ProdutoModel> listProduto { get; set; }

    protected override async Task OnInitializedAsync()
    {
        listProduto = await localStore.GetItemAsync<List<ProdutoModel>>("listaProduto");
    }

    private async void AdicionarProduto(int codproduto)
    {
        await js.InvokeVoidAsync("VerificarMesa", codproduto);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICardapioService cardapioService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591