#pragma checksum "D:\Univer\C#\Sesion4\Blazer\TicTocGame\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be716abd9ec5af53957089bafcdcfd72c1a2653"
// <auto-generated/>
#pragma warning disable 1591
namespace TicTocGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using TicTocGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using TicTocGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\_Imports.razor"
using TicTocGame.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\Pages\Index.razor"
using TicTocGame.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Tic Tac Toe game</h2>\r\n<hr>\r\n");
            __builder.OpenComponent<TicTocGame.Components.Board>(1);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591