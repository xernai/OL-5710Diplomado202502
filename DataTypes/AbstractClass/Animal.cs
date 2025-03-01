using System;

namespace AbstractClass
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
        public abstract void Volar(); // signature del método, esta parte se como definition 
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

        public override void Volar()
        {
            Console.WriteLine("El perro vuela...");
        }
    }

    public class Pato : Animal
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

        public override void Volar()
        {
            Console.WriteLine("El pato vuela...");
        }
    }
}
