using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of team members for each team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Associated team name
        /// </summary>
        public string TeamName { get; set; }
    }
}
