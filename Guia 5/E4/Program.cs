using System;
using System.Linq;
using System.Collections.Generic;

namespace E4
{
    class Program
    {

        static void Main(string[] args)
        {
            string especialidad_deseada;
            Clinica San_Jose= new Clinica();
            List<Medico> medicos = San_Jose.Lista;

            List<Medico> disponibles=new List<Medico>();

            do{
                //cirujano, pediatra
                Console.WriteLine("Ingrese la especialidad deseada, pára salir ingrese 0");
                especialidad_deseada=Console.ReadLine();
                
                disponibles= medicos.Where(medico => medico.Especialidad==especialidad_deseada && medico.EstaDisponible()).ToList();
                
                if(disponibles.Count<1)
                    Console.WriteLine("El Especialista no eta disponible, intente en otro momento");
                else{
                    Console.WriteLine("Especialista "+disponibles.First().Nombre+" "+disponibles.First().Apellido+" esta disponible");
                    disponibles.First().SumarTurno();
                }
            }while(especialidad_deseada!="0");
        }
    }
}
