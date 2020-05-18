using System;

namespace E3
{
    class Program
    {
        static int ingresar_precio(){
            return Int32.Parse(Console.ReadLine());
        } 
        static string ingresar_conector(){
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int precio;
            string conector;

//Creacion de mother board
            Console.WriteLine("ingrese los datos de la Mother Board \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" socket");
            string socket= Console.ReadLine();
            Console.WriteLine(" tipo de ram (SDRAM,DDR4)");
            string ram_slot= Console.ReadLine();
            Console.WriteLine(" tipo de pci (PCI-E,PCI)");
            string pci_type= Console.ReadLine();
            Console.WriteLine(" tipo de conector de almacenamiento (IDE,SATA)");
            string storage_slot= Console.ReadLine();
            MotherBoard MB = new MotherBoard(precio,socket,ram_slot,pci_type,storage_slot); 

//Creacion de procesador
            Console.WriteLine("\ningrese los datos del procesador: \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" socket");
            conector=ingresar_conector();
            Procesador cpu = new Procesador(precio,conector);

//Creacion de memoria ram
            Console.WriteLine("\ningrese los datos de la memoria RAM: \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" tipo de ram (SDRAM,DDR4)");
            conector=ingresar_conector();
            MemoriaRAM RAM = new MemoriaRAM(precio,conector);

//Creacion de placa de video
            Console.WriteLine("\ningrese los datos de la placa de video: \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" tipo de pci (PCI-E,PCI)");
            conector=ingresar_conector();
            PlacaDeVideo video = new PlacaDeVideo(precio,conector); 
            
//Creacion de disco ssd
            Console.WriteLine("\ningrese los datos del disco SSD: \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" tipo de conector (IDE,SATA)");
            conector=ingresar_conector();
            DiscoSSD ssd = new DiscoSSD(precio,conector); 
            
//Creacion de disco hdd
            Console.WriteLine("\ningrese los datos del disco HDD: \n Precio");
            precio=ingresar_precio();
            Console.WriteLine(" tipo de conector (IDE,SATA)");
            conector=ingresar_conector();
            DiscoHDD hdd = new DiscoHDD(precio,conector); 

//Creacion de lector de cd
            Console.WriteLine("\ningrese los datos del lector de CD: \n Ingrese el precio");
            precio=ingresar_precio();
            Console.WriteLine(" tipo de conector(IDE,SATA)");
            conector=ingresar_conector();
            LectoraDeCD lectora_cd = new LectoraDeCD(precio,conector);

//creacion de pc
            PC pc_jamer = new PC(MB,cpu,RAM,video,ssd,hdd,lectora_cd);
            
            Console.WriteLine("\nEl costo total del PC es: $"+pc_jamer.PrecioTotal());
            
            if(pc_jamer.SePuedeArmar())
            Console.WriteLine("Es posible montar el PC");
            else
            Console.WriteLine("Los componenetes son incompatibles");
        }
    }
}
