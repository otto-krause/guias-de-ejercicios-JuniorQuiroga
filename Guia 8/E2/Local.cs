using System.Collections.Generic;
namespace E2
{
    public class Local
    {
        public Coordenadas coordenadas { get; set; } 
        public string nombre { get; set; } 
        public string direccion { get; set; } 
        public List<Empleado> empleados { get; set; } 
    }
}