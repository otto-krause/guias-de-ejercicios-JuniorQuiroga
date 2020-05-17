using System;

namespace E2
{
    public class Pintor : Contratista
    {
        int cobra;
        
        public Pintor(){
        }

        public void Trabajar(int horas){
            cobra=horas*150;
        }

        public int Cobrar(){
            return cobra;
        }
    }
}