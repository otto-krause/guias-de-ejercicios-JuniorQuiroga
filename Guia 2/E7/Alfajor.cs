namespace E7
{
    public class Alfajor
    {
        string nombre;
        string fabricante;
        int precio=0;
        public string Nombre { get => nombre; }
        public int Precio { get => precio; set => precio = value; }
    
        public Alfajor(string nombre,string fabricante,int precio){
            this.precio = precio;
            this.fabricante = fabricante;
            this.nombre = nombre;
        }
    }
}