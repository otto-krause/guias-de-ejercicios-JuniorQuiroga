namespace E4
{
    public class Administrativo:Empleado
    {
        public Administrativo(){
                
        }

        public override void Depositar(){
            CajaBancaria += 35000;
        }
    }
}