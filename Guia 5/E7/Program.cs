using System;
using System.Linq;
using System.Collections.Generic;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Foto> fotos = new List<Foto>();
            List<Amigo> amigos = new List<Amigo>();
            List<Publicacion> publicaciones = new List<Publicacion>();

            fotos.Add(new Foto("sys/fotos/f1","15/2/2019","ramiro"));
            fotos.Add(new Foto("sys/fotos/f2","25/3/2020","rojelio"));
            fotos.Add(new Foto("sys/fotos/f3","31/4/2020","ruperta/rojelio"));

            amigos.Add(new Amigo("ramiro"));
            amigos.Add(new Amigo("rojelio"));
            amigos.Add(new Amigo("ruperta"));

            publicaciones.Add(new Publicacion("jajajjajajajjajajajjajajajjjajajajajjajajajajjajjajajjajjajjajajjajajajajaajajajjajajajjajajajjajajajjjajajajajjajajajajjajjajajjajjajjajajjajajajajaajajajjajajajjajajajjajajajjjajajajajjajajajajjajjajajjajjajjajajjajajajajaajajajjajajajjajajajjajajajjjajajajajjajajajajjajjajajjajjajjajajjajajajajaaja"));

            fotos.Where(f => f.Fecha.Contains("2020")).ToList().ForEach(x=>Console.WriteLine(" "+x.Direccion+" "+x.Fecha+" "+x.Etiquetas+" "));

            Console.WriteLine("Ingrese el nombre de dos personas");
            string nombreA = Console.ReadLine();
            string nombreB = Console.ReadLine();

            fotos.Where(f => f.Etiquetas.Contains(nombreA)&&f.Etiquetas.Contains(nombreB)).ToList()
            .ForEach(x=>Console.WriteLine(" "+x.Direccion+" "+x.Fecha+" "+x.Etiquetas+" "));
        }
    }
}
