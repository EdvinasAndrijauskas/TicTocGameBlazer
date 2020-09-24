#pragma checksum "D:\Univer\C#\Sesion4\Blazer\TicTocGame\Components\Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2accf5ee470004fa5722fffc56b5673d90da2be8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TicTocGame.Components
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
    public partial class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Univer\C#\Sesion4\Blazer\TicTocGame\Components\Board.razor"
       
    private bool xIsNext;
    private char[] values = new char[9];

    protected override void OnInitialized()
    {
        values = new char[9]
        {
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };
        xIsNext = true;
    }

    private void HandleClick(int i)
    {
        if (values[i] != ' ')
        {
            return;
        }
        bool isGameFiniched = Helper.CalculateGameStatus(values) != GameStatus.NotYetFiniched;
        if (isGameFiniched)
        {
            return;
        }
        bool xToPlay = xIsNext;
        values[i] = xToPlay ? 'X' : 'O';
        xIsNext = !xToPlay;
    }
    
    private void PlayAgainHandler()
    {
        InitState();
    }
    private void InitState()
    {
        values = new char[9]
        {
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };
        xIsNext = true;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
