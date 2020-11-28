using Microsoft.AspNetCore.Hosting;
using Onepiece.Website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Onepiece.Website.Services
{
    public class JsonFileCharacterService
    {
        public JsonFileCharacterService (IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFileName { get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "OnepieceCharaters.json"); } }

        public IEnumerable<Character> GetCharacters()
        {
            using(var JsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Character[]>(JsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    
            }
        }

        public void AddRating(string characterId, int rating)
        {
            var characters = GetCharacters();
            var query = characters.First(x => x.Id == characterId);

            if(query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }

            else
            {
                var ratings = query.Ratings.ToList();
                ratings.Add(rating);
                query.Ratings = ratings.ToArray();
            }

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Character>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }), characters);
            }
        }
    }
}
