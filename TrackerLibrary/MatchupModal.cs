using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class MatchupModal
    {
        /// <summary>
        ///  List of entries in the tournament
        /// </summary>
        public List<MatchupEntryModal> Entries { get; set; } = new List<MatchupEntryModal>();
        /// <summary>
        /// Winner of the match up in the tournament
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The number of the matchup Round(1st, 2nd, 3rd..)
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
