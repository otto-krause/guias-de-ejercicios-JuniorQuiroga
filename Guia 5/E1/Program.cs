using System;
using System.Linq;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>{
                 new Persona(13, "Juan", "Perez"), 
                 new Persona(42, "Maria", "Ramirez"), 
                 new Persona(18, "Ariel", "Flores"),
                 new Persona(12, "Ramiro", "Ramales"),
                 new Persona(30, "Juan", "Eustaquio") };

            Console.WriteLine("Mayores de edad:");
            //busca las personas mayores                  las convierte en lista      las muestra
            personas.Where(persona => persona.Edad >= 18).ToList().ForEach(persona => Console.WriteLine(" -"+persona.Nombre));

            Console.WriteLine("Todos los que se llaman Juan:");
            personas.Where(persona => persona.Nombre == "Juan").ToList().ForEach(persona => Console.WriteLine(" -"+persona.Nombre+" "+persona.Apellido));

            Console.WriteLine("Todas las personas que se apellidan Perez:");
            personas.Where(persona => persona.Apellido == "Perez").ToList().ForEach(persona => Console.WriteLine(" -"+persona.Nombre+" "+persona.Apellido));
        }
    }
}
