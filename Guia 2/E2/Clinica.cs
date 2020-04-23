using System.Collections.Generic;

namespace E2
{
    public class Clinica
    {
        List<Medico> medicos= new List<Medico>();

        public Clinica(){
            Medico Pepito = new Medico("Pepito","Fuentes","cirujano",40);
            Medico Rosa = new Medico("Rosa","Maria","pediatra",20);
            this.medicos.Add(Pepito);
            this.medicos.Add(Rosa);
        }

        public List<Medico> DarLista(){
            return medicos;
        }
    }
}