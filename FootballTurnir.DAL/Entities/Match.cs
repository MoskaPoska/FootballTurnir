using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int CountGoalTeam1 { get; set; }
        public int CountGoalTeam2 { get; set; }
        public DateTime DateTime { get; set; }
        public string Player { get; set; }

    }
}
