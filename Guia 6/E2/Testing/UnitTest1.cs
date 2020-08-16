using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Testing
{
    public class Tests
    {
        private Alumno HarryPostre;
        private List<Receta> recetas;

        private List<Ingrediente> ingredientes;

        [SetUp]
        public void Setup()
        {
            ingredientes = new List<Ingrediente>(){new Ingrediente(400),new Ingrediente(400),new Ingrediente(400)};
            
            recetas = new List<Receta>(){new Receta(ingredientes,2), new Receta(ingredientes,2)};
            HarryPostre = new Alumno(new Carpe(10),recetas);
        }


        [Test]
        public void TestSaberSiTodosLasRecetasSonDeGordos()
        {
            Assert.IsFalse(recetas.All(r => r.esDeGordo()));
        }

        [Test]
        public void TestSaberSiAlgunaRecetaEsRapida()
        {
            Assert.IsTrue(recetas.Any(r => r.esRapida()));
        }

        [Test]
        public void TestSaberSiHarryEsUnLento()
        {
            Assert.IsFalse(HarryPostre.esUnLento());
        }

        [Test]
        public void TestSaberSiHarryNoSeCuida()
        {
            Assert.IsFalse(HarryPostre.noSeCuida());
        }
    }
}