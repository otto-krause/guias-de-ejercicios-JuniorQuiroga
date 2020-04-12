using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0, a=0,b=0,resultado=0,contador=0;

            Console.WriteLine("Elija la operecion a realizar\n [1]Multiplicacion\n [2]Division\n [3]Resto");
            menu = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese dos numeros");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            
            switch(menu){
                case 1:
                    for(int i=0;i<b;i++){
                        resultado+= a;
                    } 
                break;

                default:
                    if(menu==2||menu==3){
                        while (b==0){
                            Console.WriteLine("ingrese un divisor distinto de 0");
                            b=Int32.Parse(Console.ReadLine());     
                        }

                        if (a>=b){
                            while (a>=b){
                                contador+=1;
                                a-=b;
                            }    
                        }
                        else 
                        contador=0;

                        if (menu==2)
                        resultado=contador;
                        else if (menu==3)
                        resultado=a;
                    }
                    else
                    Console.WriteLine("opcion no valida");

                break;
            }

            Console.WriteLine("El resultado de la operacion es: "+resultado);
        }
    }
}
