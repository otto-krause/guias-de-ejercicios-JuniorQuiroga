namespace E1
{
    public class Mr_Burns
    {
        bool riquerzas;

        public Mr_Burns(){
            this.riquerzas=true;
        }

        public bool EsMillonario(){
            return riquerzas;
        }

        public void despojarseDeRiquezas(){
            riquerzas = false;
        }
    }
}