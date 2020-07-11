using System;
using System.Collections.Generic;
using System.Linq;

namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso c = new Curso();

            if(c.EsExitoso())
                Console.WriteLine("el curso fue exitoso");
            else
                Console.WriteLine("el curso no fue exitoso");
        }
    }
}
