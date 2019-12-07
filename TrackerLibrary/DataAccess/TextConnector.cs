using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{    
    /// <summary>
    /// Saves a mew prize to the database.
    /// </summary>
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";

        /// <summary>
        /// Saves a person to text file.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file convert the text to List<PersonModel>
            List<PersonModel> person = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the Max ID
            int currentId = 1;
            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            person.Add(model);

            // Convert prizes to List<string>
            // Save List<string> to the text file.
            person.SaveToPersonFile(PersonFile);

            return model;
        }
        /// <summary>
        /// Saves a prize to text file.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the Max ID
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert prizes to List<string>
            // Save List<string> to the text file.
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
        /// <summary>
        /// Saves a team to text file.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            // Load the text file convert the text to List<TeamModel>
            List<TeamModel> team = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);

            // Find the Max ID
            int currentId = 1;
            if (team.Count > 0)
            {
                currentId = team.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            team.Add(model);

            // Convert prizes to List<string>
            // Save List<string> to the text file.
            team.SaveToTeamFile(TeamFile);

            return model;
        }
        /// <summary>
        /// Save a tournament to a text file.
        /// </summary>
        /// <param name="model"></param>
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PersonFile, PrizesFile);

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }

        /// <summary>
        /// Gets a list of person from text file.
        /// </summary>
        /// <returns></returns>
        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        /// <summary>
        /// Gets a list of Team from text file.
        /// </summary>
        /// <returns></returns>
        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);
        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PersonFile, PrizesFile);
        }
    }
}
