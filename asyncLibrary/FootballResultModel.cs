using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncLibrary
{
    /// <summary>
    /// This class must match up to the attributes provided in the MFL player JSON.
    /// </summary>
    public class FootballResultModel
    {
        /// <summary>
        /// players is an object that contains a list of player objects.
        /// </summary>
        public FootballPlayerModel players { get; set; }
    }
}
