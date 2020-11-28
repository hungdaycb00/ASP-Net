using DogList.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DogList.Services
{
    public class JsonFileDogService
    {
        public JsonFileDogService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "dogs.json"); }
        }

        public IEnumerable<dog> GetDogs()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<dog[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddRating(string dogId, int rating)
        {
            var dogs = GetDogs();
            if(dogs.First(x => x.Id == dogId).Ratings == null)
            {
                dogs.First(x => x.Id == dogId).Ratings = new int[] { rating };
            }
            else
            {
                var ratings = dogs.First(x => x.Id == dogId).Ratings.ToList();
                ratings.Add(rating);
                dogs.First(x => x.Id == dogId).Ratings = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<dog>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    dogs
                );
            }
        }


    }
}
