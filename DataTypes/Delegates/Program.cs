using System;

namespace Delegates
{
    internal class Program
    {
        class Team1
        {
            public string PrintCoachName()
            {
                Console.WriteLine($"Nombre del Coach:");
                return "x";
            }

            public void PrintEdad()
            {
                PrintCoachName();
            }

            public string PrintSexo()
            {
                return "F";
            }
        }

        // El delegado es un apuntador a un método
        // 1. Definir delegado
        delegate string PrintTipoSexo();
        static void Main(string[] args)
        {
            int edad = 0;
            string nombre = "x";
            char sexo = '0';

            Team1 team1 = new Team1();
            team1.PrintCoachName();

            // 2. Instanciar el delegate
            PrintTipoSexo delPrintTipoSexo = new PrintTipoSexo(PrintSexoFemenino);

            // 3. Ejecutar el delegate

            // 3.1 Asociar otro método al delegate
            delPrintTipoSexo = delPrintTipoSexo + PrintSexoMasculino;
            delPrintTipoSexo();

            // PrintSexoFemenino();
            // PrintSexoMasculino();

            // 4. Destruir el delegate
            // Reactive X
            delPrintTipoSexo = delPrintTipoSexo - PrintSexoFemenino;
            delPrintTipoSexo = delPrintTipoSexo - PrintSexoMasculino;
        }

        static public string PrintSexoMasculino()
        {
            Console.WriteLine($"Desde PrintSexoMasculino: M");
            return "M";
        }

        static public string PrintSexoFemenino()
        {
            Console.WriteLine($"Desde PrintSexoFemenino: F");
            return "F";
        }
    }
}
