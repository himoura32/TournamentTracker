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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            comboRound.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchUpRound > currRound)
                {
                    currRound = matchups.First().MatchUpRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
        }

        private void comboRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)comboRound.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchUpRound == round)
                {
                    //selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                }
            }
            LoadMatchup(selectedMatchups.First());
        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        lblTeam1.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtScore1.Text = m.Entries[0].Score.ToString();

                        lblTeam2.Text = "<bye>";
                        txtScore2.Text = "0";
                    }
                    else
                    {
                        lblTeam1.Text = "Not Yet Set";
                        txtScore1.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        lblTeam2.Text = m.Entries[1].TeamCompeting.TeamName;
                        txtScore2.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lblTeam2.Text = "Not Yet Set";
                        txtScore2.Text = "";
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }
    }
}
