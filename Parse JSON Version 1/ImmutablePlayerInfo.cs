using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_JSON_Version_1
{
    public struct ImmutablePlayerInfo
    {
        //Name should not be necessary as it is the key.
        //public string Name { get; }
        public int Id { get; }

        public string Team { get; }

        public string MFLTeam { get; }

        public decimal Salary { get; }

        public char Position { get; }

        public bool Roster { get; }

        public ImmutablePlayerInfo(int id, string team, string mflTeam, decimal salary, char position, bool roster)
        {
            //Name = name;
            Id = id;
            Team = team;
            MFLTeam = mflTeam;
            Salary = salary;
            Position = position;
            Roster = roster;
        }

        public override string ToString()
        {
            return Id.ToString().PadRight(27) + Team;
        }
    }
}
