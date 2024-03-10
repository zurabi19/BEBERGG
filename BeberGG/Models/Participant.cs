namespace BeberGG.Models
{
    public class Participant
    {
        public string summonerName {  get; set; }
        public string puuid { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
        public string championName { get; set; }
        public int champLevel { get; set; }
        public int totalMinionsKilled { get; set; }
        public int kills { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damageSelfMitigated { get; set; }
        public int goldEarned { get; set; }
        public int itemsPurchased { get; set; }
        public string teamPosition { get; set; }
        public int timePlayed { get; set; }
        public int totalDamageDealtToChampions { get; set; }
        public int totalTimeSpentDead { get; set; }
        public int visionScore { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }
        public int item6 { get; set; }
    }
}
