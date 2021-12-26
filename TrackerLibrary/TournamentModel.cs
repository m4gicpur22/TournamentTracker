using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of created tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Fee to enter the associated Tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams who have entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List for tracking prizes
        /// </summary>
        public List<PrizeModal> Prizes { get; set; } = new List<PrizeModal>();
        /// <summary>
        /// List of rounds per matchUp
        /// </summary>
        public List<List<MatchupModal>> Rounds { get; set; } = new List<List<MatchupModal>>();
    }
}
