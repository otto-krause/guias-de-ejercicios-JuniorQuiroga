using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gatito Firulays = new Gatito("Filulays", true, 40);
            int minutosJuego=0;
            
            Console.WriteLine("[1]ver nombre \n[2]ver vacunas \n[3]hacerlo jugar \n[4]dar de comer \n[5]ver salud");

            switch(Console.ReadLine()){
                case "1":
                    Console.WriteLine("El gatito de llama "+Firulays.Nombre()); 
                    break;

                case "2":
                    if(Firulays.EstaVacunado())
                        Console.WriteLine("El gatito esta vacunado");
                    else
                        Console.WriteLine("El gatito no esta vacunado");
                break;

                case "3":
                    Console.WriteLine("Ingrese los minutos de juego");
                    minutosJuego= Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Le queda "+Firulays.Jugar(minutosJuego)+" de energia");
                break;

                case "4":
                    Console.WriteLine("El gatito ahora tiene "+Firulays.Comer()+" de energia");
                break;

                case "5":
                    if(Firulays.EstaSaludable())
                        Console.WriteLine("El gatito esta saludable");
                    else
                        Console.WriteLine("El gatito no esta saludable");
                break;

                default:
                    Console.WriteLine("Opcion invalida");
                break;
            }
        }
    }
}
