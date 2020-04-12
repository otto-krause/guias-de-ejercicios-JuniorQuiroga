namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;


        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre = nombre;
            this.vacunas = vacunas;
            this.energia = energia;
        }

        public string Nombre(){
            return nombre;
        }

        public bool EstaVacunado(){
            return vacunas;
        }

        public int Jugar(int minutos){
            return energia -= 2*minutos;
        }

        public int Comer(){
            return energia+50;
        } 

        public bool EstaSaludable(){
            return vacunas&&energia>30;
        }
    }
}