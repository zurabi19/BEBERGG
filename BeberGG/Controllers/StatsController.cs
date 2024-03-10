using BeberGG.Models;
using BeberGG.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BeberGG.Controllers
{

    [Route("[controller]/[action]")]
    public class StatsController : Controller
    {
        private readonly IMatchRepo _matchRepo;

        public StatsController(IMatchRepo matchRepo)
        {
            _matchRepo = matchRepo;
        }

        [Route("/")]
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return View();
        }



        
        [HttpPost]
        public async Task<IActionResult> GetMatches(User user)
        {
            Account account = await _matchRepo.GetAccount(user.gameName, user.tagLine);
            List<string> matchIds = await _matchRepo.GetMatchIds(account.puuid);
            List<Match> matches = new List<Match>();
            if (matchIds != null && matchIds.Any())
            {
                foreach (var id in matchIds)
                {
                    matches.Add(await _matchRepo.GetMatch(id));
                }
            }
            else
            {
                await Response.WriteAsync("No matches found.");
            }

            return View(matches);
        }
    }
        
}
