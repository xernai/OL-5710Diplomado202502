using System;

namespace Interfaces
{
    // La herencia múltiple no existe en C#, se simula mediante interfaces

    // Design patterns
    // La Pandilla de los Cuatro
    // 1. Creational: Singleton
    // 2. Structural: Brigde, Adapter
    // 3. Behavioral: Strategy, Command, State

    // Solid Principles
    // 1. Single Responsibility
    //    Un objecto debería tener una sola y única razón para cambiar
    // 2. Open/close Principle
    //    Open to extend, close to change
    //    Para extender se puede la herencia, las interfaces junto con polimorfismo, métodos extensores
    // 3. Liskov's Substitution Principle
    //    si a = b y c = b, entonces a = c
    //    Los objetos base o clases padres puede ser sustituibles por las clases derivadas o hijas
    //    Se aplica con las interfaces junto con polimorfismo usando Covariance y Contravariance
    // 4. Segregation Interface Principle
    //    Se debería evitar que la interfaz tenga métodos que otro objecto no los requiera
    // 5. Dependency Inversion Principle
    //    Los objectos de alto nivel no deberían depender de los de bajo nivel y viceversa, sin ambos depender
    //    de abstracciones (clases abstractas o interfaces)
    //    Inyección de dependencias
    //    Loose y couple code

    //    Programming to interfaces not to implementation
    //    
    public interface IAves
    {
        void Volar();
        void Caminar();
    }
}
