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
            bool valido;
            int numero=0,menu=0;

            Console.WriteLine("Ingrese el nombre, posicion, pais y el numero");
            nombre=Leer();
            posicion=Leer();
            pais=Leer();
            numero=Int32.Parse(Leer());
            Album fifa2020 = new Album();
            valido =fifa2020.AddFigurita(nombre,posicion,pais,numero);

            if (valido)
            Console.WriteLine("carta agregada con exito");
            else
            Console.WriteLine("ya tiene esta carta");

            do{
            Console.WriteLine("[1]cantidad de delanteros \n[2]cantidad de mediocampistas \n[3]¿album completo?\n[0]salir");
            menu = Int32.Parse(Leer());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("hay "+fifa2020.CuantosDelanteros()+" delanteros");
                break;

                case 2:
                    Console.WriteLine("hay "+fifa2020.CuantosMediocampistas()+" mediocampistas");
                break;

                case 3:
                    if(fifa2020.EstaCompleto())
                    Console.WriteLine("El album esta completo");
                    else
                    Console.WriteLine("El album no esta completo");
                break;

                case 0:
                break;
                
                default:
                    Console.WriteLine("opcion no valida");
                break;
            }
            }while (menu !=0);
        }
    }
}
