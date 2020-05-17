using System;

namespace E2
{
    public class Albañil : Contratista
    {
        int edad;
        int costo;
        bool titulo;
        
        public Albañil(int edad,bool titulo){
            this.edad=edad;
            this.titulo=titulo;
        }

        public void Trabajar(int horas){
            if(edad >=20||edad<=30)
                costo=horas*50;
            else if(edad>30|| edad<=50)
                costo=horas*90;
                else if(edad>50)
                    costo=horas*120;
            
            if (titulo)
                costo+=50;
        }

        public int Cobrar(){
            return costo;
        }
    }
}