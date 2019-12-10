namespace Tournament
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.comboRound = new System.Windows.Forms.ComboBox();
            this.checkUnplayed = new System.Windows.Forms.CheckBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.lblVersus = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.Location = new System.Drawing.Point(23, 28);
            this.lblTournament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(145, 26);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(24, 73);
            this.lblRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(57, 18);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // matchupListBox
            // 
            this.matchupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 18;
            this.matchupListBox.Location = new System.Drawing.Point(27, 148);
            this.matchupListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(301, 238);
            this.matchupListBox.TabIndex = 3;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // comboRound
            // 
            this.comboRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRound.FormattingEnabled = true;
            this.comboRound.Location = new System.Drawing.Point(107, 71);
            this.comboRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboRound.Name = "comboRound";
            this.comboRound.Size = new System.Drawing.Size(221, 26);
            this.comboRound.TabIndex = 4;
            this.comboRound.SelectedIndexChanged += new System.EventHandler(this.comboRound_SelectedIndexChanged);
            // 
            // checkUnplayed
            // 
            this.checkUnplayed.AutoSize = true;
            this.checkUnplayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnplayed.Location = new System.Drawing.Point(107, 110);
            this.checkUnplayed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkUnplayed.Name = "checkUnplayed";
            this.checkUnplayed.Size = new System.Drawing.Size(133, 21);
            this.checkUnplayed.TabIndex = 5;
            this.checkUnplayed.Text = "Unplayed Only";
            this.checkUnplayed.UseVisualStyleBackColor = true;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(393, 148);
            this.lblTeam1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(125, 18);
            this.lblTeam1.TabIndex = 6;
            this.lblTeam1.Text = "Sample Team 1";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(393, 190);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(53, 18);
            this.lblScore1.TabIndex = 7;
            this.lblScore1.Text = "Score";
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(461, 188);
            this.txtScore1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(90, 24);
            this.txtScore1.TabIndex = 8;
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.Location = new System.Drawing.Point(444, 239);
            this.lblVersus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(44, 26);
            this.lblVersus.TabIndex = 9;
            this.lblVersus.Text = "VS";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(393, 300);
            this.lblTeam2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(125, 18);
            this.lblTeam2.TabIndex = 10;
            this.lblTeam2.Text = "Sample Team 2";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(393, 340);
            this.lblScore2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(53, 18);
            this.lblScore2.TabIndex = 11;
            this.lblScore2.Text = "Score";
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(461, 338);
            this.txtScore2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(90, 24);
            this.txtScore2.TabIndex = 12;
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(584, 251);
            this.btnScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(71, 34);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(168, 28);
            this.lblTournamentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(92, 26);
            this.lblTournamentName.TabIndex = 14;
            this.lblTournamentName.Text = "<none>";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 445);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.checkUnplayed);
            this.Controls.Add(this.comboRound);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournament);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TournamentViewerForm";
            this.Text = "View Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.ComboBox comboRound;
        private System.Windows.Forms.CheckBox checkUnplayed;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label lblTournamentName;
    }
}

