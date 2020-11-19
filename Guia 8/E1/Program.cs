using System.Collections.Generic;
using System.Linq;
using System;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            List<string> temp = new List<string>();
            string str = "";
            int menu=0;

            do
            {
                Console.WriteLine("Elige una opcion\n[0]salir\n[1]agregar\n[2]mostrar\n[3]mostrar sin repetir\n[4]buscar");
                menu=Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        archivo.Agregar(Console.ReadLine());
                    break;
                    
                    case 2:
                        Console.WriteLine(archivo.Leer());
                    break;
                    
                    case 3:
                        temp=archivo.Leer().Split("\n").ToList().Distinct().ToList();
                        
                        foreach (var peli in temp)
                        {
                            Console.WriteLine(peli);
                        }
                    break;

                    case 4:
                        str=Console.ReadLine();
                        archivo.Leer().Split("\n").Where(a=> a.Contains(str)).ToList().ForEach(peli=>Console.WriteLine(peli));
                    break;

                    default:
                    break;
                }
            }while(menu!=0);
        }
    }
}
