using System;

namespace E4
{
    class Program
    {
        static int ingreso(){
            Console.WriteLine("ingrese el monto a retirar");
            return Int32.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int menu;
            Empleado Jose = new RRHH(5);
            Empleado Felipe = new Administrativo();
            Empleado Rojelia = new Programador("Senior");
            
            Console.WriteLine("depositar a\n [1]RRHH\n [2]administrativo\n [3]programador \nextraer de\n [4]RRHH\n [5]administrativo\n [6]programador \n[0]salir");
            do{
                Console.WriteLine("sueldo RRHH: {0} \nsueldo administrativo: {1} \nsueldo programador: {2}",Jose.Dinero,Felipe.Dinero,Rojelia.Dinero);
                menu=Int32.Parse(Console.ReadLine());
                switch (menu){
                    case 1:
                        Jose.Depositar();
                    break;

                    case 2:
                        Felipe.Depositar();
                    break;
                    
                    case 3:
                        Rojelia.Depositar();
                    break;
                    
                    case 4:
                        Jose.Extraer(ingreso());
                    break;

                    case 5:
                        Felipe.Extraer(ingreso());
                    break;
                    
                    case 6:
                        Rojelia.Extraer(ingreso());
                    break;
                    

                    default:
                    break;
                }
            }while(menu!=0);
        }
    }
}
