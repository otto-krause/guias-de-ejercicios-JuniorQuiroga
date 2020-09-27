using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Isla_Cerdo
    {
        private List<Obstaculo> obstaculos;
        public List<Obstaculo> Obstaculos{get => obstaculos;}
    
        public Isla_Cerdo(List<Obstaculo> obstaculos){
            this.obstaculos=obstaculos;
        }
    }
}