namespace Tournament
{
    partial class TournamentDashboardForm
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
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.comboLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.lblLoadExistingTournament = new System.Windows.Forms.Label();
            this.lblTournamentDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.Location = new System.Drawing.Point(109, 310);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(297, 68);
            this.btnCreateTournament.TabIndex = 23;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTournament.Location = new System.Drawing.Point(146, 227);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(220, 41);
            this.btnLoadTournament.TabIndex = 22;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // comboLoadExistingTournament
            // 
            this.comboLoadExistingTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoadExistingTournament.FormattingEnabled = true;
            this.comboLoadExistingTournament.Location = new System.Drawing.Point(67, 173);
            this.comboLoadExistingTournament.Name = "comboLoadExistingTournament";
            this.comboLoadExistingTournament.Size = new System.Drawing.Size(391, 34);
            this.comboLoadExistingTournament.TabIndex = 21;
            // 
            // lblLoadExistingTournament
            // 
            this.lblLoadExistingTournament.AutoSize = true;
            this.lblLoadExistingTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadExistingTournament.Location = new System.Drawing.Point(104, 131);
            this.lblLoadExistingTournament.Name = "lblLoadExistingTournament";
            this.lblLoadExistingTournament.Size = new System.Drawing.Size(317, 29);
            this.lblLoadExistingTournament.TabIndex = 20;
            this.lblLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // lblTournamentDashboard
            // 
            this.lblTournamentDashboard.AutoSize = true;
            this.lblTournamentDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentDashboard.Location = new System.Drawing.Point(70, 55);
            this.lblTournamentDashboard.Name = "lblTournamentDashboard";
            this.lblTournamentDashboard.Size = new System.Drawing.Size(388, 37);
            this.lblTournamentDashboard.TabIndex = 19;
            this.lblTournamentDashboard.Text = "Tournament  Dashboard";
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 417);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.comboLoadExistingTournament);
            this.Controls.Add(this.lblLoadExistingTournament);
            this.Controls.Add(this.lblTournamentDashboard);
            this.Name = "TournamentDashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.ComboBox comboLoadExistingTournament;
        private System.Windows.Forms.Label lblLoadExistingTournament;
        private System.Windows.Forms.Label lblTournamentDashboard;
    }
}