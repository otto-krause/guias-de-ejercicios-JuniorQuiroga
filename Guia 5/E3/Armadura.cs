namespace E3
{
    public class Armadura
    {
        string nombre;
        string material;
        public string Nombre{get => nombre;}
        public string Material{get => material;}

        public Armadura(string nombre, string material){
            this.nombre = nombre;
            this.material = material;
        }
    }
}