using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0;
            SerPensante s1 = new Humano();
            SerPensante s2 = new Robot();
            SerPensante s3 = new Cyborg();

            do{
                Console.WriteLine("Puntos de inteligencia\n Humano: {0}\n Robot: {1}\n Cyborg: {2}",s1.getPuntos,s2.getPuntos,s3.getPuntos);
                Console.WriteLine("[1]humano estudia \n[2]humano piensa \n[3]robot estudia \n[4]robot piensa \n[5]cyborg estudia \n[6]cyborg piensa \n[0]salir");
                menu=Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ingrese el objeto de estudio");
                        s1.Estudiar(Console.ReadLine());
                    break;

                    case 2:
                        Console.WriteLine("ingrese el objeto de pensamiento");
                        s1.Pensar(Console.ReadLine());
                    break;
                    
                    case 3:
                        Console.WriteLine("ingrese el objeto de estudio");
                        s2.Estudiar(Console.ReadLine());
                    break;
                    
                    case 4:
                        Console.WriteLine("ingrese el objeto de pensamiento");
                        s2.Pensar(Console.ReadLine());
                    break;

                    case 5:
                        Console.WriteLine("ingrese el objeto de estudio");
                        s3.Estudiar(Console.ReadLine());
                    break;

                    case 6:
                        Console.WriteLine("ingrese el objeto de pensamiento");
                        s3.Pensar(Console.ReadLine());
                    break;
                }
            }while(menu!=0);
        }
    }
}
