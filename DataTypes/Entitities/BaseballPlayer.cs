using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    public class BaseballPlayer : Athlete
    {
        public string Position { get; set; }
        public int GamesStarted { get; set; }
    }
}
