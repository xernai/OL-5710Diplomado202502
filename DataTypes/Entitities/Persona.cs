using System;

namespace Entitities
{
    public class Persona
    {
        // Estado (fields): guarda información

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

        public Persona()
        {

        }

        public Persona(int edad)
        {
            _edad = (byte)edad; // casting: conversión de tipos
            Console.WriteLine($"Edad en constructor:{_edad}");
        }
    }
}
