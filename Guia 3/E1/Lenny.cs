namespace E1
{
    public class Lenny : Empleado
    {
        int cervezasTomadas;

        public Lenny(){
            this.cervezasTomadas=0;
        }

        public bool EstaDistraido(){
            return cervezasTomadas>3;
        }
        
        public void TomaCerveza(){
            cervezasTomadas+=1;
        }

    }
}