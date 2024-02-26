using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Entities
{
    public class Players
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MinLength(5)]
        public string Country { get; set; }
        [MaxLength(25)]
        public string NameTeam { get; set; }
        [MinLength(5)]
        public string Position { get; set; }
        public int CountGoals { get; set; }
    }
}
