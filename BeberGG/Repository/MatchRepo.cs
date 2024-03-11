using BeberGG.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Text.Json;
namespace BeberGG.Repository
{
    public class MatchRepo :IMatchRepo
    {
        HttpClient client;
        Uri uri = new Uri("https://europe.api.riotgames.com");
        string key = "RGAPI-4aeeeaa0-f3be-44c5-bca0-98fd8a7105da";
        public MatchRepo()
        {
            client = new HttpClient();
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Add("X-Riot-Token", key);
        }
        public async Task<Account> GetAccount(string gameName, string tagLine)
        {
            HttpResponseMessage response = await client.GetAsync($"/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}/");
            string json = await response.Content.ReadAsStringAsync();
            Account account = JsonSerializer.Deserialize<Account>(json);
            return account;
           
        }

        public async Task<List<string>> GetMatchIds(string puuid)
        {
            HttpResponseMessage response = await client.GetAsync($"/lol/match/v5/matches/by-puuid/{puuid}/ids");
            string json = await response.Content.ReadAsStringAsync();
            List<string> matches = JsonSerializer.Deserialize<List<string>>(json);
            return matches;
        }

        public async Task<Match> GetMatch(string matchId)
        {
            HttpResponseMessage response = await client.GetAsync($"/lol/match/v5/matches/{matchId}");
            string json = await response.Content.ReadAsStringAsync();
            Match match = JsonSerializer.Deserialize<Match>(json);
            return match;
        }


    }

}
