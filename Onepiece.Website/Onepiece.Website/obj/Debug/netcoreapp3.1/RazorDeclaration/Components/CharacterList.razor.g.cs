#pragma checksum "C:\Users\Admin\source\ASp\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e17062d3c964409345f4e8f38af4de9ac8f2d04"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Onepiece.Website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Admin\source\ASp\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Onepiece.Website.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\ASp\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\ASp\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Onepiece.Website.Models;

#line default
#line hidden
#nullable disable
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Admin\source\ASp\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
       
    Character selectCharacter;
    string selectCharacterId;

    void SelectCharacter(string characterId)
    {
        selectCharacterId = characterId;
        selectCharacter = CharacterService.GetCharacters().First(x => x.Id == characterId);
        GetCurrentRating();
    }
    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectCharacter.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectCharacter.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectCharacter.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for{selectCharacter.Id} : {currentRating}");
    }
    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectCharacter.Id}: {rating}");
        CharacterService.AddRating(selectCharacterId, rating);
        SelectCharacter(selectCharacterId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileCharacterService CharacterService { get; set; }
    }
}
#pragma warning restore 1591
