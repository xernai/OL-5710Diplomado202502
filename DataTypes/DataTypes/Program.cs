using System;
using System.Drawing;

namespace DataTypes
{
    // Data types se aplican a las variables para darle un size (bytes en memoria RAM) y tipo de contenido
    // Numeric y Non-numeric
    // Data types
    //      Value Types (numeric) se guardan en la memoria Stack(rápida y corta)
    //          - Primitives: int
    //      Reference Types (non-numeric) se guardan en la memoria stack su dirección de memoria
    //          a la memoria heap(grande, lenta, guarda la información)
    //          - string
    //          - class: persona
    // Todo en .NET es un objeto que deriva de System.Object (.NET) y en el caso particular de C# es object

    class Persona
    {
        // propiedades automáticas
        public string Nombre { get; set; }
        public int Saldo { get; set; }

        public Persona()
        {
                
        }

        public Persona(int id)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // byte edad = 20;
            byte edad = 20;   // Size en memoria es de un byte(8 bits) 256 -> 0 a 255 
            int saldo = 1000; // Size en memoria es de 4 bytes (32 bits) declarar la variable
                              // stack (0 de la memoria stack)
                              // 1000

            // saldo = 1000; // asignación

            Console.WriteLine($"El saldo de Ana es {saldo}");
            saldo = 500;
            Console.WriteLine($"El saldo de Juan es {saldo}");

            int saldoAnterior = 2000;
            Console.WriteLine($"El saldo de Ana es {saldo}");
            Console.WriteLine($"El saldo de Ana es {saldoAnterior}");

            saldoAnterior = saldo;

            Console.WriteLine("------------ saldoAnterior = saldo ---------------");
            Console.WriteLine($"El saldo de Ana es {saldo}");
            Console.WriteLine($"El saldo de Ana es {saldoAnterior}");

            Console.WriteLine("------------ Reference type: string ---------------");
            string nombre = "Juan"; // stack guarda la referencia de memoria de la memoria donde guarda su valor
                                    // y en la memoria heap guarda "Juan"
                                    // stack (2 dirección de memoria stack)       heap (100 dirección de memoria)
                                    // 100                                        Juan

            Console.WriteLine($"Contenido de nombre variable: {nombre}");

            string nombre1 = "Manuel";

            unsafe
            {
                fixed (char* p = nombre)
                {
                    Console.WriteLine("Memory address of nombre variable: " + (IntPtr)(p));
                }

                fixed (char* p = nombre1)
                {
                    Console.WriteLine("Memory address of nombre1 variable:" + (IntPtr)(p));
                }
            }

            nombre = "Juan";
            nombre1 = "Juan";
            // nombre variable
            //    stack (5 dirección de memoria stack)      
            //    200                                       
            // nombre1 variable
            //    stack (8 dirección de memoria stack)       
            //    200                                       

            // heap (200 dirección de memoria)
            // Juan

            // Anders Hejlsberg: Turbo Pascal, Turbo C, Delphi (Borland). 2002 nace .NET

            Console.WriteLine("------------ Cuando las 2 variables tipo string tienen el mismo valor --------------");
            unsafe
            {
                fixed (char* p = nombre)
                {
                    Console.WriteLine("Memory address of nombre variable: " + (IntPtr)(p));
                }

                fixed (char* p = nombre1)
                {
                    Console.WriteLine("Memory address of nombre1 variable:" + (IntPtr)(p));
                }
            }

            // Concatenación de variables tipo string (reference type)
            // Immutable: que no cambian cuando se les asigna otro valor, es decir, genera otra variable
            nombre = nombre + " Pérez";
            nombre = nombre + " 1000";

            // string query = "SELECT * FROM CLIENTS " +
            //    query = "WHERE CustomerId = " + txt.CustomerId;
                

            // Otra clase para concatenar tipo de dato string con mejor performance (sin crear más espacio en memoria)
            // StringBuilder

            Console.WriteLine("------------ Cuando a nombre se le concatena otro valor --------------");
            unsafe
            {
                fixed (char* p = nombre)
                {
                    Console.WriteLine("Memory address of nombre variable: " + (IntPtr)(p));
                }
            }

            // Stack address  Contenido           variable
            //       15          100             nombre variable original 
            //       20          120             variable concatenada y asignada a la variable original
            //       25          130             variable concatenada y asignada a la variable original

            // nombre variable original                  valor
            // 100 (dirección de memoria heap)           Juan
            // 120 (dirección de memoria heap)           Juan Pérez 
            // 130 (dirección de memoria heap)           Juan Pérez 1000

            // nombre variable original                  valor
            // 100 (dirección de memoria heap)           Juan
            //                                           Juan Pérez
            //                                           Juan Pérez 1000

            // Garbage collector se encargar de liberar la memoria heap en un momento dado
            // tiene un algoritmo:
            //  gen 0
            //  gen 1
            //  gen 2
            PrintSaldo(1000);

            // 1. Usando conexiones a la base de datos
            // 2. Manejo de archivos para leer y guardar info
            // 3. Cuando es código no administrado o inseguro, ejemplo, llamadas al sistema operativo(Win32)
            // Se pueden liberar esos recursos (red, CPU, memoria) con
            // la interfaz IDisposable para ejecutar Dispose y liberar esos recursos
        }

        // Definition
        // Implementation
        static void PrintSaldo(int lineaCredito)
        {
            int id = 10;

            Persona persona = new Persona();
            persona.Nombre = "Manuel";
            persona.Saldo = 100;

            // Stack Memoria Address     Variable              Content
            //   0                        id                      10
            //   1                        persona                 500 (Heap memory address)
            //   2                        lineaCredito            100

            // Heap Memoria Address      Variable          Content
            //   500                     persona.Nombre    Manuel
            //   507                     persona.Saldo     100
        }
    }
}
