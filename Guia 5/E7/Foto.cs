namespace E7
{
    public class Foto
    {
        string dir;
        string fecha;
        string etiquetas;
        public string Direccion { get => dir; }
        public string Fecha { get=> fecha; }
        public string Etiquetas { get=> etiquetas; }

        public Foto(string dir, string fecha, string etiquetas){
            this.dir = dir;
            this.fecha = fecha;
            this.etiquetas = etiquetas;
        }
    }
}