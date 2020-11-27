#pragma checksum "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e17062d3c964409345f4e8f38af4de9ac8f2d04"
// <auto-generated/>
#pragma warning disable 1591
namespace Onepiece.Website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Onepiece.Website.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
using Onepiece.Website.Models;

#line default
#line hidden
#nullable disable
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
     foreach (var character in CharacterService.GetCharacters())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:url(\'" + (
#nullable restore
#line 10 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                                character.Image

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                            character.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-footer");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                  (e => SelectCharacter(character.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#characterModal");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddMarkupContent(32, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 24 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n\r\n");
#nullable restore
#line 32 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
 if (selectCharacter != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal fade");
            __builder.AddAttribute(40, "id", "characterModal");
            __builder.AddAttribute(41, "tabindex", "-1");
            __builder.AddAttribute(42, "role", "dialog");
            __builder.AddAttribute(43, "aria-labelledby", "productTitle");
            __builder.AddAttribute(44, "aria-hidden", "true");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(48, "role", "document");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-content");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-header");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "h5");
            __builder.AddAttribute(57, "class", "modal-title");
            __builder.AddAttribute(58, "id", "productTitle");
            __builder.AddContent(59, 
#nullable restore
#line 38 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                               selectCharacter.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.AddMarkupContent(61, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-body");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card");
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-img");
            __builder.AddAttribute(71, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 45 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                                             selectCharacter.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card-body");
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
            __builder.AddContent(79, 
#nullable restore
#line 48 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                  selectCharacter.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-footer");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 53 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                        ");
            __builder.AddMarkupContent(88, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 56 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                        ");
            __builder.OpenElement(90, "span");
            __builder.AddContent(91, 
#nullable restore
#line 59 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, "  ");
            __builder.AddContent(93, 
#nullable restore
#line 59 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                           voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 60 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 62 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                     for (int i = 0; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                            ");
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", "fa-star fa checked");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                                       (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 68 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                            ");
            __builder.OpenElement(102, "span");
            __builder.AddAttribute(103, "class", "fa-star fa");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                                                               (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 72 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 78 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\hungc\Documents\GitHub\ASP-Net\Onepiece.Website\Onepiece.Website\Components\CharacterList.razor"
       
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
