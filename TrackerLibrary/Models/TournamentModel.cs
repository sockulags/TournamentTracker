using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of this tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Cash amount to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of all teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Represents the full prize pot payout table. For example placement 1-8.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The inner list represents each matchup in a specific round.
        /// The outer list represents each round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
