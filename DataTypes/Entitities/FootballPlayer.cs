using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    public  class FootballPlayer : Athlete
    {
        public string Position { get; set; }
        public int Goals { get; set; }
    }
}
