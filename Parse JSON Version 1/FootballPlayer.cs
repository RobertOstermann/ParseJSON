/* FootballPlayer.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_JSON_Version_1
{
    /// <summary>
    /// This class matches format to the JSON given from the MFL site.
    /// The program will not deserialize without the proper fields and classes.
    /// </summary>
    public class FootballPlayer
    {
        /// <summary>
        /// players contains PlayerInfo objects.
        /// </summary>
        public PlayerInfo players { get; set; }

        public class PlayerInfo
        {
            /// <summary>
            /// player accesses the list of allPlayers player objects.
            /// </summary>
            public List<allPlayers> player { get; set; }

            public class allPlayers
            {
                /// <summary>
                /// name is an attribute given from the MFL site.
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// id is an attribute given from the MFL site.
                /// </summary>
                public string id { get; set; }
            }
        }
    }
}
