namespace E4
{
    public class Programador:Empleado
    {
        string tipo;
        public Programador(string tipo){
            this.tipo=tipo;
        }

        public override void Depositar(){
            CajaBancaria+=20000;
            switch (tipo)
            {
                case "junior":
                    CajaBancaria+=10000;
                break;

                case "SemiSenior":
                    CajaBancaria+=20000;
                break;

                case "Senior":
                    CajaBancaria+=40000;
                break;
            }
        }
    }
}