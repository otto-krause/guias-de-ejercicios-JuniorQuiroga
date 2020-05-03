using System.Collections.Generic;
using System;

namespace E7
{
    public class Argentina
    {
        List<Alfajor> lista_alfajores = new List<Alfajor>();
        public List<Alfajor> GetLista {get => lista_alfajores;}

        public Argentina(){
            Alfajor a1 = new Alfajor("Jorjito","Jorjito",60);
            Alfajor a2 = new Alfajor("Triple fruta","Waymayen",100);
            Alfajor a3 = new Alfajor("Waymayen","Waymayen",40);
            Alfajor a4 = new Alfajor("Capitan del Espacio","Capitan del Espacio",70);
            
            lista_alfajores.Add(a1);
            lista_alfajores.Add(a2);
            lista_alfajores.Add(a3);
            lista_alfajores.Add(a4);
        }

        public void BajarPrecioPetroleo(){
            foreach (Alfajor alfajor in lista_alfajores)
            {
                alfajor.Precio +=80;
            }
        }
        public void MillaiEnTV(){
            foreach (Alfajor alfajor in lista_alfajores)
            {
                alfajor.Precio *=2;
            }
        }

        public void CoronaVairas(){
            foreach (Alfajor alfajor in lista_alfajores)
            {
                if (alfajor.Nombre!="Waymayen")
                alfajor.Precio += 1000;
            }
        }
        
    }
}