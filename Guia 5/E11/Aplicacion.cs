namespace E11
{
    public class Aplicacion
    {
        int tiempoDeUso;
        int cantidadDeToques;
        int tiempoDeUsoTeclado;
        string permisos;
        string nombre;
        public string Nombre{get=>nombre;}
        public string Permisos{get=>permisos;}

        public Aplicacion(int tiempoDeUso,int cantidadDeToques,int tiempoDeUsoTeclado,string permisos,string nombre){
            this.tiempoDeUso = tiempoDeUso;
            this.cantidadDeToques = cantidadDeToques;
            this.tiempoDeUsoTeclado = tiempoDeUsoTeclado;
            this.permisos = permisos;
            this.nombre = nombre;
        }
        
        //tps
        public float Interaccion(){
            return cantidadDeToques/tiempoDeUso;
        }

        //porcentaje
        public float InteraccionTeclado(){
            return tiempoDeUsoTeclado/tiempoDeUso;
        }
    }
}