using System;
namespace E3
{
    public class LectoraDeCD : Componente
    {
        int precio;
        string conector;
        
        public string getConector() { return conector; }

        public LectoraDeCD(int precio,string conector){
            this.precio = precio;
            this.conector =conector;
        } 

        public int Precio(){
            return precio;
        }
        
        public bool EsCompatible(MotherBoard mother){
            string info= mother.getConector();
            string[] mother_conector = info.Split("/");
            
            return mother_conector[3]==conector;
        }
    }
}