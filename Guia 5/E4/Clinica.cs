using System.Collections.Generic;

namespace E4
{
    public class Clinica
    {
        List<Medico> medicos= new List<Medico>();
        public List<Medico> Lista{get => medicos;}

        public Clinica(){
            Medico Pepito = new Medico("Pepito","Fuentes","cirujano",55);
            Medico Rosa = new Medico("Rosa","Maria","pediatra",49);
            Medico Rojelio = new Medico("Rojelio","Puentes","pediatra",49);
            this.medicos.Add(Pepito);
            this.medicos.Add(Rosa);
            this.medicos.Add(Rojelio);
        }

    }
}