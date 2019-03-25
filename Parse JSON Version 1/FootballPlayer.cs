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
    public class FootballPlayer
    {
        public PlayerInfo players { get; set; }

        public class PlayerInfo
        {
            public List<allPlayers> player { get; set; }

            public class allPlayers
            {
                public string name { get; set; }
                public string id { get; set; }
            }
        }
    }
}
