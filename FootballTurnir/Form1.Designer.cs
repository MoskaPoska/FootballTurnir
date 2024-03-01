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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            menuStrip1 = new MenuStrip();
            clubToolStripMenuItem = new ToolStripMenuItem();
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
            displayTeamLowScoredToolStripMenuItem = new ToolStripMenuItem();
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
            findInfoNameTeamToolStripMenuItem = new ToolStripMenuItem();
            findInfoNameTownToolStripMenuItem = new ToolStripMenuItem();
            difToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openFileDialog1 = new OpenFileDialog();
            fontDialog2 = new FontDialog();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 218);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 220);
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
            clubToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, addToolStripMenuItem, removeToolStripMenuItem, deleteToolStripMenuItem });
            clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            clubToolStripMenuItem.Size = new Size(44, 20);
            clubToolStripMenuItem.Text = "Club";
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
            viewAllInfoToolStripMenuItem.Size = new Size(444, 22);
            viewAllInfoToolStripMenuItem.Text = "Отобразить всю информацию";
            viewAllInfoToolStripMenuItem.Click += viewAllInfoToolStripMenuItem_Click;
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new Size(444, 22);
            displayToolStripMenuItem.Text = "Отобразить информацию конкретной команды";
            displayToolStripMenuItem.Click += displayToolStripMenuItem_Click;
            // 
            // displayTopTeamToolStripMenuItem
            // 
            displayTopTeamToolStripMenuItem.Name = "displayTopTeamToolStripMenuItem";
            displayTopTeamToolStripMenuItem.Size = new Size(444, 22);
            displayTopTeamToolStripMenuItem.Text = "Отобразить команду имеющую максимальноек количество очков";
            displayTopTeamToolStripMenuItem.Click += displayTopTeamToolStripMenuItem_Click;
            // 
            // displayTeamByMinPointsToolStripMenuItem
            // 
            displayTeamByMinPointsToolStripMenuItem.Name = "displayTeamByMinPointsToolStripMenuItem";
            displayTeamByMinPointsToolStripMenuItem.Size = new Size(444, 22);
            displayTeamByMinPointsToolStripMenuItem.Text = "Отобразить команду имеющую минимальное количество очков";
            displayTeamByMinPointsToolStripMenuItem.Click += displayTeamByMinPointsToolStripMenuItem_Click;
            // 
            // displayTop3ToolStripMenuItem
            // 
            displayTop3ToolStripMenuItem.Name = "displayTop3ToolStripMenuItem";
            displayTop3ToolStripMenuItem.Size = new Size(444, 22);
            displayTop3ToolStripMenuItem.Text = "Отобразить Топ 3 популярные команды";
            displayTop3ToolStripMenuItem.Click += displayTop3ToolStripMenuItem_Click;
            // 
            // dislpatLowTop3PopularTeamToolStripMenuItem
            // 
            dislpatLowTop3PopularTeamToolStripMenuItem.Name = "dislpatLowTop3PopularTeamToolStripMenuItem";
            dislpatLowTop3PopularTeamToolStripMenuItem.Size = new Size(444, 22);
            dislpatLowTop3PopularTeamToolStripMenuItem.Text = "Отобразить Топ 3 не популярные команды";
            dislpatLowTop3PopularTeamToolStripMenuItem.Click += dislpatLowTop3PopularTeamToolStripMenuItem_Click;
            // 
            // displayTop3ToolStripMenuItem1
            // 
            displayTop3ToolStripMenuItem1.Name = "displayTop3ToolStripMenuItem1";
            displayTop3ToolStripMenuItem1.Size = new Size(444, 22);
            displayTop3ToolStripMenuItem1.Text = "Отобразить Топ 3 больше всего забитых голов";
            displayTop3ToolStripMenuItem1.Click += displayTop3ToolStripMenuItem1_Click;
            // 
            // displayTopTEamScoredGoalToolStripMenuItem
            // 
            displayTopTEamScoredGoalToolStripMenuItem.Name = "displayTopTEamScoredGoalToolStripMenuItem";
            displayTopTEamScoredGoalToolStripMenuItem.Size = new Size(444, 22);
            displayTopTEamScoredGoalToolStripMenuItem.Text = "Отобразить лучшую команду по забитым голам";
            displayTopTEamScoredGoalToolStripMenuItem.Click += displayTopTEamScoredGoalToolStripMenuItem_Click;
            // 
            // displayToolStripMenuItem1
            // 
            displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            displayToolStripMenuItem1.Size = new Size(444, 22);
            displayToolStripMenuItem1.Text = "Отобразить Топ 3 команды по минимально пропущенным голам";
            displayToolStripMenuItem1.Click += displayToolStripMenuItem1_Click;
            // 
            // displayMinMissedGoalTeamToolStripMenuItem
            // 
            displayMinMissedGoalTeamToolStripMenuItem.Name = "displayMinMissedGoalTeamToolStripMenuItem";
            displayMinMissedGoalTeamToolStripMenuItem.Size = new Size(444, 22);
            displayMinMissedGoalTeamToolStripMenuItem.Text = "Отобразить конмаду по минимально пропущенным голам";
            displayMinMissedGoalTeamToolStripMenuItem.Click += displayMinMissedGoalTeamToolStripMenuItem_Click;
            // 
            // displayTeamMostScoredToolStripMenuItem
            // 
            displayTeamMostScoredToolStripMenuItem.Name = "displayTeamMostScoredToolStripMenuItem";
            displayTeamMostScoredToolStripMenuItem.Size = new Size(444, 22);
            displayTeamMostScoredToolStripMenuItem.Text = "Отобразить команду имеющую наибольшее количество очков";
            displayTeamMostScoredToolStripMenuItem.Click += displayTeamMostScoredToolStripMenuItem_Click;
            // 
            // displayTeamLowScoredToolStripMenuItem
            // 
            displayTeamLowScoredToolStripMenuItem.Name = "displayTeamLowScoredToolStripMenuItem";
            displayTeamLowScoredToolStripMenuItem.Size = new Size(444, 22);
            displayTeamLowScoredToolStripMenuItem.Text = "Отобразить команду имеющую наименьшее количсетво очков ";
            displayTeamLowScoredToolStripMenuItem.Click += displayTeamLowScoredToolStripMenuItem_Click;
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
            viewToolStripMenuItem1.Size = new Size(180, 22);
            viewToolStripMenuItem1.Text = "View";
            // 
            // displayAllInfoToolStripMenuItem
            // 
            displayAllInfoToolStripMenuItem.Name = "displayAllInfoToolStripMenuItem";
            displayAllInfoToolStripMenuItem.Size = new Size(378, 22);
            displayAllInfoToolStripMenuItem.Text = "Отобразить всю информацию";
            displayAllInfoToolStripMenuItem.Click += displayAllInfoToolStripMenuItem_Click;
            // 
            // displayDifferentsScoredToolStripMenuItem
            // 
            displayDifferentsScoredToolStripMenuItem.Name = "displayDifferentsScoredToolStripMenuItem";
            displayDifferentsScoredToolStripMenuItem.Size = new Size(378, 22);
            displayDifferentsScoredToolStripMenuItem.Text = "Отобразить разницу в счете между командами";
            displayDifferentsScoredToolStripMenuItem.Click += displayDifferentsScoredToolStripMenuItem_Click;
            // 
            // displayInfoDateToolStripMenuItem
            // 
            displayInfoDateToolStripMenuItem.Name = "displayInfoDateToolStripMenuItem";
            displayInfoDateToolStripMenuItem.Size = new Size(378, 22);
            displayInfoDateToolStripMenuItem.Text = "Отобразить информацию про матч в конкретный день";
            displayInfoDateToolStripMenuItem.Click += displayInfoDateToolStripMenuItem_Click;
            // 
            // displayAllMatchOneTeamToolStripMenuItem
            // 
            displayAllMatchOneTeamToolStripMenuItem.Name = "displayAllMatchOneTeamToolStripMenuItem";
            displayAllMatchOneTeamToolStripMenuItem.Size = new Size(378, 22);
            displayAllMatchOneTeamToolStripMenuItem.Text = "Отобразить все матчи конкретной команды";
            displayAllMatchOneTeamToolStripMenuItem.Click += displayAllMatchOneTeamToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(180, 22);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(180, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(180, 22);
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
            displayTop3BombardirsToolStripMenuItem.Size = new Size(363, 22);
            displayTop3BombardirsToolStripMenuItem.Text = "Отобразить Топ 3 бомбардира конкретной команды";
            displayTop3BombardirsToolStripMenuItem.Click += displayTop3BombardirsToolStripMenuItem_Click;
            // 
            // displayAllInfoToolStripMenuItem1
            // 
            displayAllInfoToolStripMenuItem1.Name = "displayAllInfoToolStripMenuItem1";
            displayAllInfoToolStripMenuItem1.Size = new Size(363, 22);
            displayAllInfoToolStripMenuItem1.Text = "Отобразить всю информацию";
            displayAllInfoToolStripMenuItem1.Click += displayAllInfoToolStripMenuItem1_Click;
            // 
            // displayTop3BombardirsToolStripMenuItem1
            // 
            displayTop3BombardirsToolStripMenuItem1.Name = "displayTop3BombardirsToolStripMenuItem1";
            displayTop3BombardirsToolStripMenuItem1.Size = new Size(363, 22);
            displayTop3BombardirsToolStripMenuItem1.Text = "Отобразить Топ 3 бомбардира турнира";
            displayTop3BombardirsToolStripMenuItem1.Click += displayTop3BombardirsToolStripMenuItem1_Click;
            // 
            // displayTheBestBombardirToolStripMenuItem
            // 
            displayTheBestBombardirToolStripMenuItem.Name = "displayTheBestBombardirToolStripMenuItem";
            displayTheBestBombardirToolStripMenuItem.Size = new Size(363, 22);
            displayTheBestBombardirToolStripMenuItem.Text = "DisplayTheBestBombardir";
            displayTheBestBombardirToolStripMenuItem.Click += displayTheBestBombardirToolStripMenuItem_Click;
            // 
            // findInfoNameTeamToolStripMenuItem
            // 
            findInfoNameTeamToolStripMenuItem.Name = "findInfoNameTeamToolStripMenuItem";
            findInfoNameTeamToolStripMenuItem.Size = new Size(180, 22);
            findInfoNameTeamToolStripMenuItem.Text = "FindInfoNameTeam";
            findInfoNameTeamToolStripMenuItem.Click += findInfoNameTeamToolStripMenuItem_Click;
            // 
            // findInfoNameTownToolStripMenuItem
            // 
            findInfoNameTownToolStripMenuItem.Name = "findInfoNameTownToolStripMenuItem";
            findInfoNameTownToolStripMenuItem.Size = new Size(180, 22);
            findInfoNameTownToolStripMenuItem.Text = "FindInfoNameTown";
            findInfoNameTownToolStripMenuItem.Click += findInfoNameTownToolStripMenuItem_Click;
            // 
            // difToolStripMenuItem
            // 
            difToolStripMenuItem.Name = "difToolStripMenuItem";
            difToolStripMenuItem.Size = new Size(32, 19);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(112, 109);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(112, 80);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(112, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(6, 80);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(100, 23);
            domainUpDown1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clubToolStripMenuItem;
        private ToolStripMenuItem matchToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
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
        private ContextMenuStrip contextMenuStrip1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog2;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox7;
        private Button button1;
        private DomainUpDown domainUpDown1;
    }
}