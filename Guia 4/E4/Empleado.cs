namespace E4
{
    public class Empleado
    {
        protected int CajaBancaria;
        public int Dinero{get=>CajaBancaria;}

        public virtual void Depositar(){
        }

        public virtual void Extraer(int monto){
            CajaBancaria -=monto;
        }
    }
}