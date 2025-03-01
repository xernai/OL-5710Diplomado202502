using System;

namespace OOP
{
    // OOP: Object-Oriented Programming
    // 1. Abstraction
    //    Centrarnos en lo que nos interesa
    // 2. Inheritance
    //    Jerarquizar, reusar código
    //    En c# todo deriva de object 
    // 3. Polymorphism
    //     Significa muchas formas
    // 4. Encapsulation
    //    Protegernos de algo, que no quede a la vista de los demás
    public class Persona
    {
        // Las clases tienen:
        // 1. Estado (fields): guarda información
        // 2. Comportamiento: métodos (funciones)

        // Encapsulation
        private byte _edad; // campo, field, backing-field

        // propiedad normal
        public byte Edad
        {
            get { return _edad; } // lectura
            set { _edad = value; } // escritura
        }

        // propiedad automática
        // solo es sugar syntax
        public string Nombre { get; set; }

        /*
            La propiedad automática es convertida a un campo y propiedad
            private string nombre; 

            public string Nombre
            {
                get { return nombre; } // lectura
                set { nombre = value; } // escritura
            }
          
        */

        // Polymorphism se aplica en los constructores porque se llaman igual
        // Overloading
        public Persona()
        {

        }

        public Persona(int edad)
        {
            _edad = (byte)edad; // casting: conversión de tipos
            Console.WriteLine($"Edad en constructor:{_edad}");
        }

        public Persona(string nombre, int edad)
        {
 
        }

        public Persona(string edad)
        {

        }
    }
}
