using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0,a=0,b=0,c=0;
            
            Console.WriteLine("Ingrese la longitud de los lados a, b y c");
            a= Int32.Parse(Console.ReadLine());
            b= Int32.Parse(Console.ReadLine());
            c= Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("[1]¿Es escaleno? \n[2]¿Es isosceles? \n[3]¿Es equilatero? \n[4]¿Es un triangulo rectangulo?");
            
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    if(Triangulo.EsEscaleno(a,b,c))
                    Console.WriteLine("El triangulo es escaleno");
                    else
                    Console.WriteLine("El triangulo no es escaleno");
                break;
                
                case 2:
                    if(Triangulo.EsIsosceles(a,b,c))
                    Console.WriteLine("El triangulo es isosceles");
                    else
                    Console.WriteLine("El triangulo no es isosceles");
                break;

                case 3:
                    if(Triangulo.EsEquilatero(a,b,c))
                    Console.WriteLine("El triangulo es equilatero");
                    else
                    Console.WriteLine("El triangulo no es equilatero");
                break;
                
                case 4:
                    if(Triangulo.EsTrianguloRectangulo(a,b,c))
                    Console.WriteLine("El triangulo es rectangulo");
                    else
                    Console.WriteLine("El triangulo no es rectangulo");
                break;

                default:
                    Console.WriteLine("Opcion invalida");
                break;
            } 
        }
    }
}
