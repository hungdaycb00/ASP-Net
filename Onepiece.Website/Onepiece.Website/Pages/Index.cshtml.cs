using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Onepiece.Website.Models;
using Onepiece.Website.Services;

namespace Onepiece.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileCharacterService CharacterService;

        public IEnumerable<Character> Characters { get; private set; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileCharacterService characterService)
        {
            _logger = logger;
            CharacterService = characterService;
        }

        public void OnGet()
        {
            Characters = CharacterService.GetCharacters();
        }
    }
}
