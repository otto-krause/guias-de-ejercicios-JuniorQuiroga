using System.Collections.Generic;
using System;
namespace E3
{
    public class Album
    {
        static List<Figurita> figuritas= new List<Figurita>();

        public Album(){
            Figurita C0 = new Figurita("Pepito","delantero","mozambique",4);
            Album.figuritas.Add(C0);
            Figurita C1 = new Figurita("Rojuelo","mediocampista","Mexico",2);
            Album.figuritas.Add(C1);
        }

        public bool AddFigurita(string nombre,string posicion,string pais,int numero){
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
            }
            return contador==0;

        }

        public static List<Figurita> GetList(){
            return figuritas;
        }

        public int Contar(string parametro){
            int cont=0;
            string info;
            string[] split_info;

            foreach (var figurita in figuritas)
            {
                info = figurita.GetInfo();
                split_info = info.Split("/");

                if(parametro == split_info[1])
                cont++;
            }
            return cont;
        }

        public int CuantosDelanteros(){
            return Contar("delantero");
        }

        public int CuantosMediocampistas(){
            return Contar("mediocampista");
        }

        public bool EstaCompleto(){
            int jugadores = figuritas.Count;
            return jugadores == 352;
        }
    }
}