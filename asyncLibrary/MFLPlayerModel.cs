using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncLibrary
{
    public class MFLPlayerModel
    {
        /// <summary>
        /// MFL Players JSON
        /// http://www54.myfantasyleague.com/2018/export?TYPE=players&DETAILS=&SINCE=&PLAYERS=&JSON=1
        /// </summary>
        public ApiAllPlayerObject Players { get; set; }

        public class ApiAllPlayerObject
        {
            public List<ApiPlayerObject> Player { get; set; }

            public class ApiPlayerObject
            {
                public string Name { get; set; }

                public string Id { get; set; }

                public string Position { get; set; }

                public string Team { get; set; }

                public override string ToString()
                {
                    return Name.PadRight(27) + Team;
                }
            }
        }

        /// <summary>
        /// MFL Roster JSON
        /// http://www54.myfantasyleague.com/2018/export?TYPE=rosters&L=30916&APIKEY=ahBp1sybvuKnx0emO1nIYDQeHLox&FRANCHISE=&JSON=1
        /// </summary>
        public ApiRosterObject Rosters { get; set; }  

        public class ApiRosterObject
        {
           
            public List<APIRosterFranchiseObject> Franchise { get; set; }

            public class APIRosterFranchiseObject
            {
                public string Id { get; set; }

                public List<APIRosterPlayerObject> Player { get; set; }

                public class APIRosterPlayerObject
                {
                    public string ContractYear { get; set; }

                    public string Id { get; set; }

                    public string Salary { get; set; }
                }
            }
        }

        /// <summary>
        /// MFL League JSON
        /// http://www54.myfantasyleague.com/2018/export?TYPE=league&L=30916&APIKEY=ahBp1sybvuKnx0emO1nIYDQeHLox&JSON=1
        /// </summary>
        public ApiLeagueObject League { get; set; }

        public class ApiLeagueObject
        {
            public ApiAllFranchiseObject Franchises { get; set; }

            public class ApiAllFranchiseObject
            {
                public List<ApiFranchiseObject> Franchise { get; set; }

                public class ApiFranchiseObject
                {
                    public string Name { get; set; }

                    public string Id { get; set; }

                    public string Division { get; set; }
                }
            }
        }
    }
}
