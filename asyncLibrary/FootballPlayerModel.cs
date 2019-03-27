using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncLibrary
{
    /// <summary>
    /// This class must match with the attributes obtained from the MFL player JSON.
    /// </summary>
    public class FootballPlayerModel
    {
        /// <summary>
        /// List of allPlayers objects.
        /// </summary>
        public List<allPlayers> player { get; set; }
        /// <summary>
        /// Actually just a single player object.
        /// Naming could use some work.
        /// </summary>
        public class allPlayers
        {
            /// <summary>
            /// name attribute matches with MFL player JSON.
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// id attribute matches with MFL player JSON.
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// position attribute matches with MFL player JSON.
            /// </summary>
            public string Position { get; set; }

            public string rosterStatus { get; set; }
        }
    }
}
