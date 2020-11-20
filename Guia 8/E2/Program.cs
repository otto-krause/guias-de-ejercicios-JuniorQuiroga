
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo ar = new Archivo();
            double x= 0;
            double y= 0;
            Console.WriteLine("ingrese latitud y longitud");
            x= Convert.ToDouble(Console.ReadLine());
            y= Convert.ToDouble(Console.ReadLine());

            ar.cosa();
            Console.WriteLine(ar.Buscar(x,y));
            Console.WriteLine(ar.BuscarTrabajo(x,y));
        }
    }
}
