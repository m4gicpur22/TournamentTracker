using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary
{
    public class PrizeModel
    {   
        /// <summary>
        /// Unique indentifier for the Prize Model
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
    }
}
