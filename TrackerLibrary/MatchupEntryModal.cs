﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class MatchupEntryModal
    {   
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>
        public MatchupModal ParentMatchup { get; set; }
    }
}
