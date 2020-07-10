namespace E3
{
    public class CaballeroDelZodiaco
    {
        string nombre;
        string dios;
        Armadura armadura;
        string signo;

        public string Nombre{get => nombre;}
        public string Dios{get => dios;}
        public Armadura Armadura{get => armadura;}
        public string Signo{get => signo;}

        public CaballeroDelZodiaco(string nombre, string dios, Armadura armadura, string signo){
            this.nombre = nombre;
            this.dios = dios;
            this.armadura= armadura;
            this.signo = signo;
        }
    }
}