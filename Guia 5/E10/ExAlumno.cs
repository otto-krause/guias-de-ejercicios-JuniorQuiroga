namespace E10
{
    public class ExAlumno
    {
        int viajes;
        int idiomas;
        int ganancias;

        public int Viajes{get => viajes;}
        public int Idiomas{get => idiomas;}
        public int Ganancias{get => ganancias;}

        public ExAlumno(int viajes, int idiomas, int ganancias){
            this.viajes = viajes;
            this.idiomas = idiomas;
            this.ganancias = ganancias;
        }
    }
}