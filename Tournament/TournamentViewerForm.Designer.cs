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
            this.lblTournament.Location = new System.Drawing.Point(35, 43);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(211, 37);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(36, 112);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(81, 26);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // matchupListBox
            // 
            this.matchupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 26;
            this.matchupListBox.Location = new System.Drawing.Point(41, 228);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(449, 368);
            this.matchupListBox.TabIndex = 3;
            // 
            // comboRound
            // 
            this.comboRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRound.FormattingEnabled = true;
            this.comboRound.Location = new System.Drawing.Point(161, 109);
            this.comboRound.Name = "comboRound";
            this.comboRound.Size = new System.Drawing.Size(329, 34);
            this.comboRound.TabIndex = 4;
            // 
            // checkUnplayed
            // 
            this.checkUnplayed.AutoSize = true;
            this.checkUnplayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnplayed.Location = new System.Drawing.Point(161, 169);
            this.checkUnplayed.Name = "checkUnplayed";
            this.checkUnplayed.Size = new System.Drawing.Size(180, 29);
            this.checkUnplayed.TabIndex = 5;
            this.checkUnplayed.Text = "Unplayed Only";
            this.checkUnplayed.UseVisualStyleBackColor = true;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(590, 228);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(179, 26);
            this.lblTeam1.TabIndex = 6;
            this.lblTeam1.Text = "Sample Team 1";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(590, 292);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(74, 26);
            this.lblScore1.TabIndex = 7;
            this.lblScore1.Text = "Score";
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(691, 289);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(133, 32);
            this.txtScore1.TabIndex = 8;
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.Location = new System.Drawing.Point(666, 368);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(62, 37);
            this.lblVersus.TabIndex = 9;
            this.lblVersus.Text = "VS";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(590, 462);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(179, 26);
            this.lblTeam2.TabIndex = 10;
            this.lblTeam2.Text = "Sample Team 2";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(590, 523);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(74, 26);
            this.lblScore2.TabIndex = 11;
            this.lblScore2.Text = "Score";
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(691, 520);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(133, 32);
            this.txtScore2.TabIndex = 12;
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(876, 386);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(106, 52);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(252, 43);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(132, 37);
            this.lblTournamentName.TabIndex = 14;
            this.lblTournamentName.Text = "<none>";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 684);
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

