namespace Tournament
{
    partial class CreateTeamForm
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
            this.grpCreateMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.comboSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.comboTeamName = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.btnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.grpCreateMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateMember
            // 
            this.grpCreateMember.Controls.Add(this.btnCreateMember);
            this.grpCreateMember.Controls.Add(this.txtCellPhone);
            this.grpCreateMember.Controls.Add(this.txtEmail);
            this.grpCreateMember.Controls.Add(this.txtLastName);
            this.grpCreateMember.Controls.Add(this.txtFirstName);
            this.grpCreateMember.Controls.Add(this.lblCell);
            this.grpCreateMember.Controls.Add(this.lblEmail);
            this.grpCreateMember.Controls.Add(this.lblLastName);
            this.grpCreateMember.Controls.Add(this.lblFirstName);
            this.grpCreateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateMember.Location = new System.Drawing.Point(37, 396);
            this.grpCreateMember.Name = "grpCreateMember";
            this.grpCreateMember.Size = new System.Drawing.Size(329, 322);
            this.grpCreateMember.TabIndex = 25;
            this.grpCreateMember.TabStop = false;
            this.grpCreateMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.Location = new System.Drawing.Point(54, 255);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(195, 41);
            this.btnCreateMember.TabIndex = 16;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(141, 194);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(180, 32);
            this.txtCellPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(141, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 32);
            this.txtEmail.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(141, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 32);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(142, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 32);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell.Location = new System.Drawing.Point(6, 197);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(129, 26);
            this.lblCell.TabIndex = 3;
            this.lblCell.Text = "Cell Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(127, 26);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(129, 26);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(314, 750);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(195, 41);
            this.btnCreateTeam.TabIndex = 24;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 26;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(410, 142);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(465, 576);
            this.tournamentPlayersListBox.TabIndex = 23;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(91, 318);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(195, 41);
            this.btnAddMember.TabIndex = 22;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // comboSelectTeamMember
            // 
            this.comboSelectTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectTeamMember.FormattingEnabled = true;
            this.comboSelectTeamMember.Location = new System.Drawing.Point(37, 264);
            this.comboSelectTeamMember.Name = "comboSelectTeamMember";
            this.comboSelectTeamMember.Size = new System.Drawing.Size(329, 34);
            this.comboSelectTeamMember.TabIndex = 21;
            // 
            // comboTeamName
            // 
            this.comboTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeamName.FormattingEnabled = true;
            this.comboTeamName.Location = new System.Drawing.Point(37, 153);
            this.comboTeamName.Name = "comboTeamName";
            this.comboTeamName.Size = new System.Drawing.Size(329, 34);
            this.comboTeamName.TabIndex = 20;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeamMember.Location = new System.Drawing.Point(32, 224);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(238, 26);
            this.lblSelectTeamMember.TabIndex = 19;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(32, 115);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(141, 26);
            this.lblTeamName.TabIndex = 18;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTeam.Location = new System.Drawing.Point(30, 40);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(214, 37);
            this.lblCreateTeam.TabIndex = 17;
            this.lblCreateTeam.Text = "Create Team";
            // 
            // btnRemoveSelectedPlayer
            // 
            this.btnRemoveSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedPlayer.Location = new System.Drawing.Point(902, 142);
            this.btnRemoveSelectedPlayer.Name = "btnRemoveSelectedPlayer";
            this.btnRemoveSelectedPlayer.Size = new System.Drawing.Size(141, 94);
            this.btnRemoveSelectedPlayer.TabIndex = 33;
            this.btnRemoveSelectedPlayer.Text = "Remove Selected";
            this.btnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPlayer.Click += new System.EventHandler(this.btnRemoveSelectedPlayer_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 822);
            this.Controls.Add(this.btnRemoveSelectedPlayer);
            this.Controls.Add(this.grpCreateMember);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.comboSelectTeamMember);
            this.Controls.Add(this.comboTeamName);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCreateTeam);
            this.Name = "CreateTeamForm";
            this.Text = "Team Creator";
            this.grpCreateMember.ResumeLayout(false);
            this.grpCreateMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox comboSelectTeamMember;
        private System.Windows.Forms.ComboBox comboTeamName;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Button btnRemoveSelectedPlayer;
    }
}