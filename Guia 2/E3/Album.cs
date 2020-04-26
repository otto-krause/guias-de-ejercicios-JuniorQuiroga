using System.Collections.Generic;
using System;
namespace E3
{
    public class Album
    {
        void AddFigurita(string nombre,string posicion,string pais,int numero){
            int contador=0;
            string info;
            string[] split_info;
            List<Figurita> lista_figuritas = Album.GetList(); 
            
            foreach (var figu in lista_figuritas)
            {
                info = figu.GetInfo();
                split_info = info.Split("/");

                if (split_info[0]==nombre&&split_info[1]==posicion&&split_info[2]==pais&&Int32.Parse(split_info[3])==numero)
                contador+=1;
            }

            if (contador==0){
            Figurita C2 = new Figurita(nombre,posicion,pais,numero);
            Album.figuritas.Add(C2);
            Console.WriteLine("carta agregada con exito");
            }
            else
            Console.WriteLine("Ya tiene esta carta");

        }
        
        static List<Figurita> figuritas= new List<Figurita>();

        public Album(string nombre,string posicion,string pais,int numero){
            Figurita C0 = new Figurita("Pepito","delantero","mozambique",4);
            Album.figuritas.Add(C0);
            Figurita C1 = new Figurita("Rojuelo","Mediocampista","Mexico",2);
            Album.figuritas.Add(C1);

            AddFigurita(nombre,posicion,pais,numero);
        }

        public static List<Figurita> GetList(){
            return figuritas;
        }
    }
}