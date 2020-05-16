using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=1;
            Homero homero =new Homero(2);
            Lenny lenny =new Lenny();
            Pato_Balancin pato = new Pato_Balancin();

            Planta p1 = new Planta(10000,homero);
            Mr_Burns burns = p1.getBurns; 

            do{
                Console.WriteLine("[1]planta en peligro?\n"+
                "[2]homero come dona\n"+
                "[3]homero compra donas\n"+
                "[4]Lenny toma cerveza\n"+
                "[5]burns se despoja de sus riquezas\n"+
                "[6]remplazar por lenny\n"+
                "[7]remplazar por pato balancin\n"+
                "[8]ingresar barras al deposito\n"+
                "[0]salir");
                switch (Console.ReadLine())
                {
                    case "1":
                        if (p1.EstaEnPeligro())
                        Console.WriteLine("La planta esta en peligro");
                        else
                        Console.WriteLine("La planta no esta en peligro");
                    break;
                    
                    case "2":
                        homero.comer();
                    break;
                    
                    case "3":
                        homero.comprar();
                    break;
                    
                    case "4":
                        lenny.TomaCerveza();
                    break;
                    
                    case "5":
                        burns.despojarseDeRiquezas();
                    break;

                    case "6":
                        p1.CambiarEmpleado(lenny);
                    break;
                    
                    case "7":
                        p1.CambiarEmpleado(pato);
                    break;

                    case "8":
                        Console.WriteLine("ingrese la cantidad de barras");
                        p1.setBarras(Int32.Parse(Console.ReadLine()));
                    break;

                    default:
                        menu=0;
                    break;
                }
            }while(menu!=0);
        }
    }
}
