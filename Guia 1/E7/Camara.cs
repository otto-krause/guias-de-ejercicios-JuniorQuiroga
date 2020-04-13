namespace E7
{
    public class Camara
    {
        float resolucion; //en megapixeles
        int cantidadFotos;
        
        //Constructor
        public Camara(float resolucion, int cantidadFotos){
            this.resolucion=resolucion;
            this.cantidadFotos=cantidadFotos;
        }

        //Metodos
        public float PesoPorFoto(){
            const int mega=1000000;
            return ((this.resolucion*mega)*3)/mega; //retorna el valor en MB
        }

        public float PesoTotalDeFotos(){
            return this.PesoPorFoto()*this.cantidadFotos; //retorna el peso total en MB
        } 
    }
}