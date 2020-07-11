using System;
using System.Linq;
using System.Collections.Generic;

namespace E8
{
    public class Matematicas2
    {
        List<int> A= new List<int>();
        List<int> B= new List<int>();
        List<int> todos = new List<int>();
        
        public Matematicas2(List<int> A,List<int> B){
            this.A=A;
            this.B=B;
            todos = A.Concat(B).ToList();
        }

        public List<int> Primos(){
            List<int> resultado = new List<int>();
            foreach (var n in todos)
            {
                int m=0,flag=0;
                m=n/2;    
                for(int i = 2; i <= m; i++){    
                    if(n % i == 0){    
                        flag=1;    
                        break;    
                    }    
                }    
                if(flag==0)    
                    resultado.Add(n); 
            }
            return resultado;
        }

        public List<int> Pares(){
            return todos.Where(num => num%2==0).ToList();
        }

        public List<int> Aplanar(){
            return todos.Distinct().ToList();
        }
        
        public int Sumar(){
            return todos.Sum();
        }

        public int Maximo(){
            
            return todos.Max();
        }

        public int Minimo(){
            return todos.Min();
        }
    }
}