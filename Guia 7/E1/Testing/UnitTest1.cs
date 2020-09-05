using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;
using System;

namespace Testing
{
    public class Tests
    {
        Peter_Parker peter;
        Spider_Noir noir;
        Spider_Gwen gwen;
        Miles_Morales miles;
        Kingpin kingpin;

        SpiderTeam equipo;


        [SetUp]
        public void Setup()
        {
            peter = new Peter_Parker(10,new Traje(15,null));
            noir = new Spider_Noir(10,new Traje(10,new List<Arma>(){new Arma("papaia",20),new Arma("alcachofa",5),new Arma("aguacate",10)}));
            gwen = new Spider_Gwen(10,new Traje(30,null),10);
            miles = new Miles_Morales(20,new Traje(60,null),15);
            kingpin = new Kingpin();

            equipo = new SpiderTeam(new List<Spiderman>(){peter,noir,gwen,miles});
        }

//Kingpin
        [Test]
        public void TestKingpinTiene800DeVida()
        {
            Assert.AreEqual(800, kingpin.Vida);
        }
//Peter Parker
        [Test]
        public void TestElPoderDePeterEsDe25()
        {
            Assert.AreEqual(25, peter.Poder());
        }

        [Test]
        public void TestPeterAtacaAKingpinYLeQueda775DeVida()
        {
            peter.Atacar(kingpin);
            Assert.AreEqual(775, kingpin.Vida);
        }
//Spider Noir
        [Test]
        public void TestElPoderDeNoirEsDe23()
        {
            Assert.AreEqual(23, noir.Poder());
        }

        [Test]
        public void TestNoirAtacaAKingpinYLeQueda777DeVida()
        {
            noir.Atacar(kingpin);
            Assert.AreEqual(777, kingpin.Vida);
        }

//Spider Gwen
        [Test]
        public void TestElPoderDeGwenEsDe20()
        {
            Assert.AreEqual(20, gwen.Poder());
        }

        [Test]
        public void TestGwenAtacaAKingpinYLeQueda780DeVida()
        {
            gwen.Atacar(kingpin);
            Assert.AreEqual(780, kingpin.Vida);
        }

        [Test]
        public void TestCuandoElGlamourDeGwenEsMayorA10SueltaUnError()
        {
            Assert.Throws<System.Exception>(() => new Spider_Gwen(10,new Traje(30,null),20));
        }

        [Test]
        public void TestCuandoElGlamourDeGwenEsMenorA0SueltaUnError()
        {
            Assert.Throws<System.Exception>(() => new Spider_Gwen(10,new Traje(30,null),-1));
        }
//Miles Morales
        [Test]
        public void TestElPoderDeMilesEsDe35()
        {
            Assert.AreEqual(35, miles.Poder());
        }

        [Test]
        public void TestMilesAtacaAKingpinYLeQueda765DeVida()
        {
            miles.Atacar(kingpin);
            Assert.AreEqual(765, kingpin.Vida);
        }

//Spider team
        [Test]
        public void TestLaFuerzaDelSpiderTeamEsDe50(){
            Assert.AreEqual(50, equipo.Fuerza());
        }

        [Test]
        public void TestElEquipoAtaca8AKingpinYLoVencen(){
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            Assert.IsTrue(kingpin.FueVencido());
        }

        [Test]
        public void TestElEquipoVencenAKingpinYElMasDebilVuelveACasa(){
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.VolverACasa(kingpin);
            Assert.That(equipo.Spiders, Does.Not.Contain(gwen));
        }

        [Test]
        public void TestElEquipoNoVencenAKingpinYTiraError(){
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            equipo.PelearConKingpin(kingpin);
            Assert.Throws<System.Exception>(() => equipo.VolverACasa(kingpin));
        }
    }
}