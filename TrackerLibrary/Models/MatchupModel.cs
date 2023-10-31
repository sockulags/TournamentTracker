namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents a matchup between two teams.
        /// </summary>
        public List<MatchupEntriesModel> Entries { get; set; }
        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents which round in the tournament this matchup was in.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}