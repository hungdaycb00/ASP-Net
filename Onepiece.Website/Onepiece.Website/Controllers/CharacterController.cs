using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onepiece.Website.Models;
using Onepiece.Website.Services;

namespace Onepiece.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        public CharacterController(JsonFileCharacterService characterService)
        {
            this.CharacterService = characterService;
        }
        public JsonFileCharacterService CharacterService { get; }

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return CharacterService.GetCharacters();
        }
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string CharacterId, [FromQuery] int Rating)
        {
            CharacterService.AddRating(CharacterId, Rating);
            return Ok();
        }
    }
}
