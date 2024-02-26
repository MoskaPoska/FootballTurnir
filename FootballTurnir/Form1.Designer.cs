namespace FootballTurnir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            menuStrip1 = new MenuStrip();
            clubToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            findInfoNameTeamToolStripMenuItem = new ToolStripMenuItem();
            findInfoNameTownToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewAllInfoToolStripMenuItem = new ToolStripMenuItem();
            displayToolStripMenuItem = new ToolStripMenuItem();
            displayTopTeamToolStripMenuItem = new ToolStripMenuItem();
            displayTeamByMinPointsToolStripMenuItem = new ToolStripMenuItem();
            displayTop3ToolStripMenuItem = new ToolStripMenuItem();
            dislpatLowTop3PopularTeamToolStripMenuItem = new ToolStripMenuItem();
            displayTop3ToolStripMenuItem1 = new ToolStripMenuItem();
            displayTopTEamScoredGoalToolStripMenuItem = new ToolStripMenuItem();
            displayToolStripMenuItem1 = new ToolStripMenuItem();
            displayMinMissedGoalTeamToolStripMenuItem = new ToolStripMenuItem();
            displayTeamMostScoredToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            matchToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            displayAllInfoToolStripMenuItem = new ToolStripMenuItem();
            displayDifferentsScoredToolStripMenuItem = new ToolStripMenuItem();
            displayInfoDateToolStripMenuItem = new ToolStripMenuItem();
            displayAllMatchOneTeamToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem2 = new ToolStripMenuItem();
            displayTop3BombardirsToolStripMenuItem = new ToolStripMenuItem();
            displayAllInfoToolStripMenuItem1 = new ToolStripMenuItem();
            displayTop3BombardirsToolStripMenuItem1 = new ToolStripMenuItem();
            displayTheBestBombardirToolStripMenuItem = new ToolStripMenuItem();
            difToolStripMenuItem = new ToolStripMenuItem();
            displayTeamLowScoredToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(220, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(220, 264);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(322, 184);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(296, 182);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clubToolStripMenuItem, matchToolStripMenuItem, playersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // clubToolStripMenuItem
            // 
            clubToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, viewToolStripMenuItem, addToolStripMenuItem, removeToolStripMenuItem, deleteToolStripMenuItem });
            clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            clubToolStripMenuItem.Size = new Size(44, 20);
            clubToolStripMenuItem.Text = "Club";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findInfoNameTeamToolStripMenuItem, findInfoNameTownToolStripMenuItem });
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(180, 22);
            findToolStripMenuItem.Text = "Find";
            // 
            // findInfoNameTeamToolStripMenuItem
            // 
            findInfoNameTeamToolStripMenuItem.Name = "findInfoNameTeamToolStripMenuItem";
            findInfoNameTeamToolStripMenuItem.Size = new Size(178, 22);
            findInfoNameTeamToolStripMenuItem.Text = "FindInfoNameTeam";
            findInfoNameTeamToolStripMenuItem.Click += findInfoNameTeamToolStripMenuItem_Click;
            // 
            // findInfoNameTownToolStripMenuItem
            // 
            findInfoNameTownToolStripMenuItem.Name = "findInfoNameTownToolStripMenuItem";
            findInfoNameTownToolStripMenuItem.Size = new Size(178, 22);
            findInfoNameTownToolStripMenuItem.Text = "FindInfoNameTown";
            findInfoNameTownToolStripMenuItem.Click += findInfoNameTownToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllInfoToolStripMenuItem, displayToolStripMenuItem, displayTopTeamToolStripMenuItem, displayTeamByMinPointsToolStripMenuItem, displayTop3ToolStripMenuItem, dislpatLowTop3PopularTeamToolStripMenuItem, displayTop3ToolStripMenuItem1, displayTopTEamScoredGoalToolStripMenuItem, displayToolStripMenuItem1, displayMinMissedGoalTeamToolStripMenuItem, displayTeamMostScoredToolStripMenuItem, displayTeamLowScoredToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(180, 22);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewAllInfoToolStripMenuItem
            // 
            viewAllInfoToolStripMenuItem.Name = "viewAllInfoToolStripMenuItem";
            viewAllInfoToolStripMenuItem.Size = new Size(247, 22);
            viewAllInfoToolStripMenuItem.Text = "DisplayAllInfo";
            viewAllInfoToolStripMenuItem.Click += viewAllInfoToolStripMenuItem_Click;
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new Size(247, 22);
            displayToolStripMenuItem.Text = "DisplayInfoOneTeam";
            displayToolStripMenuItem.Click += displayToolStripMenuItem_Click;
            // 
            // displayTopTeamToolStripMenuItem
            // 
            displayTopTeamToolStripMenuItem.Name = "displayTopTeamToolStripMenuItem";
            displayTopTeamToolStripMenuItem.Size = new Size(247, 22);
            displayTopTeamToolStripMenuItem.Text = "DisplayTeamByMaxPoints";
            displayTopTeamToolStripMenuItem.Click += displayTopTeamToolStripMenuItem_Click;
            // 
            // displayTeamByMinPointsToolStripMenuItem
            // 
            displayTeamByMinPointsToolStripMenuItem.Name = "displayTeamByMinPointsToolStripMenuItem";
            displayTeamByMinPointsToolStripMenuItem.Size = new Size(247, 22);
            displayTeamByMinPointsToolStripMenuItem.Text = "DisplayTeamByMinPoints";
            displayTeamByMinPointsToolStripMenuItem.Click += displayTeamByMinPointsToolStripMenuItem_Click;
            // 
            // displayTop3ToolStripMenuItem
            // 
            displayTop3ToolStripMenuItem.Name = "displayTop3ToolStripMenuItem";
            displayTop3ToolStripMenuItem.Size = new Size(247, 22);
            displayTop3ToolStripMenuItem.Text = "DisplayTop3PopularTeam";
            displayTop3ToolStripMenuItem.Click += displayTop3ToolStripMenuItem_Click;
            // 
            // dislpatLowTop3PopularTeamToolStripMenuItem
            // 
            dislpatLowTop3PopularTeamToolStripMenuItem.Name = "dislpatLowTop3PopularTeamToolStripMenuItem";
            dislpatLowTop3PopularTeamToolStripMenuItem.Size = new Size(247, 22);
            dislpatLowTop3PopularTeamToolStripMenuItem.Text = "DislpatLowTop3PopularTeam";
            dislpatLowTop3PopularTeamToolStripMenuItem.Click += dislpatLowTop3PopularTeamToolStripMenuItem_Click;
            // 
            // displayTop3ToolStripMenuItem1
            // 
            displayTop3ToolStripMenuItem1.Name = "displayTop3ToolStripMenuItem1";
            displayTop3ToolStripMenuItem1.Size = new Size(247, 22);
            displayTop3ToolStripMenuItem1.Text = "DisplayTop3MostGoals";
            displayTop3ToolStripMenuItem1.Click += displayTop3ToolStripMenuItem1_Click;
            // 
            // displayTopTEamScoredGoalToolStripMenuItem
            // 
            displayTopTEamScoredGoalToolStripMenuItem.Name = "displayTopTEamScoredGoalToolStripMenuItem";
            displayTopTEamScoredGoalToolStripMenuItem.Size = new Size(247, 22);
            displayTopTEamScoredGoalToolStripMenuItem.Text = "DisplayTopTEamScoredGoal";
            displayTopTEamScoredGoalToolStripMenuItem.Click += displayTopTEamScoredGoalToolStripMenuItem_Click;
            // 
            // displayToolStripMenuItem1
            // 
            displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            displayToolStripMenuItem1.Size = new Size(247, 22);
            displayToolStripMenuItem1.Text = "DisplayTop3TeamMinMissedGoal";
            displayToolStripMenuItem1.Click += displayToolStripMenuItem1_Click;
            // 
            // displayMinMissedGoalTeamToolStripMenuItem
            // 
            displayMinMissedGoalTeamToolStripMenuItem.Name = "displayMinMissedGoalTeamToolStripMenuItem";
            displayMinMissedGoalTeamToolStripMenuItem.Size = new Size(247, 22);
            displayMinMissedGoalTeamToolStripMenuItem.Text = "DisplayMinMissedGoalTeam";
            displayMinMissedGoalTeamToolStripMenuItem.Click += displayMinMissedGoalTeamToolStripMenuItem_Click;
            // 
            // displayTeamMostScoredToolStripMenuItem
            // 
            displayTeamMostScoredToolStripMenuItem.Name = "displayTeamMostScoredToolStripMenuItem";
            displayTeamMostScoredToolStripMenuItem.Size = new Size(247, 22);
            displayTeamMostScoredToolStripMenuItem.Text = "DisplayTeamMostScored";
            displayTeamMostScoredToolStripMenuItem.Click += displayTeamMostScoredToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(180, 22);
            removeToolStripMenuItem.Text = "Update";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // matchToolStripMenuItem
            // 
            matchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, addToolStripMenuItem1, updateToolStripMenuItem, removeToolStripMenuItem1 });
            matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            matchToolStripMenuItem.Size = new Size(53, 20);
            matchToolStripMenuItem.Text = "Match";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { displayAllInfoToolStripMenuItem, displayDifferentsScoredToolStripMenuItem, displayInfoDateToolStripMenuItem, displayAllMatchOneTeamToolStripMenuItem });
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(112, 22);
            viewToolStripMenuItem1.Text = "View";
            // 
            // displayAllInfoToolStripMenuItem
            // 
            displayAllInfoToolStripMenuItem.Name = "displayAllInfoToolStripMenuItem";
            displayAllInfoToolStripMenuItem.Size = new Size(210, 22);
            displayAllInfoToolStripMenuItem.Text = "DisplayAllInfo";
            displayAllInfoToolStripMenuItem.Click += displayAllInfoToolStripMenuItem_Click;
            // 
            // displayDifferentsScoredToolStripMenuItem
            // 
            displayDifferentsScoredToolStripMenuItem.Name = "displayDifferentsScoredToolStripMenuItem";
            displayDifferentsScoredToolStripMenuItem.Size = new Size(210, 22);
            displayDifferentsScoredToolStripMenuItem.Text = "DisplayDifferentsScored";
            displayDifferentsScoredToolStripMenuItem.Click += displayDifferentsScoredToolStripMenuItem_Click;
            // 
            // displayInfoDateToolStripMenuItem
            // 
            displayInfoDateToolStripMenuItem.Name = "displayInfoDateToolStripMenuItem";
            displayInfoDateToolStripMenuItem.Size = new Size(210, 22);
            displayInfoDateToolStripMenuItem.Text = "DisplayInfoDate";
            displayInfoDateToolStripMenuItem.Click += displayInfoDateToolStripMenuItem_Click;
            // 
            // displayAllMatchOneTeamToolStripMenuItem
            // 
            displayAllMatchOneTeamToolStripMenuItem.Name = "displayAllMatchOneTeamToolStripMenuItem";
            displayAllMatchOneTeamToolStripMenuItem.Size = new Size(210, 22);
            displayAllMatchOneTeamToolStripMenuItem.Text = "DisplayAllMatchOneTeam";
            displayAllMatchOneTeamToolStripMenuItem.Click += displayAllMatchOneTeamToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(112, 22);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(112, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(112, 22);
            removeToolStripMenuItem1.Text = "Delete";
            removeToolStripMenuItem1.Click += removeToolStripMenuItem1_Click;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem2 });
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(56, 20);
            playersToolStripMenuItem.Text = "Players";
            // 
            // viewToolStripMenuItem2
            // 
            viewToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { displayTop3BombardirsToolStripMenuItem, displayAllInfoToolStripMenuItem1, displayTop3BombardirsToolStripMenuItem1, displayTheBestBombardirToolStripMenuItem });
            viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            viewToolStripMenuItem2.Size = new Size(99, 22);
            viewToolStripMenuItem2.Text = "View";
            // 
            // displayTop3BombardirsToolStripMenuItem
            // 
            displayTop3BombardirsToolStripMenuItem.Name = "displayTop3BombardirsToolStripMenuItem";
            displayTop3BombardirsToolStripMenuItem.Size = new Size(248, 22);
            displayTop3BombardirsToolStripMenuItem.Text = "DisplayTop3BombardirsOneTeam";
            displayTop3BombardirsToolStripMenuItem.Click += displayTop3BombardirsToolStripMenuItem_Click;
            // 
            // displayAllInfoToolStripMenuItem1
            // 
            displayAllInfoToolStripMenuItem1.Name = "displayAllInfoToolStripMenuItem1";
            displayAllInfoToolStripMenuItem1.Size = new Size(248, 22);
            displayAllInfoToolStripMenuItem1.Text = "DisplayAllInfo";
            displayAllInfoToolStripMenuItem1.Click += displayAllInfoToolStripMenuItem1_Click;
            // 
            // displayTop3BombardirsToolStripMenuItem1
            // 
            displayTop3BombardirsToolStripMenuItem1.Name = "displayTop3BombardirsToolStripMenuItem1";
            displayTop3BombardirsToolStripMenuItem1.Size = new Size(248, 22);
            displayTop3BombardirsToolStripMenuItem1.Text = "DisplayTop3Bombardirs";
            displayTop3BombardirsToolStripMenuItem1.Click += displayTop3BombardirsToolStripMenuItem1_Click;
            // 
            // displayTheBestBombardirToolStripMenuItem
            // 
            displayTheBestBombardirToolStripMenuItem.Name = "displayTheBestBombardirToolStripMenuItem";
            displayTheBestBombardirToolStripMenuItem.Size = new Size(248, 22);
            displayTheBestBombardirToolStripMenuItem.Text = "DisplayTheBestBombardir";
            displayTheBestBombardirToolStripMenuItem.Click += displayTheBestBombardirToolStripMenuItem_Click;
            // 
            // difToolStripMenuItem
            // 
            difToolStripMenuItem.Name = "difToolStripMenuItem";
            difToolStripMenuItem.Size = new Size(32, 19);
            // 
            // displayTeamLowScoredToolStripMenuItem
            // 
            displayTeamLowScoredToolStripMenuItem.Name = "displayTeamLowScoredToolStripMenuItem";
            displayTeamLowScoredToolStripMenuItem.Size = new Size(247, 22);
            displayTeamLowScoredToolStripMenuItem.Text = "DisplayTeamLowScored";
            displayTeamLowScoredToolStripMenuItem.Click += displayTeamLowScoredToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clubToolStripMenuItem;
        private ToolStripMenuItem matchToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findInfoNameTeamToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem findInfoNameTownToolStripMenuItem;
        private ToolStripMenuItem viewAllInfoToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem displayTopTeamToolStripMenuItem;
        private ToolStripMenuItem displayTeamByMinPointsToolStripMenuItem;
        private ToolStripMenuItem displayTop3ToolStripMenuItem;
        private ToolStripMenuItem dislpatLowTop3PopularTeamToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem difToolStripMenuItem;
        private ToolStripMenuItem displayAllInfoToolStripMenuItem;
        private ToolStripMenuItem displayDifferentsScoredToolStripMenuItem;
        private ToolStripMenuItem displayInfoDateToolStripMenuItem;
        private ToolStripMenuItem displayAllMatchOneTeamToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem2;
        private ToolStripMenuItem displayTop3BombardirsToolStripMenuItem;
        private ToolStripMenuItem displayAllInfoToolStripMenuItem1;
        private ToolStripMenuItem displayTop3BombardirsToolStripMenuItem1;
        private ToolStripMenuItem displayTheBestBombardirToolStripMenuItem;
        private ToolStripMenuItem displayTop3ToolStripMenuItem1;
        private ToolStripMenuItem displayTopTEamScoredGoalToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem1;
        private ToolStripMenuItem displayMinMissedGoalTeamToolStripMenuItem;
        private ToolStripMenuItem displayTeamMostScoredToolStripMenuItem;
        private ToolStripMenuItem displayTeamLowScoredToolStripMenuItem;
    }
}