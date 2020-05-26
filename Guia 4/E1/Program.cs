using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Animal pajaro = new Pajaro();
            Animal perro = new Perro();

            Console.WriteLine("elija las acciones a realizar");
            do{
                Console.WriteLine("energia del perro "+perro.getEnergia);
                Console.WriteLine("energia del pajaro "+pajaro.getEnergia);
                
                Console.WriteLine("[1]comen \n[2]juegan \n[3]duermen \n[0]salir");
                menu = Console.ReadLine();
                switch(menu){
                    case "1":
                        perro.Comer();
                        pajaro.Comer();
                    break;

                    case "2":
                        perro.Jugar();
                        pajaro.Jugar();
                    break;

                    case "3":
                        perro.Dormir();
                        pajaro.Dormir();
                    break;

                    default:
                    break;
                }

            }while(menu!="0" );
        }
    }
}
