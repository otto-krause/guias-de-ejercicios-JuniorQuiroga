using System;

namespace E3
{
    class Program
    {
        public static string Leer(){
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string nombre,posicion,pais;
            int numero=0;

            Console.WriteLine("Ingrese el nombre, posicion, pais y el numero");
            nombre=Leer();
            posicion=Leer();
            pais=Leer();
            numero=Int32.Parse(Leer());
            Album fifa2020 = new Album(nombre,posicion,pais,numero);
        }
    }
}
