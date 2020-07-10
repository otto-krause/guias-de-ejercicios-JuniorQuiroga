using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    public class Persona
    {
        List<string> conocimientos = new List<string>();

        public Persona(){
            conocimientos.Add("ciencias");
            conocimientos.Add("arte");
            conocimientos.Add("bombas atomicas");
            conocimientos.Add("Manipurlacion");
            conocimientos.Add("leer");
            conocimientos.Add("humanidades");
            conocimientos.Add("floristeria");
        } 

        public List<string> UltimosConocimientos(){
            return conocimientos.Skip(conocimientos.Count()-5).ToList();
        }

        public List<string> PrimerosConocimientos(){
            return conocimientos.Take(conocimientos.Count-(conocimientos.Count-4)).ToList();
        }

        public List<string> Terminacion(){
            return conocimientos.Where(c => c.Contains("cion")||c.Contains("ción")).ToList();
        }
    }
}