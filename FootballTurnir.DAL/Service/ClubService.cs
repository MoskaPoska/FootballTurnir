using FootballTurnir.DAL.Entities;
using FootballTurnir.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Service
{
    public class ClubService
    {
        private readonly ClubRepository _clubRepository;

        public ClubService(FootballTurnirContext context)
        {
            _clubRepository = new ClubRepository(context);
        }

        public ClubService()
        {
            _clubRepository = new ClubRepository(new FootballTurnirContext());
        }

        public void AddClub()
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Clubs.Count() == 0)
                {
                    List<Club> clubs = new List<Club>()
                    {
                         new Club() { NameTeam = "Shahter", TownTeam = "Donetsk", CountVict = 30, CountDef = 0, CountDraw = 3, CountGoalSC = 18, CountGoalCo = 3},
                         new Club() { NameTeam = "Barselona", TownTeam = "Barselona", CountVict = 20, CountDef = 5, CountDraw = 1, CountGoalSC = 13, CountGoalCo = 6},
                         new Club() { NameTeam = "Real Madrid", TownTeam = "Madrid", CountVict = 25, CountDef = 10, CountDraw = 6, CountGoalSC = 9, CountGoalCo = 5},
                         new Club() { NameTeam = "Dinamo", TownTeam = "Kyiv", CountVict = 18, CountDef = 20, CountDraw = 4, CountGoalSC = 10, CountGoalCo = 4},
                         new Club() { NameTeam = "DonetskProm", TownTeam = "Donetsk", CountVict = 12, CountDef = 3, CountDraw = 2, CountGoalSC = 6, CountGoalCo = 9}
                    };
                    context.Clubs.AddRange(clubs);
                    context.SaveChanges();
                }
                var presentTeam = context.Clubs.FirstOrDefault(t => t.NameTeam == "Chelsea");

                if (presentTeam==null)
                {
                    Club club = new Club() { NameTeam = "Chelsea", TownTeam = "Chelsea", CountVict = 18, CountDef = 0, CountDraw = 5, CountGoalSC = 15, CountGoalCo = 4 };
                    context.Clubs.Add(club);
                    context.SaveChanges();
                }             
            }
        }
        public void AddMatch()
        {
            using(var context= new FootballTurnirContext())
            {
                if(context.Matches.Count()==0)
                {
                    List<Match> matchs = new List<Match>()
                    {
                        new Match(){Team1="Shahter", Team2="Real Madrid", CountGoalTeam1=6, CountGoalTeam2=2, DateTime = new DateTime(2001,01,01)},
                        new Match(){Team1="Barselona", Team2="Barselona", CountGoalTeam1=4, CountGoalTeam2=3, DateTime = new DateTime(2002,02,02)}
                    };
                    context.Matches.AddRange(matchs);
                    context.SaveChanges();
                }
                var presentMatch= context.Matches.FirstOrDefault(t =>t.Team1=="Dinamo"&&t.Team2=="Zorya");

                if (presentMatch == null)
                {
                    Match match = new Match() { Team1 = "Dinamo", Team2 = "Zorya", CountGoalTeam1 = 3, CountGoalTeam2 = 1, DateTime = new DateTime(2003, 03, 03)};
                    context.Matches.Add(match);
                    context.SaveChanges();
                }
            }
        }
        public void AddPlayer()
        {
            using (var context = new FootballTurnirContext())
            {
                if(context.Players.Count()==0)
                {
                    List<Players> players = new List<Players>()
                    {
                        new Players() {FirstName="Vorobey", Country = "Ukraine", NameTeam="Shahter", Position="Bombardir", CountGoals = 114},
                        new Players() {FirstName="Starukhin", Country = "Ukraine", NameTeam="Shahter", Position="Bombardir", CountGoals = 110},
                         new Players() {FirstName="Adriano", Country = "Ukraine", NameTeam="Shahter", Position="Bombardir", CountGoals = 128},
                        new Players() {FirstName="Pyatov", Country = "Ukraine", NameTeam="Shahter", Position="Gollkeeper", CountGoals = 0},
                        new Players() {FirstName="Messi", Country = "Spain", NameTeam="Barselona", Position="Bombardir", CountGoals = 672},
                        new Players() {FirstName="Suarez", Country = "Spain", NameTeam="Barselona", Position="Bombardir", CountGoals = 195},
                        new Players() {FirstName="Rodriguez", Country = "Spain", NameTeam="Barselona", Position="Bombardir", CountGoals = 226},
                        new Players() {FirstName="Stegen", Country = "Spain", NameTeam="Barselona", Position="Goalkeeper", CountGoals = 0},
                        new Players() {FirstName="Ronaldo", Country = "Spain", NameTeam="Real Madrid", Position="Bombardir", CountGoals = 450},
                        new Players() {FirstName="Benzema", Country = "Spain", NameTeam="Real Madrid", Position="Bombardir", CountGoals = 354},
                        new Players() {FirstName="Raul", Country = "Spain", NameTeam="Real Madrid", Position="Bombardir", CountGoals = 323},
                        new Players() {FirstName="Courtois", Country = "Spain", NameTeam="Real Madrid", Position="Goalkeeper", CountGoals = 0}
                    };
                    context.Players.AddRange(players);
                    context.SaveChanges();
                }
            }
        }
        public bool IsUnique(Club club)
        {
            return !_clubRepository.GetAll<Club>().Any(g => g.NameTeam == club.NameTeam);
        }

        public void AddMatch(Match match)
        {
            _clubRepository.Add(match);
        }

        public void AddPlayer(Players player)
        {
            _clubRepository.Add(player);
        }

        public void RemoveClub(Club club)
        {
            _clubRepository.Delete(club);
        }
        public void RemoveMatch(Match match)
        {
            _clubRepository.Delete(match);
        }
        public void UpdateClub(Club club)
        {
            _clubRepository.Update(club);
        }
        public void UpdateMatch(Match match)
        {
            _clubRepository.Update(match);
        }
        public Club? FindInfoNameTeam()
        {
            var teamName = "Shahter";
            return _clubRepository.GetAll<Club>().FirstOrDefault(g => g.NameTeam == teamName);
        }
        public Club? FindStatisticGames()
        {
            var townTeam = "Madrid";
            return _clubRepository.GetAll<Club>().FirstOrDefault(g => g.TownTeam == townTeam);
        }
        //public Club?FindInfoNameTeamAndTown()
        //{
        //    var teamName = "Barselona";
        //    var townName = "Dinamo";
        //    return _clubRepository.GetAll<Club>().FirstOrDefault(g => g.TownTeam == townName && g.NameTeam == teamName);
        //}
        public Club? DisplayInfoOneTeam()
        {
            var cityName = "Donetsk";
            return _clubRepository.GetAll<Club>().FirstOrDefault(g => g.TownTeam == cityName);
        }
        public Club? DisplyInfoMostPoints()
        {
            var teamByMaxPoints = _clubRepository.GetAll<Club>().OrderByDescending(g => g.CountVict * 3 + g.CountDraw).FirstOrDefault();
            return teamByMaxPoints;
        }
        public Club?DisplayInfoMinPoints()
        {
            var teamByMinPoints = _clubRepository.GetAll<Club>().OrderBy(g=>g.CountVict*3+g.CountDraw).FirstOrDefault(); 
            return teamByMinPoints;
        }
        public List<Club>?DisplayTop3PopularTeam()
        {
            var teamTop3Popular = _clubRepository.GetAll<Club>().OrderByDescending(g => g.CountVict * 3 + g.CountDraw).Take(3).ToList();
            return teamTop3Popular;
        }
        public List<Club>? DisplayNeTop3PopularTeam()
        {
            var teamNeTop3Popular = _clubRepository.GetAll<Club>().OrderBy(g => g.CountVict * 3 + g.CountDraw).Take(3).ToList();
            return teamNeTop3Popular;
        }
        public Dictionary<string, int>DisplayScoredBetweenTeams()
        {
            var goalDifference= new Dictionary<string, int>();
            var teams = _clubRepository.GetAll<Club>();
            foreach(var team in teams)
            {
                goalDifference.Add(team.NameTeam, team.CountGoalSC - team.CountGoalCo);
            }
            return goalDifference;           
        }
        public List<Match>? DisplayInfoMatchDate(DateTime dateTime)
        {
            List<Match> matches = new List<Match>();
            foreach(var match in _clubRepository.GetAll<Match>())
            {
                if(match.DateTime.Date== dateTime)
                {
                    matches.Add(match);
                }                        
            }
            return matches;
        }
        public List<Match>?DisplayAllMatchOneTeam(string teamName)
        {
            List<Match> matches = new List<Match>();
            foreach(var match in  _clubRepository.GetAll<Match>())
            {
                if(match.Team1== teamName||match.Team2==teamName)
                {
                    matches.Add(match);
                }
            }
            return matches;
        }
        public List<Players>? DisplayTop3BombardirsOneTeam(string teamName)
        {
            var top3bombOneTeam = _clubRepository.GetAll<Players>().OrderByDescending(t=>t.CountGoals).Take(3).ToList();
            return top3bombOneTeam;
        }
        public List<Players>? DisplayTop3Bombardirs()
        {
            var top3bomb = _clubRepository.GetAll<Players>().OrderByDescending(t=>t.CountGoals).Take(3).ToList();
            return top3bomb;
        }
        public Players?DisplayTheBestPlayer()
        {
            var bestPlayer = _clubRepository.GetAll<Players>().OrderByDescending(t=>t.CountGoals).FirstOrDefault();
            return bestPlayer;
        }
        public List<Club>?DisplayTop3MostGoals()
        {
            var mostGoals=_clubRepository.GetAll<Club>().OrderByDescending(t=>t.CountGoalSC).Take(3).ToList();
            return mostGoals;
        }
        public Club?DisplayTopGoalsTeam()
        {
            var teamGoal = _clubRepository.GetAll<Club>().OrderByDescending(t => t.CountGoalSC).FirstOrDefault();
            return teamGoal;
        }
        public List<Club>?DisplayMinMissedGoal()
        {
            var minMissed=_clubRepository.GetAll<Club>().OrderBy(t=>t.CountGoalCo).Take(3).ToList();
            return minMissed;
        }
        public Club?DisplayMinGoalMissedTeam()
        {
            var minMissedGoalTeam = _clubRepository.GetAll<Club>().OrderBy(t => t.CountGoalCo).FirstOrDefault();
            return minMissedGoalTeam;
        }
        public Club?DisplayTeamMostScored()
        {
            var teamMostScored = _clubRepository.GetAll<Club>().OrderByDescending(t => t.CountVict * 3 + t.CountDraw).FirstOrDefault();
            return teamMostScored;
        }
        public Club? DisplayTeamLowScored()
        {
            var teamLowScored=_clubRepository.GetAll<Club>().OrderBy(t=>t.CountVict*3+t.CountDraw).FirstOrDefault();
            return teamLowScored;
        }
    }
}
