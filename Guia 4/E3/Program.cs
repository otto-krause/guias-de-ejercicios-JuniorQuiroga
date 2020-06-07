using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0;
            Jugador juanito = new Jugador("jueanito");
            
            Consola caja = new CajaX("CajaX");
            Consola computer = new PC("PC");
            Consola PS = new PonyStation4("PonyStation4");
            Consola PS_pro = new PonyStation4_pro_SaladaEdition("PonyStation4_pro_SaladaEdition");
            
            Juego j1 = new Juego("asdafad",2010,"PC");
            Juego j2 = new Juego("grand theft rancho 2",2019,"PonyStation4_pro_SaladaEdition");
            Juego j3 = new Juego("grand theft rancho 2 4K",2020,"PC");
            Juego j4 = new Juego("asdafalush",2015,"PonyStation4");
            Juego j5 = new Juego("juanito alcachofas HD",2021,"CajaX");
            Juego j6 = new Juego("ciber funkie",2022,"CajaX");
            

            juanito.AdquirirConsola(computer);
            juanito.AdquirirConsola(PS);
            juanito.AdquirirConsola(caja);
            juanito.AdquirirConsola(PS_pro);

            juanito.AdquirirJuego(j1);
            juanito.AdquirirJuego(j2);
            juanito.AdquirirJuego(j3);
            juanito.AdquirirJuego(j4);
            juanito.AdquirirJuego(j5);
            juanito.AdquirirJuego(j6);

            Console.WriteLine("Los juegos mas nuevos:\n PC: "+computer.elMasNuevo()+"\n CajaX: "+caja.elMasNuevo()+"\n PS: "+PS.elMasNuevo()+"\n PS PRO: "+PS_pro.elMasNuevo());
            do{
                Console.WriteLine("\nPuntajes:\n PC: "+computer.RevisarPuntaje()+"\n CajaX: "+caja.RevisarPuntaje()+"\n PS: "+PS.RevisarPuntaje()+"\n PS PRO: "+PS_pro.RevisarPuntaje());
                Console.WriteLine("[1]jugar PC\n[2]jugar CajaX\n[3]jugar PS\n[4]jugar PS PRO\n[5]consola mas usada\n[0]salir");
                menu=Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ingrese la cantidad de horas");
                        computer.Jugar(Int32.Parse(Console.ReadLine()));
                    break;

                    case 2:
                        Console.WriteLine("ingrese la cantidad de horas");
                        caja.Jugar(Int32.Parse(Console.ReadLine()));
                    break;

                    case 3:
                        Console.WriteLine("ingrese la cantidad de horas");
                        PS.Jugar(Int32.Parse(Console.ReadLine()));
                    break;

                    case 4:
                        Console.WriteLine("ingrese la cantidad de horas");
                        PS_pro.Jugar(Int32.Parse(Console.ReadLine()));
                    break;

                    case 5:
                        Console.WriteLine(juanito.laMasUsada()+" es la consola mas usada");
                    break;
                }
            }while(menu!=0);

        }
    }
}
