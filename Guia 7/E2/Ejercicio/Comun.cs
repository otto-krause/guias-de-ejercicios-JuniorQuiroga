using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Comun:Adulto
    {
        public Comun(){

        }

        public override int SeAsusta(Niño niño){
            int niñosAnteriores= caramelosDeNiños.Where(c => c>15).Count();   
            
            //revisa si algun niño a pasado antes con mas de 15 caramelos
            if(niñosAnteriores >0)
                tolerancia = 10 * niñosAnteriores;
            //agrega la cantidad de caramelos del niño a su lista
            caramelosDeNiños.Add(niño.Caramelos);
            //revisa que su tolerancia sea menor a la capacidad del niño y que no sea 0
            return tolerancia < niño.Capacidad && tolerancia!=0 ? tolerancia/2 : 0;
        }
    }
}