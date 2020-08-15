using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        private Arma BastonDeMetal;
        private Arma BombasDeHumo;
        Robin robin;
        Chico_Bestia bestia;
        Raven raven;

        [SetUp]
        public void Setup()
        {
            BastonDeMetal = new Arma(15,10);
            BombasDeHumo = new Arma(14,89);
            robin = new Robin(new List<Arma>{BastonDeMetal,BombasDeHumo} , 10 );
            bestia = new Chico_Bestia("Verde",2);
            raven = new Raven(new List<string>(){"Extraño a mi Papi", "Me quedé sin MANTECA", "Perdí a Pipo", "Voy a comprar pilas para Robocop", "¿Donde esta Pipo?"},2 );
        }
        

        //1
        [Test]
        public void TestRavenCome4PorcionesDePizzaLuegoSaberSiEstaTriste()
        {
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            Assert.AreEqual(true, raven.estaTriste());
        }
        
        //2
        [Test]
        public void TestChicoBestiaComePizzaSaberSiSuPoderEsDe871()
        {
            bestia.comerPizza();
            Assert.AreEqual(871, bestia.poder());
        }

        //3
        [Test]
        public void TestConocerPoderDelBastonDeMetal()
        {
            Assert.AreEqual(620,BastonDeMetal.Fuerza());
        }

        //4
        [Test]
        public void TestChicoBestiaComePizzaSaberSiElPoderDeRavenEsMayorAlDeLosDemasTitanes()
        {
            bestia.comerPizza();
            Assert.IsFalse(raven.poder()>robin.poder() && raven.poder() >bestia.poder());
        }
        
        //5
        [Test]
        public void TestChicoBestiaLloraPorRobocopSaberNivelDeTristeza()
        {
            bestia.llorarPorRobocop();
            Assert.AreEqual(0, bestia.getTristeza);
        }

        //6
        [Test]
        public void TestRobinLlora2VecesPorRobocopYSecalculaQueSuPoderSea598()
        {
            robin.llorarPorRobocop();
            robin.llorarPorRobocop();
            Assert.AreEqual(598, robin.poder());
        }

        //7
        [Test]
        public void TestRavenLlora2vecesPorRobocopLuegoSaberSiEstaTriste()
        {
            raven.llorarPorRobocop();
            raven.llorarPorRobocop();
            Assert.IsFalse(raven.estaTriste());
        }
    }
}