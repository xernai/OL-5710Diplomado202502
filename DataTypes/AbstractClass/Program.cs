using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();

            perro.Caminar();
            perro.Correr();
         
            perro.Volar();        
        }
    }
}
