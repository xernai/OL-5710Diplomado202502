using Entitities;
using System;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(20);

            persona.Nombre = "Ana";
           
            Console.WriteLine(persona.Nombre);
            Console.WriteLine($"Edad en Program:{persona.Edad}");

            persona.Edad = 30;
            Console.WriteLine($"Nueva Edad en Program:{persona.Edad}");
        }
    }
}
