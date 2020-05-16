namespace E1
{
    public class Planta
    {
        int barras_de_uranio;
        Mr_Burns burns;
        public Mr_Burns getBurns{get => burns;} 

        private Empleado empleado;

        public Planta(int barras_de_uranio, Empleado empleado){
            this.barras_de_uranio=barras_de_uranio;
            this.burns = new Mr_Burns();
            this.empleado=empleado;
        }

        public bool EstaEnPeligro(){
            return (barras_de_uranio >10000 && empleado.EstaDistraido()) || !burns.EsMillonario();
        }

        public void CambiarEmpleado(Empleado nuevoEmpleado){
            empleado = nuevoEmpleado;
        }

        public void setBarras(int value){
            barras_de_uranio +=value;
        }
    }
}