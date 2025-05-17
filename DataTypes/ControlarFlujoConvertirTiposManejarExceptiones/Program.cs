using System;

namespace ControlarFlujoConvertirTiposManejarExceptiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 500;
            string input = String.Empty;

            Console.WriteLine("Teclea tu edad y al final da Enter.");

            input = Console.ReadLine();

            // Conversiones: Implicitas y explícitas
            // age = (int)"45"; // esto el compilador no lo permite

            // Conversion Implicita 
            byte value = 10;
            age = value;
            // age = Int32.Parse(input); 

            try
            {
                age = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse '{input}'; Mensaje de error: {e.Message}");
                return;
            }
            finally
            {
                Console.WriteLine("Fin del proceso");
            }


            /*
            if (age > 17 && age < 65)
            {
                Console.WriteLine("Eres candidato a una tarjeta de crédito");
            }

            if (age < 18)
            {
                Console.WriteLine("No Eres candidato a una tarjeta de crédito");
            }

            if (age >= 65)
            {
                Console.WriteLine("Pensión Adultos Mayores");
                PagosBimestrales();
            }

            */

            if (age > 17 && age < 65)
            {
                Console.WriteLine("Eres candidato a una tarjeta de crédito");
            }
            else
            {
                if (age < 18)
                {
                    Console.WriteLine("No Eres candidato a una tarjeta de crédito");
                }
                else
                {
                    if (age >= 65)
                    {
                        Console.WriteLine("Pensión Adultos Mayores");
                        PagosBimestrales();
                    }
                }
            }
        }

        private static void PagosBimestrales()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Bimestre: {i + 1} => 3000");
            }
        }

        //private static void PagosBimestrales()
        //{
        //    int i = 0;
        //    while (i < 6)
        //    {
        //        Console.WriteLine($"Bimestre: {i + 1} => 3100");
        //        i++;
        //    }
        //}
    }
}
