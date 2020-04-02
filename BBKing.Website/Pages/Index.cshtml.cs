using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBKing.Website.Models;
using BBKing.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BBKing.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFilePlayerService PlayerService;
        public IEnumerable<Player> Players { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, 
            JsonFilePlayerService playerService)
        {
            _logger = logger;
            PlayerService = playerService;
        }

        public void OnGet()
        {
            Players = PlayerService.GetPlayers();
        }
    }
}
