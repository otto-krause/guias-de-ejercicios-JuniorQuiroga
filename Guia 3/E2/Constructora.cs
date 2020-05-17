using System.Collections.Generic;
using System;

namespace E2
{
    public class Constructora
    {
        List<Contratista> lista_Contratista = new List<Contratista>();

        public Constructora(){
            lista_Contratista.Add(new Pintor());
            lista_Contratista.Add(new Pintor());
            lista_Contratista.Add(new Pintor());
            lista_Contratista.Add(new Pintor());
            lista_Contratista.Add(new Pintor());
            lista_Contratista.Add(new Plomero());
            lista_Contratista.Add(new Plomero());
            lista_Contratista.Add(new Plomero());
            lista_Contratista.Add(new Plomero());
            lista_Contratista.Add(new Plomero());
            lista_Contratista.Add(new Albañil(30,false));
            lista_Contratista.Add(new Albañil(26,false));
            lista_Contratista.Add(new Albañil(22,true));
            lista_Contratista.Add(new Albañil(40,false));
            lista_Contratista.Add(new Albañil(70,true));
        }

        public bool PresupuestoSuficiente(int presupuesto, int horas){
            int total_cobro=0;
            foreach (var trabajador in lista_Contratista)
            {
                trabajador.Trabajar(horas);
                total_cobro+=trabajador.Cobrar();
                
            }
            return total_cobro <= presupuesto;
        }
    }
}