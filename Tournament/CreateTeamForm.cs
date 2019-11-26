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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey " });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sure", LastName = "Storm " });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            comboSelectTeamMember.DataSource = null;
            comboSelectTeamMember.DataSource = availableTeamMembers;
            comboSelectTeamMember.DisplayMember = "FullName";

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeamMembers;
            tournamentPlayersListBox.DisplayMember = "FullName";
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.EmailAddress = txtEmail.Text;
                p.CellPhoneNumber = txtCellPhone.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtCellPhone.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add validation to the form

            if(txtFirstName.Text.Length ==0)
            {
                return false;
            }

            if (txtLastName.Text.Length == 0)
            {
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                return false;
            }

            if (txtCellPhone.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)comboSelectTeamMember.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void btnRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)tournamentPlayersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = comboTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
