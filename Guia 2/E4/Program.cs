using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Mostrar(string[] split_info){
            Console.WriteLine("=Nombre: "+split_info[0]+"\n |genero: "+split_info[1]+"\n |año: "+split_info[2]+"\n |director: "+split_info[3]);
        }

        static void Buscar(int menu,string parametro){
            int vuelta=0,contador=0;
            string info;
            string[] split_info;
            Peliteca peliculista = new Peliteca();
            List<Pelicula> lista_peliculas = Peliteca.GetList(); 

            if (menu==5)
            Console.WriteLine("La cantidad total de peliculas es: "+lista_peliculas.Count);
            else{
                foreach (var pelicula in lista_peliculas)
                {
                    info = pelicula.GetInfo();
                    split_info = info.Split("/");

                    switch (menu)
                    {
                        case 1://busqueda por genero
                            if(parametro == split_info[1])
                            Mostrar(split_info);
                        break;
                        case 2://busqueda por nombre
                            if(parametro == split_info[0])
                            Mostrar(split_info);
                        break;
                        case 3://busqueda por año
                            if(parametro == split_info[2])
                            Mostrar(split_info);
                        break;
                        case 4: //busqueda por direccion
                            if(parametro == split_info[3])
                            Mostrar(split_info);
                        break;
                        case 6://contador por genero
                            if(parametro == split_info[1])
                            contador+=1;
                            if(vuelta==(lista_peliculas.Count-1))
                            Console.WriteLine("hay {0} peliculas del genero {1}",contador,parametro);
                        break;
                    }
                    vuelta+=1;
                }
            }
        }

        static void Main(string[] args)
        {
            int menu=0;
            string busqueda;
            
            Console.WriteLine("[1]Busqueda por genero \n[2]Busqueda por nombre \n[3]Busqueda por año \n[4]Busqueda por director \n[5]Cantidad de peliculas \n[6]Cantidad de un genero \n");
            menu=Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingrese el genero deseado");
                    busqueda=Console.ReadLine();
                    Buscar(menu,busqueda);
                break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la pelicula");
                    busqueda=Console.ReadLine();
                    Buscar(menu,busqueda);
                break;
                case 3:
                    Console.WriteLine("Ingrese el año de lanzamiento");
                    busqueda=Console.ReadLine();
                    Buscar(menu,busqueda);
                break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del director");
                    busqueda=Console.ReadLine();
                    Buscar(menu,busqueda);
                break;
                case 5:
                    Buscar(menu,"");
                break;
                case 6:
                    Console.WriteLine("Ingrese el genero");
                    busqueda=Console.ReadLine();
                    Buscar(menu,busqueda);
                break;
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }
}