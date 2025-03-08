using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities
{
    // <T> se conoce como placeholder (plantilla)
    public class Team<T> where T : Athlete
    {
        public string CoachName { get; set; }

        public T[] Members { get; set; }

        public Team(int maxMembers)
        {
            Members = new T[maxMembers];
        }

        public void PrintCoachName()
        {
            Console.WriteLine($"Nombre del Coach: {CoachName}");
        }
    }
}
