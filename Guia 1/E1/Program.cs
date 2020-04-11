using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int suma=0,menor=0,aux=0;
            float prom=0;

            Console.WriteLine("Ingrese 10 numeros\n");

            for(int i=0;i<10;i++){
                vector[i]=Int32.Parse(Console.ReadLine());
            }

            for(int i=0;i<10;i++){
                suma += vector[i];
                Console.WriteLine(vector[i]);
            }

            for(int i=0;i<=10;i++){
                for(int j=0;j<9;j++){
                    if(vector[j]<vector[j+1]){
                        aux = vector[j];
                        vector[j]=vector[j+1];
                        vector[j+1]=aux;
                    }
                }
            }

            prom=suma/10;
            menor=vector[9];
            
            Console.WriteLine("La suma de todos los numeros es: "+suma);
            Console.WriteLine("El promedio de los numeros es: "+prom);
            Console.WriteLine("El menor de los numeros es: "+menor);
            
            Console.WriteLine("El vector ordenado es: \n");
            for(int i=0;i<10;i++){
                Console.WriteLine(vector[i]);
            }
            
        }
    }
}
