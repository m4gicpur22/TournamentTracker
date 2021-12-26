using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class PrizeModal
    {
        /// <summary>
        /// Number of the place for person in tournament
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of the place associated with number for person in tournament
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Total prime amount for the end of the tournament
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the prize the person wins based on their place number
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
