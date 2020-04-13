using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            float almacenamiento=0;            
            Celular movil = new Celular(true, true, 16000, 6);
            

            Console.WriteLine("[1]ver memoria disponible \n[2]¿puede cargar la SUBE?");
            switch (Console.ReadLine())
            {
                case "1":
                    almacenamiento = movil.MemoriaDisponible();
                    Console.WriteLine("le queda "+almacenamiento+"MB dispónible");
                break;

                case "2":
                    if(movil.TeCargaLaSUBE())
                    Console.WriteLine("Si puede cargar la sube");
                    else
                    Console.WriteLine("No puede cargar la sube");
                break;

                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }
}
