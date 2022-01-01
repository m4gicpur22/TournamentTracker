using System;
using System.Collections.Generic;
using System.Text;
using TrackerLIbrary;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// Creates an associated prize with passed in PrizeModel class
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
