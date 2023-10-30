using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Could be one or more data sources to pull from. Therefore it's a list.
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database">True if database is a source.</param>
        /// <param name="textFiles">True if text file is a source.</param>
        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create the SQL connection
            }

            if(textFiles)
            {
                // TODO - Create the Text Connection
            }
        }
    }
}
