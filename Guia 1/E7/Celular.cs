namespace E7
{
    public class Celular
    {
        bool NFC;
        bool Bluethoot;
        int almacenamientoDisponible; //en megabytes
        int cantidadAplicaciones;

        Camara Trasera = new Camara(5,900);
        Camara Frontal = new Camara(3,200);

        //Constructor
        public Celular(bool NFC, bool Bluethoot, int almacenamientoDisponible,int cantidadAplicaciones){
            this.NFC=NFC;
            this.Bluethoot=Bluethoot;
            this.almacenamientoDisponible=almacenamientoDisponible;
            this.cantidadAplicaciones=cantidadAplicaciones;
        }

        public float MemoriaDisponible(){
            float pesoDeFotos=(Trasera.PesoTotalDeFotos()+Frontal.PesoTotalDeFotos()); 
            int pesoDeAplicaciones=this.cantidadAplicaciones*70;
            return this.almacenamientoDisponible-(pesoDeFotos+pesoDeAplicaciones);
        }

        public bool TeCargaLaSUBE(){
            return this.NFC;
        }
    }
}