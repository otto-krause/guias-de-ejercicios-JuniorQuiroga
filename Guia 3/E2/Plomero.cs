using System;

namespace E2
{
    public class Plomero : Contratista
    {
        int cobro;

        public Plomero(){
        }

        public void Trabajar(int horas){
            cobro=horas*80;
        }

        public int Cobrar(){
            return cobro;
        }
    }
}