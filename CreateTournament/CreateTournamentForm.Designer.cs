namespace CreateTournament
{
    partial class TournmentCreator
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
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.comboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblTeamPlayers = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTournament.Location = new System.Drawing.Point(30, 41);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(312, 37);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(32, 120);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(208, 26);
            this.lblTournamentName.TabIndex = 2;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(32, 222);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(125, 29);
            this.lblEntryFee.TabIndex = 3;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(37, 162);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(341, 26);
            this.txtTournamentName.TabIndex = 4;
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(180, 226);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(198, 26);
            this.txtEntryFee.TabIndex = 5;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(32, 321);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(161, 29);
            this.lblSelectTeam.TabIndex = 6;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // comboSelectTeam
            // 
            this.comboSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectTeam.FormattingEnabled = true;
            this.comboSelectTeam.Location = new System.Drawing.Point(37, 362);
            this.comboSelectTeam.Name = "comboSelectTeam";
            this.comboSelectTeam.Size = new System.Drawing.Size(329, 34);
            this.comboSelectTeam.TabIndex = 7;
            // 
            // lblTeamPlayers
            // 
            this.lblTeamPlayers.AutoSize = true;
            this.lblTeamPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPlayers.Location = new System.Drawing.Point(484, 120);
            this.lblTeamPlayers.Name = "lblTeamPlayers";
            this.lblTeamPlayers.Size = new System.Drawing.Size(170, 26);
            this.lblTeamPlayers.TabIndex = 8;
            this.lblTeamPlayers.Text = "Teams\\Players";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 26;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(489, 162);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(449, 186);
            this.tournamentPlayersListBox.TabIndex = 9;
            // 
            // prizesListBox
            // 
            this.prizesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 26;
            this.prizesListBox.Location = new System.Drawing.Point(489, 444);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(449, 186);
            this.prizesListBox.TabIndex = 10;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.Location = new System.Drawing.Point(484, 399);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(79, 26);
            this.lblPrizes.TabIndex = 11;
            this.lblPrizes.Text = "Prizes";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(100, 414);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(195, 41);
            this.btnAddTeam.TabIndex = 12;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.Location = new System.Drawing.Point(100, 520);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(195, 41);
            this.btnCreatePrize.TabIndex = 13;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.Location = new System.Drawing.Point(405, 679);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(272, 53);
            this.btnCreateTournament.TabIndex = 14;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPlayer
            // 
            this.btnDeleteSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedPlayer.Location = new System.Drawing.Point(944, 162);
            this.btnDeleteSelectedPlayer.Name = "btnDeleteSelectedPlayer";
            this.btnDeleteSelectedPlayer.Size = new System.Drawing.Size(141, 94);
            this.btnDeleteSelectedPlayer.TabIndex = 15;
            this.btnDeleteSelectedPlayer.Text = "Delete Selected";
            this.btnDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrize
            // 
            this.btnDeleteSelectedPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedPrize.Location = new System.Drawing.Point(944, 444);
            this.btnDeleteSelectedPrize.Name = "btnDeleteSelectedPrize";
            this.btnDeleteSelectedPrize.Size = new System.Drawing.Size(141, 94);
            this.btnDeleteSelectedPrize.TabIndex = 16;
            this.btnDeleteSelectedPrize.Text = "Delete Selected";
            this.btnDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // TournmentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 790);
            this.Controls.Add(this.btnDeleteSelectedPrize);
            this.Controls.Add(this.btnDeleteSelectedPlayer);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.lblTeamPlayers);
            this.Controls.Add(this.comboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Name = "TournmentCreator";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox comboSelectTeam;
        private System.Windows.Forms.Label lblTeamPlayers;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnDeleteSelectedPlayer;
        private System.Windows.Forms.Button btnDeleteSelectedPrize;
    }
}

