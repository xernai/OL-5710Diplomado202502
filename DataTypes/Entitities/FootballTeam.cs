using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    public class FootballTeam
    {
        public string CoachName { get; set; }
        public FootballPlayer[] Members { get; set; }

        public FootballTeam(int maxMembers)
        {
            Members = new FootballPlayer[maxMembers];
        }
    }
}
