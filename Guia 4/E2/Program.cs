using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            MonstersInc empresa = new MonstersInc();
            List<string> nombres = new List<string>();
            
            do{
                Console.WriteLine("[1]Noche de sustos \n[2]Noche de risas \n[3]respetables \n[0]salir");
                menu=Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        empresa.NocheDeSustos();
                    break;

                    case "2":
                        empresa.NocheDeRisas();
                    break;

                    case "3":
                        nombres = empresa.Respetables();
                        foreach (var nombre in nombres)
                        {
                            Console.WriteLine(nombre+" es respetable");
                        }
                    break;

                    default:
                    break;
                }
                Console.WriteLine("se genero "+empresa.EnergiaGenerada()+" de energia\n");
            }while(menu!="0");
        }
    }
}
