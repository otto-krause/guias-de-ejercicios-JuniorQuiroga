using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Niño:Asustador
    {
        private string estado;
        public string Estado{get => estado;}

        public Niño(Maquillaje maquillaje, Traje traje, int caramelos):base(){
            this.maquillaje = maquillaje;
            this.traje = traje;
            this.capacidades = maquillaje.Puntos + traje.Puntos;
            this.caramelos = caramelos;
            this.estado = "sano";
        }

        public override void Asustar(Adulto adulto){
            if (estado!="en cama")
                caramelos += adulto.SeAsusta(this);
            else
                throw new Exception("Esta en cama");
        }

        public void Comer(int cantidad){
            if(estado != "en cama"){
                if(caramelos - cantidad > 0){
                    caramelos -= cantidad;

                    if(cantidad>10 && estado=="sano")
                        estado = "empachado";
                    else if(cantidad >10 && estado == "empachado")
                        estado = "en cama";
                }
                else
                    caramelos =0;
            }
        }
    }
}