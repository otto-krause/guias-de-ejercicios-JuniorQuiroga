namespace Ejercicio
{
    public class Ciudadano
    {
        private int dinero;
        private string clase;
        
        public string Clase{get =>clase;}
        public int Dinero{get => dinero;
                          set => dinero = value;}

        public Ciudadano(int dinero){
            this.dinero = dinero;
            if(dinero > 5000000)
            this.clase="rico";
            else if(dinero >=1000000)
            this.clase="media";
            else
            this.clase="baja";
        }

    }
}