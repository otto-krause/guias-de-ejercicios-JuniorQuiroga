using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int total=0;
            Argentina ar = new Argentina();
            ar.BajarPrecioPetroleo();
            ar.MillaiEnTV();
            ar.CoronaVairas();
            
            foreach (var alfajor in ar.GetLista)
            {
                total +=alfajor.Precio;
                //Console.WriteLine("total:"+total);
            }

            if(total<500)
            Console.WriteLine("El estado de la inflacion es normal");
            else
                if (total>500&&total<1000) 
                Console.WriteLine("El pais tiene super inflacion");
                else
                    if(total>1000){
                        Console.WriteLine("El pais tiene hyper inflacion");
                        Console.WriteLine("El pais esta en default");
                    }
        }
    }
}
