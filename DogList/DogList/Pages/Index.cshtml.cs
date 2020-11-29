using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogList.Models;
using DogList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DogList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileDogService DogService { get; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileDogService dogService)
        {
            _logger = logger;
            DogService = dogService;

        }

        public IEnumerable<dog> Dogs { get; private set; }
        public void OnGet()
        {
            Dogs = DogService.GetDogs();
        }
    }
}
