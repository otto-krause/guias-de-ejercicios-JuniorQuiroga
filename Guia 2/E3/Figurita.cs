namespace E3
{
    public class Figurita
    {
        string nombre,posicion,pais;
        int numero=0;

        public Figurita(string nombre,string posicion,string pais,int numero){
            this.nombre=nombre;
            this.posicion=posicion;
            this.pais=pais;
            this.numero=numero;
        }

        public string GetInfo(){
            return nombre+"/"+posicion+"/"+pais+"/"+numero;
        }
    }
}