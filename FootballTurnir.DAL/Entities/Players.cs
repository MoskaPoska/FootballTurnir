using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Entities
{
    public class Players
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Country { get; set; }
        public string NameTeam { get; set; }
        public string Position { get; set; }
    }
}
