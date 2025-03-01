using Interfaces;
using System;

namespace InterfaceExample
{
    // Las clases no se pueden instanciar, solo heredar
    // Sirven como base para otras clases
    public abstract class Animal
    {
        // State
        public string Nombre { get; set; }

        // Behavior
        public virtual void Caminar() // signature del método, esta parte se como definition
        {
            // implementation
            Console.WriteLine("Caminar en clase abstracta...");
        }
        public abstract void Correr(); // signature del método, esta parte se como definition 
    }

    class Terrestre
    {

    }

    public class Perro : Animal
    {
        public override void Correr()
        {
            Console.WriteLine("El perro corre...");
        }

        public override void Caminar() // signature del método, esta parte se como definition
        {
            // implementation
            Console.WriteLine("Caminar en clase derivada llamada perro...");
        }
    }

    public class Pato : Animal, IAves
    {
        public override void Correr()
        {
            Console.WriteLine("El pato corre...");
        }

        public override void Caminar() // signature del método, esta parte se como definition
        {
            // implementation
            Console.WriteLine("Caminar en clase derivada llamada pato...");
        }

        public void Volar()
        {
            // implementation
            Console.WriteLine("Volar en clase derivada llamada pato...");
        }

        public void Cantar()
        {
            throw new NotImplementedException();
        }
    }

    public class Tzenzontle : Animal, IAves, IAvesCantoras
    {
        public override void Correr()
        {
            Console.WriteLine("El Tzenzontle corre...");
        }

        public override void Caminar() // signature del método, esta parte se como definition
        {
            // implementation
            Console.WriteLine("Caminar en clase derivada llamada Tzenzontle...");
        }

        public void Volar()
        {
            // implementation
            Console.WriteLine("Volar en clase derivada llamada Tzenzontle...");
        }

        public void Cantar()
        {
            // implementation
            Console.WriteLine("Cantar en clase derivada llamada Tzenzontle...");
        }

        public class Avestruz : Animal, IAves
        {
            public override void Correr()
            {
                Console.WriteLine("El Tzenzontle corre...");
            }

            public override void Caminar() // signature del método, esta parte se como definition
            {
                // implementation
                Console.WriteLine("Caminar en clase derivada llamada Tzenzontle...");
            }

            public void Volar()
            {
                // implementation
                Console.WriteLine("Volar en clase derivada llamada Tzenzontle...");
            }
        }
    }
}
