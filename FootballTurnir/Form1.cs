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
        public Form1(FootballTurnirContext context)
        {
            InitializeComponent();
            clubService = new ClubService(context);
            groupBox1.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();

        }
        private void findInfoNameTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club? foundClub = clubService.FindInfoNameTeam();
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


                richTextBox1.Font = new Font("Courier New", 10);


                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");



                foreach (var club in clubs)
                {
                    richTextBox1.AppendText($"|{club.Id,-5}|{club.NameTeam,-15}|{club.TownTeam,-15}|{club.CountVict,-9}|{club.CountDef,-8}|{club.CountDraw,-9}|{club.CountGoalSC,-11}|{club.CountGoalCo,-10}\n");
                }
            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club displayOneTown = clubService.DisplayInfoOneTeam();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
                if (displayOneTown != null)
                {
                    richTextBox1.AppendText($"|{displayOneTown.Id,-5}|{displayOneTown.NameTeam,-15}|{displayOneTown.TownTeam,-15}|{displayOneTown.CountVict,-9}|{displayOneTown.CountDef,-8}|{displayOneTown.CountDraw,-9}|{displayOneTown.CountGoalSC,-11}|{displayOneTown.CountGoalCo,-10}\n");
                }
            }
        }

        private void displayTopTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club topTeam = clubService.DisplyInfoMostPoints();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
                if (topTeam != null)
                {
                    richTextBox1.AppendText($"|{topTeam.Id,-5}|{topTeam.NameTeam,-15}|{topTeam.TownTeam,-15}|{topTeam.CountVict,-9}|{topTeam.CountDef,-8}|{topTeam.CountDraw,-9}|{topTeam.CountGoalSC,-11}|{topTeam.CountGoalCo,10}\n");
                }
            }
        }

        private void displayTeamByMinPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                Club lowTeam = clubService.DisplayInfoMinPoints();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                if (lowTeam != null)
                {
                    richTextBox1.AppendText($"|{lowTeam.Id,-5}|{lowTeam.NameTeam,-15}|{lowTeam.TownTeam,-15}|{lowTeam.CountVict,-9}|{lowTeam.CountDef,-8}|{lowTeam.CountDraw,-9}|{lowTeam.CountGoalSC,-11}|{lowTeam.CountGoalCo,-10}\n");
                }
            }
        }

        private void displayTop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                List<Club> top3PopularTeam = clubService.DisplayTop3PopularTeam();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                foreach (var team in top3PopularTeam)
                {
                    richTextBox1.AppendText($"|{team.Id,-5}|{team.NameTeam,-15}|{team.TownTeam,-15}|{team.CountVict,-9}|{team.CountDef,-8}|{team.CountDraw,-9}|{team.CountGoalSC,-11}|{team.CountGoalCo,-10}\n");
                }
            }
        }

        private void dislpatLowTop3PopularTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FootballTurnirContext())
            {
                List<Club> neTop3PopularTeam = clubService.DisplayNeTop3PopularTeam();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                foreach (var team in neTop3PopularTeam)
                {
                    richTextBox1.AppendText($"|{team.Id,-5}|{team.NameTeam,-15}|{team.TownTeam,-15}|{team.CountVict,-9}|{team.CountDef,-8}|{team.CountDraw,-9}|{team.CountGoalSC,-11}|{team.CountGoalCo,-10}\n");
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
                    richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                    foreach (var team in teams)
                    {
                        richTextBox1.AppendText($"|{team.Id,-5}|{team.NameTeam,-15}|{team.TownTeam,-15}|{team.CountVict,-9}|{team.CountDef,-8}|{team.CountDraw,-9}|{team.CountGoalSC,-11}|{team.CountGoalCo,-10}\n");
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

                //if (teamToRemove != null)
                //{

                //    richTextBox1.AppendText("Ви впевнені, що хочете видалити гру?");
                //}
                clubService.RemoveClub(teamToRemove);
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                foreach (var team in teams)
                {
                    richTextBox1.AppendText($"|{team.Id,-5}|{team.NameTeam,-15}|{team.TownTeam,-15}|{team.CountVict,-9}|{team.CountDef,-8}|{team.CountDraw,-9}|{team.CountGoalSC,-11}|{team.CountGoalCo,-10}\n");
                }
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = true;
            using (var context = new FootballTurnirContext())
            {

                if (context.Clubs.Count() == 0)
                {
                    clubService.AddClub();
                }
                var clubs = context.Clubs.ToList();
                richTextBox1.Clear();
                richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-11}|{"CountGoalCo",-10}\n");
                foreach (var club in clubs)
                {
                    richTextBox1.AppendText($"|{club.Id,-5}|{club.NameTeam,-15}|{club.TownTeam,-15}|{club.CountVict,-9}|{club.CountDef,-8}|{club.CountDraw,-9}|{club.CountGoalSC,-11}|{club.CountGoalCo,-10}\n");
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
                richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"|{match.Id,-5}|{match.Team1,-15}|{match.Team2,-15}|{match.CountGoalTeam1,-14}|{match.CountGoalTeam2,-14}|\n");
                }
            }
        }

        private void displayDifferentsScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> goalDifference = clubService.DisplayScoredBetweenTeams();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
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
            richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
            if (matchesDate != null && matchesDate.Count > 0)
            {
                foreach (var match in matchesDate)
                {
                    richTextBox1.AppendText($"|{match.Id,-5}|{match.Team1,-15}|{match.Team2,-15}|{match.CountGoalTeam1,-14}|{match.CountGoalTeam2,-14}|\n");
                }
            }
        }

        private void displayAllMatchOneTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string teamName = "Shahter";
            List<Match>? matches = clubService.DisplayAllMatchOneTeam(teamName);
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
            foreach (var match in matches)
            {
                richTextBox1.AppendText($"|{match.Id,-5}|{match.Team1,-15}|{match.Team2,-15}|{match.CountGoalTeam1,-14}|{match.CountGoalTeam2,-14}|\n");
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
                richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"|{match.Id,-5}|{match.Team1,-15}|{match.Team2,-15}|{match.CountGoalTeam1,-14}|{match.CountGoalTeam2,-14}|\n");
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
                richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
                foreach (var matchR in matches)
                {
                    richTextBox1.AppendText($"|{matchR.Id,-5}|{matchR.Team1,-15}|{matchR.Team2,-15}|{matchR.CountGoalTeam1,-14}|{matchR.CountGoalTeam2,-14}|\n");
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
                    richTextBox1.AppendText("Ви впевнені, що хочете видалити матч? (Yes/No)\n");

                    var userResponse = Console.ReadLine();

                    //if (userResponse.Trim().ToLower() == "Yes")
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
                richTextBox1.AppendText($"|{"Id",-5}|{"Team1",-15}|{"Team2",-15}|{"CountGoalTeam1",-8}|{"CountGoalTeam2",-8}|\n");
                foreach (var match in matches)
                {
                    richTextBox1.AppendText($"|{match.Id,-5}|{match.Team1,-15}|{match.Team2,-15}|{match.CountGoalTeam1,-14}|{match.CountGoalTeam2,-14}|\n");
                }
            }
        }

        private void displayTop3BombardirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string teamName = "Shahter";
            List<Players>? players = clubService.DisplayTop3BombardirsOneTeam(teamName);

            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"FirstName",-15}|{"CountGoals",-8}\n");
            foreach (var player in players)
            {
                richTextBox1.AppendText($"|{player.FirstName,-15}|{player.CountGoals,-9}|\n");
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
                richTextBox1.AppendText($"|{"Id",-5}|{"FirstName",-15}|{"Country",-9}|{"NameTeam",-11}|{"Position",-10}|{"CountGoals",-9}|\n");
                foreach (var player in players)
                {
                    richTextBox1.AppendText($"|{player.Id,-5}|{player.FirstName,-15}|{player.Country,-9}|{player.NameTeam,-11}|{player.Position,-10}|{player.CountGoals,-10}|\n");
                }
            }
        }

        private void displayTop3BombardirsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Players> playersTop3 = clubService.DisplayTop3Bombardirs();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"FirstName",-15}|{"Country",-9}|{"NameTeam",-11}|{"Position",-10}|{"CountGoals",-9}|\n");
            foreach (var player in playersTop3)
            {
                richTextBox1.AppendText($"|{player.Id,-5}|{player.FirstName,-15}|{player.Country,-9}|{player.NameTeam,-11}|{player.Position,-10}|{player.CountGoals,-10}|\n");
            }
        }

        private void displayTheBestBombardirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Players? bestPlayer = clubService.DisplayTheBestPlayer();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"FirstName",-15}|{"Country",-9}|{"NameTeam",-11}|{"Position",-10}|{"CountGoals",-9}|\n");
            if (bestPlayer != null)
            {
                richTextBox1.AppendText($"|{bestPlayer.Id,-5}|{bestPlayer.FirstName,-15}|{bestPlayer.Country,-9}|{bestPlayer.NameTeam,-11}|{bestPlayer.Position,-10}|{bestPlayer.CountGoals,-10}|\n");
            }
        }

        private void displayTop3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Club> top3Goals = clubService.DisplayTop3MostGoals();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            foreach (var goal in top3Goals)
            {
                richTextBox1.AppendText($"|{goal.Id,-5}|{goal.NameTeam,-15}|{goal.TownTeam,-15}|{goal.CountVict,-9}|{goal.CountDef,-8}|{goal.CountDraw,-9}|{goal.CountGoalSC,-11}|{goal.CountGoalCo,-10}\n");
            }
        }

        private void displayTopTEamScoredGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club teamGoal = clubService.DisplayTopGoalsTeam();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            if (teamGoal != null)
            {
                richTextBox1.AppendText($"|{teamGoal.Id,-5}|{teamGoal.NameTeam,-15}|{teamGoal.TownTeam,-15}|{teamGoal.CountVict,-9}|{teamGoal.CountDef,-8}|{teamGoal.CountDraw,-9}|{teamGoal.CountGoalSC,-11}|{teamGoal.CountGoalCo,-10}\n");
            }
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Club> minMissedGoal = clubService.DisplayMinMissedGoal();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            foreach (var missedGoal in minMissedGoal)
            {
                richTextBox1.AppendText($"|{missedGoal.Id,-5}|{missedGoal.NameTeam,-15}|{missedGoal.TownTeam,-15}|{missedGoal.CountVict,-9}|{missedGoal.CountDef,-8}|{missedGoal.CountDraw,-9}|{missedGoal.CountGoalSC,-11}|{missedGoal.CountGoalCo,-10}\n");
            }
        }

        private void displayMinMissedGoalTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club minMissedGoalTeam = clubService.DisplayMinGoalMissedTeam();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            if (minMissedGoalTeam != null)
            {
                richTextBox1.AppendText($"|{minMissedGoalTeam.Id,-5}|{minMissedGoalTeam.NameTeam,-15}|{minMissedGoalTeam.TownTeam,-15}|{minMissedGoalTeam.CountVict,-9}|{minMissedGoalTeam.CountDef,-8}|{minMissedGoalTeam.CountDraw,-9}|{minMissedGoalTeam.CountGoalSC,-11}|{minMissedGoalTeam.CountGoalCo,-10}\n");
            }
        }

        private void displayTeamMostScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club mostScored = clubService.DisplayTeamMostScored();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            if (mostScored != null)
            {
                richTextBox1.AppendText($"|{mostScored.Id,-5}|{mostScored.NameTeam,-15}|{mostScored.TownTeam,-15}|{mostScored.CountVict,-9}|{mostScored.CountDef,-8}|{mostScored.CountDraw,-9}|{mostScored.CountGoalSC,-11}|{mostScored.CountGoalCo,-10}\n");
            }
        }

        private void displayTeamLowScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Club lowScored = clubService.DisplayTeamLowScored();
            richTextBox1.Clear();
            richTextBox1.AppendText($"|{"Id",-5}|{"NameTeam",-15}|{"TownTeam",-15}|{"CountVict",-8}|{"CountDef",-8}|{"CountDraw",-8}|{"CountGoalSC",-10}|{"CountGoalCo",-10}\n");
            if (lowScored != null)
            {
                richTextBox1.AppendText($"|{lowScored.Id,-5}|{lowScored.NameTeam,-15}|{lowScored.TownTeam,-15}|{lowScored.CountVict,-9}|{lowScored.CountDef,-8}|{lowScored.CountDraw,-9}|{lowScored.CountGoalSC,-11}|{lowScored.CountGoalCo,-10}\n");
            }
        }
        // Отображает по умолчанию Слабс
        private void Form1_Load_1(object sender, EventArgs e)
        {
            viewAllInfoToolStripMenuItem_Click(sender, e);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (var context = new FootballTurnirContext())
        //    {
        //        string name = textBox1.Text;
        //        string town = textBox2.Text;
        //         countVict = domainUpDown1;
        //        // Отримати інші дані з інших TextBox

        //        Club newClub = new Club()
        //        {
        //            NameTeam = name,
        //            TownTeam = town,
        //            // Встановіть інші властивості клубу відповідно до даних з TextBox
        //        };

        //        context.Clubs.Add(newClub);
        //        context.SaveChanges();
        //    }
        //    textBox1.Clear();
        //    textBox2.Clear();

        //}


    }
}