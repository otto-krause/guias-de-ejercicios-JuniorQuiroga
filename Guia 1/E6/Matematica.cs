using System;

namespace E6
{
    public class Matematica
    {
        static public void Fibonacci(int limite){
            int n=0,aux=0,ant=1;

            for(int i=1;i<=limite;i++){
                Console.WriteLine(n);
                aux=n;
                n= n+ant;
                ant = aux;
            }
        }

        static public int Factorial(int num){
            int fact=1,result=0;

            if (num>=0){                    
                for(int i=1;i<=num;i++)                        
                    fact*=i;                
                result=fact;
            }
            else
            result=0;

            return result;
        }

        static public int Mayor(int num,int num1){
            return num > num1 ? num : num1;
        }

        static public int Menor(int num,int num1){
            return num < num1 ? num : num1;
        }

        static public int Cubo(int num){
            return num*num*num;
        }
    }
}