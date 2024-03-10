using BeberGG.Models;
using System.Text.Json;

namespace BeberGG.Repository
{
    public interface IMatchRepo
    {
        public Task<Account> GetAccount(string gameName, string tagLine);

        public Task<List<string>> GetMatchIds(string puuid);

        public Task<Match> GetMatch(string matchId);


    }
}