using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample
{
    //delegate void MiDelegado();
    internal class Program
    {
        // Main Thread es de tipo Foreground
        // Thread-safe
        static void Main(string[] args)
        {
            //Print("Hola");
            //Console.WriteLine("Hello World!");

            // thread es de tipo foreground y está compitiendo con el Main thread por los recursos(CPU, memoria, etc.)
            // race conditions
            // lock sirve para impedir que los threads se anden peleando
            // Signaling

            /*
             
             object locker;
             
             PrintSum();
             Thread thread1 = new Thread(LeerDatos);
             thread1.Start();

             private static void PrintSum()
             {
                int x = 0;
                x = x + 10;
                Console.WriteLine($"Resultado es: {x}");
             }

            private static void PrintSum()
             {
                lock(locker)
                {

                    int x = 0;
                    x = x + 10;
                    Console.WriteLine($"Resultado es: {x}");
                }
             }

            */


            Thread thread = new Thread(Print);
            thread.Start();

            Calculate();

            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadLine();
        }

        private static void Print()
        {
            Console.WriteLine("Ana");
        }

        // APM: Asynchronous Programming Model -> delegados -> BeginInvoke, EndInvoke
        // C# 5.0: async - await
        private static async Task Calculate()
        {
            // Worker Thread es de tipo Background 
            Task<int> task = Task.Run(() => 42);

            // No imprime resultado de 42 sino el tipo de dato
            // Console.WriteLine(task);

            await Task.Delay(5000);
            int result = await task;

            // user validation
            // WaitAll(task, task1, task2)
            // WaitAny(task, task1, task2)
            Console.WriteLine($"Resultado es: {result}");
        }

        private static async Task HazNada()
        {
            await Task.Delay(5000);
        }
    }
}
