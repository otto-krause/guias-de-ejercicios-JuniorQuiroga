using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int presupuesto;
            
            Constructora c1= new Constructora();

            Console.WriteLine("Ingrese la cantidad de horas que trabajaran y el presupuesto de la obra");
            horas = Int32.Parse(Console.ReadLine());
            presupuesto = Int32.Parse(Console.ReadLine());

            if(c1.PresupuestoSuficiente(presupuesto,horas))
                Console.WriteLine("El presupuesto es suficiente para llevar a cabo la obra");
            else
                Console.WriteLine("El presupuesto no es suficiente para llevar a cabo la obra");
        }
    }
}
