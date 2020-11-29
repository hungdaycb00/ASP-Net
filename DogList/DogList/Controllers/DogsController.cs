using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DogList.Services;
using DogList.Models;

namespace DogList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        public DogsController(JsonFileDogService dogService)
        {
            DogService = dogService;
        }
        public JsonFileDogService DogService { get; }

        [HttpGet]
        public IEnumerable<dog> Get()
        {
            return DogService.GetDogs();
        }
        
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string DogId,
            [FromQuery] int rating)
        {
            DogService.AddRating(DogId, rating);
            return Ok();
        }
    }
}
