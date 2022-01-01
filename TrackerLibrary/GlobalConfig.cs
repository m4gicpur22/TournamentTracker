using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// List of connections made to retrieve or set information
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection> ();

        /// <summary>
        /// Initialize SQL or text file connection to retrieve data
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFiles"></param>
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }

        }
    }
}
