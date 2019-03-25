using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncLibrary
{
    public class FootballPlayerModel
    {
        public List<allPlayers> player { get; set; }

        public class allPlayers
        {
            public string name { get; set; }
            public string id { get; set; }
        }
    }
}
