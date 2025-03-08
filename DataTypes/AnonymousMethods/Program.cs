using System;

namespace AnonymousMethods
{
    delegate void Salute(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Salute result1 = new Salute(PrintName);

            //result1("XYIS");

            // Sugar syntax
            Salute result = delegate (string nombre)
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            result("Juan");
        }

        //static void PrintName(string nombre)
        //{
        //    Console.WriteLine($"Tu nombre en PrintName es: {nombre}");
        //}
    }
}
