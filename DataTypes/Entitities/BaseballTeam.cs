using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    public class BaseballTeam
    {
        public string CoachName { get; set; }
        public BaseballPlayer[] Members { get; set; }
        public BaseballTeam(int maxMembers)
        {
            Members = new BaseballPlayer[maxMembers];
        }
    }
}
