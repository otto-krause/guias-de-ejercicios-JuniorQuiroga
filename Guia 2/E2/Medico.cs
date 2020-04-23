namespace E2
{
    public class Medico
    {
        string nombre,apellido,especialidad;
        int cantidad_turnos;

        public Medico(string nombre,string apellido,string especialidad,int cantidad){
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidad_turnos=cantidad;
        } 

        public bool EstaDisponible(){
            return cantidad_turnos <50;
        }

        public string DarEspecialidad(){
            return especialidad;
        }
        public string DarNombre(){
            return nombre;
        }
    }
}