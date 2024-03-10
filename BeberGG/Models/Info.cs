using Microsoft.AspNetCore.Routing.Template;
using System.Collections.Generic;

namespace BeberGG.Models
{
    public class Info
    {
        public string gameMode { get; set; }
        public string gameVersion { get; set; }
        public List<Participant> participants { get; set; }
        public List<Team> teams { get; set; }
    }
}
