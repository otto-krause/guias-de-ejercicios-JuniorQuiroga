namespace E4
{
    public class Medico
    {
        string nombre;
        string apellido;
        string especialidad;
        int cantidad_turnos;

        public string Especialidad {get => especialidad;}
        public string Nombre{get => nombre;}
        public string Apellido{get => apellido;}

        public Medico(string nombre,string apellido,string especialidad,int cantidad){
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidad_turnos=cantidad;
        } 

        public bool EstaDisponible(){
            return cantidad_turnos <50;
        }

        public void SumarTurno(){
            cantidad_turnos++;
        }
    }
}