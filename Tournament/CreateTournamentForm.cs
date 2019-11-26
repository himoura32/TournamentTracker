using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace Tournament
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            comboSelectTeam.DataSource = null;
            comboSelectTeam.DataSource = availableTeams;
            comboSelectTeam.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)comboSelectTeam.SelectedItem;

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
            }

            WireUpLists();
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            // Call create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // get back from form a PrizeModel.
            // Take the PrizeModel and put it in list of selected prizes.
            selectedPrizes.Add(model);
            WireUpLists();
        }
        
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void linkCreateNewPrize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void btnRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void btnRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            // Validate Data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(txtEntryFee.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("Please enter a valid entry fee.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            // Create our tournament model.
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = txtTournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // Wire up the matchups

            // Create Tournament entry.
            // Create all of the prize entries.
            // Create all of the team entries.

            GlobalConfig.Connection.CreateTournament(tm);
        }
    }
}