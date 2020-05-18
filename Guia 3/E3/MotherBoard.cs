namespace E3
{
    public class MotherBoard : Componente
    {
        int precio;
        string socket;
        string slot_memoria;
        string slot_almacenamiento;
        string pci_type;

        public string getConector(){ 
            return socket+"/"+slot_memoria+"/"+slot_almacenamiento+"/"+pci_type;
        }

        public MotherBoard(int precio,string socket,string memoria,string almacenamiento,string pci){
            this.precio = precio;
            this.socket = socket;
            this.slot_memoria = memoria;
            this.slot_almacenamiento = almacenamiento;
            this.pci_type = pci;
        }

        public int Precio(){
            return precio;
        }
        
        public bool EsCompatible(MotherBoard mother){
            return true;
        } 
    }
}