/* PlayerInformationAVL.cs
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
    /// An immutable structure representing a player name and player information.
    /// </summary>
    public struct PlayerInformationAVL
    {
        public string Name { get; }

        public string Position { get; }

        public string Roster { get; }

        public PlayerInformationAVL(string name, string position, string roster)
        {
            Name = name;
            Position = position;
            Roster = roster;
        }

        public override string ToString()
        {
            return Name + " is a " + Position + " on team " + Roster;
        }
    }
}
