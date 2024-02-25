using FootballTurnir.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL
{
    public  class FootballTurnirContext:DbContext
    {
        public FootballTurnirContext()
        {
        }

        public FootballTurnirContext(DbContextOptions<FootballTurnirContext> options) : base(options) { }

        //public FootballTurnirContext() : base() { }
        public DbSet<Club>Clubs { get; set; }
        public DbSet<Match>Matches { get; set; }
        public DbSet<Players> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
