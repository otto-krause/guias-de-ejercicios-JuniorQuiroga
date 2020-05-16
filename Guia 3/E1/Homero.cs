namespace E1
{
    public class Homero : Empleado
    {
        int donas=1;

        public Homero(int donas){
            this.donas=donas;
        }

        public bool EstaDistraido(){
            return donas < 2;
        }

        public void comprar(){
            donas+=12;
        }

        public void comer(){
            donas-=1;
        }

    }
}