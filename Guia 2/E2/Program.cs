using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {

        static void Main(string[] args)
        {
            string especialidad_deseada;
            Clinica San_Jose= new Clinica();
            List<Medico> medicos = San_Jose.DarLista();


            //cirujano, pediatra
            Console.WriteLine("Ingrese la especialidad deseada");
            especialidad_deseada=Console.ReadLine();
            
            foreach (var item in medicos)
            {
                if (item.DarEspecialidad()==especialidad_deseada)
                    if(item.EstaDisponible())
                        Console.WriteLine("El medico "+item.DarNombre()+" esta disponible");
                    else
                        Console.WriteLine("El medico no eta disponible, intente en otro momento");
            }
        }
    }
}
