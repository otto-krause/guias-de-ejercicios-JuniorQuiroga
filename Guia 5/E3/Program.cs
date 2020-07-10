using System.Collections.Generic;
using System;
using System.Linq;

namespace E3
{
    class Program
    {   
        public static void ArmadurasAtena(List<CaballeroDelZodiaco> lista){
            lista.Where(c => c.Dios=="Atena").ToList().ForEach(caballero => Console.WriteLine(caballero.Armadura.Nombre));
        }
       
        public static void Dioses(List<CaballeroDelZodiaco> lista){
            lista.GroupBy(c => c.Dios).Select(grupo => grupo.First()).ToList().ForEach(caballero => Console.WriteLine(caballero.Dios));
        }

        public static void Signos(List<CaballeroDelZodiaco> lista){
            lista.Where(c => c.Signo.StartsWith("c")||c.Signo.StartsWith("C"))
            .ToList().GroupBy(c => c.Signo).Select(grupo => grupo.First())
            .ToList().ForEach(caballero => Console.WriteLine(caballero.Signo));
        }

        static void Main(string[] args)
        {
            int menu=0;
            List<CaballeroDelZodiaco> lista = new List<CaballeroDelZodiaco>();

            Armadura a1 = new Armadura("Pegaso","bronce"); 
            Armadura a2 = new Armadura("Scales","plata");
            Armadura a3 = new Armadura("Aries","oro"); 
            Armadura a4 = new Armadura("Taurus","plata");
            Armadura a5 = new Armadura("Libra","oro");

            CaballeroDelZodiaco c1 = new CaballeroDelZodiaco("Ramiro","Atena",a1,"Aries");
            CaballeroDelZodiaco c2 = new CaballeroDelZodiaco("Julio","Apolo",a2,"Libra");
            CaballeroDelZodiaco c3 = new CaballeroDelZodiaco("Eustaquio","Hades",a3,"Cancer");
            CaballeroDelZodiaco c4 = new CaballeroDelZodiaco("Jose","Thanatos",a4,"Capricornio");
            CaballeroDelZodiaco c5 = new CaballeroDelZodiaco("Juan","Atena",a5,"Capricornio");

            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);
            lista.Add(c5);

            
            do{
                Console.WriteLine("\n[1]Armadura de caballeros que apeyan a Atena\n[2]Nombres de los dioses\n[3]Signos del sodiaco que empiecen con c\n[0]salir");
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        ArmadurasAtena(lista);
                    break;

                    case 2:
                        Dioses(lista);
                    break;

                    case 3:
                        Signos(lista);
                    break;

                    default:
                    if(menu!=0)
                        Console.WriteLine("Opcion no valida");
                    break;
                }

            }while(menu!=0);
        }
    }
}
