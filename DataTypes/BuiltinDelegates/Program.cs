using System;

namespace BuiltinDelegates
{
    delegate string Salute(string x, string a, int b, string ab, string c);
    delegate int Salute1(string x, string a, int b, string ab, string c);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Salute del = new Salute(PrintName);

            // var result = del("XYIS");

            // Console.WriteLine(result);

            Func<string, string, int, string, string> del2 = PrintName2;


            var result = del2("Ana", "a", 1, "a");
            Console.WriteLine(result);

            Action<string> del3 = PrintName3;

            del3("Enrique");
        }

        static string PrintName(string nombre)
        {
            return "Juan";
        }

        static string PrintName2(string nombre, string ap, int edad, string calle)
        {
            return nombre;
        }

        static void PrintName3(string nombre)
        {
            Console.WriteLine(nombre);
        }

        static int PrintName4(string nombre, string ap, int edad, string calle)
        {
            return 0;
        }
    }
}
