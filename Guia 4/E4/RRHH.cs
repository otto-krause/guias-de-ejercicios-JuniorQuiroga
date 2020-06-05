namespace E4
{
    public class RRHH: Empleado
    {
        int referidos;
        public RRHH(int referidos){
            this.referidos= referidos;
        }

        public override void Depositar(){
            CajaBancaria += 5000 + 5000*referidos;
        }
    }
}