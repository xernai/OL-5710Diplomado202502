using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    public class TennisPlayer : Athlete
    {
        public string Position { get; set; }
        public int Points { get; set; }
    }
}
