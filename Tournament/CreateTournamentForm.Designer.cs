namespace Tournament
{
    partial class CreateTournamentForm
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
            this.btnRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.lblTeamPlayers = new System.Windows.Forms.Label();
            this.comboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.linkCreateNewPrize = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnRemoveSelectedPrize
            // 
            this.btnRemoveSelectedPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedPrize.Location = new System.Drawing.Point(973, 442);
            this.btnRemoveSelectedPrize.Name = "btnRemoveSelectedPrize";
            this.btnRemoveSelectedPrize.Size = new System.Drawing.Size(141, 94);
            this.btnRemoveSelectedPrize.TabIndex = 32;
            this.btnRemoveSelectedPrize.Text = "Remove Selected";
            this.btnRemoveSelectedPrize.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPrize.Click += new System.EventHandler(this.btnRemoveSelectedPrize_Click);
            // 
            // btnRemoveSelectedPlayer
            // 
            this.btnRemoveSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedPlayer.Location = new System.Drawing.Point(973, 160);
            this.btnRemoveSelectedPlayer.Name = "btnRemoveSelectedPlayer";
            this.btnRemoveSelectedPlayer.Size = new System.Drawing.Size(141, 94);
            this.btnRemoveSelectedPlayer.TabIndex = 31;
            this.btnRemoveSelectedPlayer.Text = "Remove Selected";
            this.btnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPlayer.Click += new System.EventHandler(this.btnRemoveSelectedPlayer_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.Location = new System.Drawing.Point(407, 677);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(272, 53);
            this.btnCreateTournament.TabIndex = 30;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.Location = new System.Drawing.Point(102, 518);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(195, 41);
            this.btnCreatePrize.TabIndex = 29;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(102, 412);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(195, 41);
            this.btnAddTeam.TabIndex = 28;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.Location = new System.Drawing.Point(486, 397);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(79, 26);
            this.lblPrizes.TabIndex = 27;
            this.lblPrizes.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 26;
            this.prizesListBox.Location = new System.Drawing.Point(491, 442);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(449, 186);
            this.prizesListBox.TabIndex = 26;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 26;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(491, 160);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(449, 186);
            this.tournamentTeamsListBox.TabIndex = 25;
            // 
            // lblTeamPlayers
            // 
            this.lblTeamPlayers.AutoSize = true;
            this.lblTeamPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPlayers.Location = new System.Drawing.Point(486, 118);
            this.lblTeamPlayers.Name = "lblTeamPlayers";
            this.lblTeamPlayers.Size = new System.Drawing.Size(170, 26);
            this.lblTeamPlayers.TabIndex = 24;
            this.lblTeamPlayers.Text = "Teams\\Players";
            // 
            // comboSelectTeam
            // 
            this.comboSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectTeam.FormattingEnabled = true;
            this.comboSelectTeam.Location = new System.Drawing.Point(39, 360);
            this.comboSelectTeam.Name = "comboSelectTeam";
            this.comboSelectTeam.Size = new System.Drawing.Size(329, 34);
            this.comboSelectTeam.TabIndex = 23;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(34, 319);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(161, 29);
            this.lblSelectTeam.TabIndex = 22;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(182, 224);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(198, 26);
            this.txtEntryFee.TabIndex = 21;
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(39, 160);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(341, 26);
            this.txtTournamentName.TabIndex = 20;
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(34, 220);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(125, 29);
            this.lblEntryFee.TabIndex = 19;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(34, 118);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(208, 26);
            this.lblTournamentName.TabIndex = 18;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTournament.Location = new System.Drawing.Point(32, 39);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(312, 37);
            this.lblCreateTournament.TabIndex = 17;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // linkCreateNewPrize
            // 
            this.linkCreateNewPrize.AutoSize = true;
            this.linkCreateNewPrize.Location = new System.Drawing.Point(281, 326);
            this.linkCreateNewPrize.Name = "linkCreateNewPrize";
            this.linkCreateNewPrize.Size = new System.Drawing.Size(87, 20);
            this.linkCreateNewPrize.TabIndex = 34;
            this.linkCreateNewPrize.TabStop = true;
            this.linkCreateNewPrize.Text = "create new";
            this.linkCreateNewPrize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateNewPrize_LinkClicked);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 790);
            this.Controls.Add(this.linkCreateNewPrize);
            this.Controls.Add(this.btnRemoveSelectedPrize);
            this.Controls.Add(this.btnRemoveSelectedPlayer);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.lblTeamPlayers);
            this.Controls.Add(this.comboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Name = "CreateTournamentForm";
            this.Text = "Tournament Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveSelectedPrize;
        private System.Windows.Forms.Button btnRemoveSelectedPlayer;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label lblTeamPlayers;
        private System.Windows.Forms.ComboBox comboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.LinkLabel linkCreateNewPrize;
    }
}