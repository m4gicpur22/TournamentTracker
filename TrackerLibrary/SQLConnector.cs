using System;
using System.Collections.Generic;
using System.Text;
using TrackerLIbrary;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>Prize Model information, and the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
