using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Entities
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Team1 { get; set; }
        [MaxLength(50)]
        public string Team2 { get; set; }
        public int CountGoalTeam1 { get; set; }
        public int CountGoalTeam2 { get; set; }
        public DateTime DateTime { get; set; }

    }
}
