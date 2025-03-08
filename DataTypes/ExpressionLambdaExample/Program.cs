using System;

namespace ExpressionLambdaExample
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

           // result = result + PrintName1;

            result("Juan");

            // Aplicando sugar syntax al método anónimo para crear lambda Expressions
            // 1. expression lambda, una sola línea
            // 2. Sentence Lambda, son varias encerradas en llaves

            // Primer intento
            // =>, operador goes to
            Salute result1 = (string nombre) =>
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            // Segundo intento
            // =>, operador goes to
            Salute result2 = (nombre) =>
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            result2("segundo intento");

            // tercer intento
            // =>, operador goes to
            Salute result3 = nombre =>
            {
                Console.WriteLine($"Tu nombre en Saludar es: {nombre}");
            };

            result3("tercer intento");

            // cuarto intento
            // =>, operador goes to
            Salute result4 = nombre => Console.WriteLine($"Tu nombre en Saludar es: {nombre}");

            result4("cuarto intento");
        }

        static void PrintName1(string nombre)
        {
            Console.WriteLine($"tu nombre en printname1 es: {nombre}");
        }
    }
}
