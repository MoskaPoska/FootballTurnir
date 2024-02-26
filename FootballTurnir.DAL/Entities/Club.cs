using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Entities
{
    public class Club
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string NameTeam { get; set; }
        [MinLength(5)]
        public string TownTeam { get; set; }
        public int CountVict { get; set; }
        public int CountDef { get; set; }
        public int CountDraw { get; set; }
        public int CountGoalSC { get; set; }
        public int CountGoalCo { get; set; }       
    }
}
