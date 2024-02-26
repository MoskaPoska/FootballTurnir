using FootballTurnir.DAL;
using FootballTurnir.DAL.Entities;
using FootballTurnir.DAL.Service;
using System.Numerics;
using System.Transactions;

namespace FootballTurnir
{
    public partial class Form1 : Form
    {
        private ClubService clubService;
        //private FootballTurnirContext context;
        public Form1(FootballTurnirContext context)
        {
            InitializeComponent();
            //this.context = context;
            clubService = new ClubService(context);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void findInfoNameTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club foundClub = clubService.FindInfoNameTeam();
                richTextBox1.Clear();

                if (foundClub != null)
                {
                    richTextBox1.AppendText($"{foundClub.NameTeam}, {foundClub.TownTeam}, {foundClub.CountVict}, {foundClub.CountDef}, {foundClub.CountDraw}, {foundClub.CountGoalSC}, {foundClub.CountGoalCo}\n");
                }
            }
        }

        private void findInfoNameTownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club foundTown = clubService.FindStatisticGames();
                richTextBox1.Clear();
                if (foundTown != null)
                {
                    richTextBox1.AppendText($"{foundTown.NameTeam}, {foundTown.TownTeam}, {foundTown.CountVict}, {foundTown.CountDef}, {foundTown.CountDraw}, {foundTown.CountGoalSC}, {foundTown.CountGoalCo}\n");
                }
            }
        }

        //private void findInfoNameTeamAndTownToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (var context = new FootballTurnirContext())
        //    {
        //        Club foundTN = clubService.FindInfoNameTeamAndTown();
        //        richTextBox1.Clear();
        //        if (foundTN != null)
        //        {
        //            richTextBox1.AppendText($"{foundTN.NameTeam}, {foundTN.TownTeam}, {foundTN.CountVict}, {foundTN.CountDef}, {foundTN.CountDraw}, {foundTN.CountGoalSC}, {foundTN.CountGoalCo}\n");
        //        }
        //    }
        //}

        private void viewAllInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Clubs.Count() == 0)
                {
                    clubService.AddClub();
                }
                var clubs = context.Clubs.ToList();
                richTextBox1.Clear();
                foreach (var club in clubs)
                {
                    richTextBox1.AppendText($"{club.Id}, {club.NameTeam}, {club.TownTeam}, {club.CountVict}, {club.CountDef}, {club.CountDraw}, {club.CountGoalSC}, {club.CountGoalCo}\n");
                }
            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club displayOneTown = clubService.DisplayInfoOneTeam();
                richTextBox1.Clear();
                if (displayOneTown != null)
                {
                    richTextBox1.AppendText($"{displayOneTown.NameTeam}, {displayOneTown.TownTeam}, {displayOneTown.CountVict}, {displayOneTown.CountDef}, {displayOneTown.CountDraw}, {displayOneTown.CountGoalSC}, {displayOneTown.CountGoalCo}\n");
                }
            }
        }

        private void displayTopTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club topTeam = clubService.DisplyInfoMostPoints();
                richTextBox1.Clear();
                if (topTeam != null)
                {
                    richTextBox1.AppendText($"{topTeam.NameTeam}, {topTeam.TownTeam}, {topTeam.CountVict}, {topTeam.CountDef}, {topTeam.CountDraw}, {topTeam.CountGoalSC}, {topTeam.CountGoalCo}\n");
                }
            }
        }

        private void displayTeamByMinPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club lowTeam = clubService.DisplayInfoMinPoints();
                richTextBox1.Clear();
                if (lowTeam != null)
                {
                    richTextBox1.AppendText($"{lowTeam.NameTeam}, {lowTeam.TownTeam}, {lowTeam.CountVict}, {lowTeam.CountDef}, {lowTeam.CountDraw}, {lowTeam.CountGoalSC}, {lowTeam.CountGoalCo}\n");
                }
            }
        }

        private void displayTop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                List<Club> top3PopularTeam = clubService.DisplayTop3PopularTeam();
                richTextBox1.Clear();
                foreach (var team in top3PopularTeam)
                {
                    richTextBox1.AppendText($"{team.NameTeam}, {team.TownTeam}, {team.CountVict}, {team.CountDef}, {team.CountDraw}, {team.CountGoalSC}, {team.CountGoalCo}\n");
                }
            }
        }

        private void dislpatLowTop3PopularTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                List<Club> neTop3PopularTeam = clubService.DisplayNeTop3PopularTeam();
                richTextBox1.Clear();
                foreach (var team in neTop3PopularTeam)
                {
                    richTextBox1.AppendText($"{team.NameTeam}, {team.TownTeam}, {team.CountVict}, {team.CountDef}, {team.CountDraw}, {team.CountGoalSC}, {team.CountGoalCo}\n");
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                var teams = context.Clubs.ToList();
                foreach (var teamR in teams)
                {
                    if (teamR.CountVict == 30)
                    {
                        teamR.CountVict = 35;
                        clubService.UpdateClub(teamR);
                    }
                    richTextBox1.Clear();
                    foreach (var team in teams)
                    {
                        richTextBox1.AppendText($"{team.NameTeam}, {team.TownTeam}, {team.CountVict}, {team.CountDef}, {team.CountDraw}, {team.CountGoalSC}, {team.CountGoalCo}\n");
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                var teams = context.Clubs.ToList();
                var teamToRemove = teams.FirstOrDefault(team => team.NameTeam == "Shahter");

                if (teamToRemove != null)
                {

                    richTextBox1.AppendText("Ви впевнені, що хочете видалити гру?");
                }

                richTextBox1.Clear();
                foreach (var team in teams)
                {
                    richTextBox1.AppendText($"{team.NameTeam}, {team.TownTeam}, {team.CountVict}, {team.CountDef}, {team.CountDraw}, {team.CountGoalSC}, {team.CountGoalCo}\n");
                }
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Clubs.Count() == 0)
                {
                    clubService.AddClub();
                }
                var clubs = context.Clubs.ToList();
                richTextBox1.Clear();
                foreach (var club in clubs)
                {
                    richTextBox1.AppendText($"{club.Id}, {club.NameTeam}, {club.TownTeam}, {club.CountVict}, {club.CountDef}, {club.CountDraw}, {club.CountGoalSC}, {club.CountGoalCo}\n");
                }
            }
        }
        private void displayAllInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Matches.Count() == 0)
                {
                    clubService.AddMatch();
                }
                var matches = context.Matches.ToList();
                richTextBox1.Clear();
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"{match.Id}, {match.Team1}, {match.Team2}, {match.CountGoalTeam1}, {match.CountGoalTeam2}\n");
                }
            }
        }

        private void displayDifferentsScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> goalDifference = clubService.DisplayScoredBetweenTeams();
            richTextBox1.Clear();
            foreach (var goal in goalDifference)
            {
                richTextBox1.AppendText($"{goal.Key}, {goal.Value}");
            }
        }

        private void displayInfoDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2001, 1, 1);
            List<Match>? matchesDate = clubService.DisplayInfoMatchDate(date);
            richTextBox1.Clear();
            if (matchesDate != null && matchesDate.Count > 0)
            {
                foreach (var match in matchesDate)
                {
                    richTextBox1.AppendText($"{match.Team1}, {match.Team2}, {match.CountGoalTeam1}, {match.CountGoalTeam2}");
                }
            }
        }

        private void displayAllMatchOneTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string teamName = "Shahter";
            List<Match>? matches = clubService.DisplayAllMatchOneTeam(teamName);
            richTextBox1.Clear();
            foreach (var match in matches)
            {
                richTextBox1.AppendText($"{match.Team1}, {match.Team2}, {match.CountGoalTeam1}, {match.CountGoalTeam2}");
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Matches.Count() == 0)
                {
                    clubService.AddMatch();
                }
                var matches = context.Matches.ToList();
                richTextBox1.Clear();
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"{match.Team1}, {match.Team2}, {match.CountGoalTeam1}, {match.CountGoalTeam2}");
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                var matches = context.Matches.ToList();
                foreach (var match in matches)
                {
                    if (match.CountGoalTeam1 == 6)
                    {
                        match.CountGoalTeam1 = 10;
                        clubService.UpdateMatch(match);
                    }
                }

                richTextBox1.Clear();
                foreach (var matchR in matches)
                {
                    richTextBox1.AppendText($"{matchR.Team1}, {matchR.Team2}, {matchR.CountGoalTeam1}, {matchR.CountGoalTeam2}\n");
                }
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                var matches = context.Matches.ToList();
                var matchToRemove = matches.FirstOrDefault(match => match.Team1 == "Shahter" && match.DateTime == new DateTime(2001, 1, 1));

                if (matchToRemove != null)
                {
                    richTextBox1.AppendText("Ви впевнені, що хочете видалити матч? (Так/Ні)\n");

                    var userResponse = Console.ReadLine();

                    //if (userResponse.Trim().ToLower() == "так")
                    //{
                    clubService.RemoveMatch(matchToRemove);

                    // Оновити список матчів після видалення
                    matches = context.Matches.ToList();
                    //}
                    //else
                    //{
                    //    richTextBox1.AppendText("Видалення скасовано.\n");
                    //}
                }
                else
                {
                    richTextBox1.AppendText("Матч для видалення не знайдено.\n");
                }

                richTextBox1.Clear();
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"{match.Team1}, {match.Team2}, {match.CountGoalTeam1}, {match.CountGoalTeam2}\n");
                }
            }
        }

        private void displayTop3BombardirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string teamName = "Shahter";
            List<Players>? players = clubService.DisplayTop3BombardirsOneTeam(teamName);

            richTextBox1.Clear();

            foreach (var player in players)
            {
                richTextBox1.AppendText($"{player.FirstName}, {player.CountGoals}\n");
            }
        }

        private void displayAllInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                if (context.Players.Count() == 0)
                {
                    clubService.AddPlayer();
                }
                var players = context.Players.ToList();
                richTextBox1.Clear();
                foreach (var player in players)
                {
                    richTextBox1.AppendText($"{player.Id}, {player.FirstName}, {player.Country}, {player.NameTeam}, {player.Position}, {player.CountGoals}\n");
                }
            }
        }

        private void displayTop3BombardirsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Players> playersTop3 = clubService.DisplayTop3Bombardirs();
            richTextBox1.Clear();
            foreach (var player in playersTop3)
            {
                richTextBox1.AppendText($"{player.Id}, {player.FirstName}, {player.Country}, {player.NameTeam}, {player.Position}, {player.CountGoals}\n");
            }
        }

        private void displayTheBestBombardirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Players? bestPlayer = clubService.DisplayTheBestPlayer();
            richTextBox1.Clear();
            if (bestPlayer != null)
            {
                richTextBox1.AppendText($"{bestPlayer.FirstName}, {bestPlayer.Country}, {bestPlayer.NameTeam}, {bestPlayer.Position}, {bestPlayer.CountGoals}\n");
            }
        }

        private void displayTop3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Club> top3Goals = clubService.DisplayTop3MostGoals();
            richTextBox1.Clear();
            foreach (var goal in top3Goals)
            {
                richTextBox1.AppendText($"{goal.NameTeam}, {goal.CountGoalSC}\n");
            }
        }

        private void displayTopTEamScoredGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club teamGoal = clubService.DisplayTopGoalsTeam();
            richTextBox1.Clear();
            if (teamGoal != null)
            {
                richTextBox1.AppendText($"{teamGoal.NameTeam}, {teamGoal.CountGoalSC}");
            }
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Club> minMissedGoal = clubService.DisplayMinMissedGoal();
            richTextBox1.Clear();
            foreach (var missedGoal in minMissedGoal)
            {
                richTextBox1.AppendText($"{missedGoal.NameTeam}, {missedGoal.CountGoalCo} \n");
            }
        }

        private void displayMinMissedGoalTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club minMissedGoalTeam = clubService.DisplayMinGoalMissedTeam();
            richTextBox1.Clear();
            if (minMissedGoalTeam != null)
            {
                richTextBox1.AppendText($"{minMissedGoalTeam.NameTeam}, {minMissedGoalTeam.CountGoalCo}");
            }
        }

        private void displayTeamMostScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club mostScored = clubService.DisplayTeamMostScored();
            richTextBox1.Clear();
            if (mostScored != null)
            {
                richTextBox1.AppendText($"{mostScored.NameTeam}, {mostScored.TownTeam}, {mostScored.CountVict}, {mostScored.CountDef}, {mostScored.CountDraw}, {mostScored.CountGoalSC}, {mostScored.CountGoalCo}\n");
            }
        }

        private void displayTeamLowScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club lowScored = clubService.DisplayTeamLowScored();
            richTextBox1.Clear();
            if (lowScored != null)
            {
                richTextBox1.AppendText($"{lowScored.NameTeam}, {lowScored.TownTeam}, {lowScored.CountVict}, {lowScored.CountDef}, {lowScored.CountDraw}, {lowScored.CountGoalSC}, {lowScored.CountGoalCo}\n");
            }
        }
    }
}