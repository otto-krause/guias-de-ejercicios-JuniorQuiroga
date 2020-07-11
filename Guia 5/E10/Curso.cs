using System;
using System.Collections.Generic;
using System.Linq;

namespace E10
{
    public class Curso
    {
        List<ExAlumno> alumnos = new List<ExAlumno>();
        public Curso(){
            //viajeros
            alumnos.Add(new ExAlumno(5,2,20000));
            alumnos.Add(new ExAlumno(9,2,20260));
            alumnos.Add(new ExAlumno(8,2,24000));
            alumnos.Add(new ExAlumno(7,2,21300));
            //exitosos
            alumnos.Add(new ExAlumno(4,2,200500));
            alumnos.Add(new ExAlumno(4,2,200500));
            alumnos.Add(new ExAlumno(0,2,200500));
            alumnos.Add(new ExAlumno(1,2,280500));
            alumnos.Add(new ExAlumno(4,2,250500));
            alumnos.Add(new ExAlumno(6,2,230500));
            //poliglotas
            alumnos.Add(new ExAlumno(6,7,25400));
            alumnos.Add(new ExAlumno(6,6,20450));
        }

        public bool EsExitoso(){
            List<ExAlumno> viajeros = new List<ExAlumno>();
            List<ExAlumno> poliglotas = new List<ExAlumno>();
            List<ExAlumno> exitosos = new List<ExAlumno>();

            viajeros = alumnos.Where(a => a.Viajes>4).ToList();
            poliglotas = alumnos.Where(a => a.Idiomas>5).ToList();
            exitosos = alumnos.Where(a => a.Ganancias>200000).ToList();

            return alumnos.All(a => a.Idiomas>1 && exitosos.Count>5 && viajeros.Count>3 && poliglotas.Count>1);
        }
    }
}