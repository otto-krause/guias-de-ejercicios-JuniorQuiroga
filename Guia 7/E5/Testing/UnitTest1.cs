using NUnit.Framework;
using System;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        Persona romelio;
        Villano jose;
        Villano v0;
        Villano v1;
        Villano v2;
        Villano v3;
        Pandilla pandilla;
        Pandilla pandillaYJefe;

        Heroe endeavor;

        [SetUp]
        public void Setup()
        {
            endeavor = new Heroe(new Quirk("Hell Flame",300,false));

            v0 = new Villano(true,false,false,new Quirk("aplasta perritos",34,false));
            v1 = new Villano(true,true,true,new Quirk("event horizon",10,true));
            v2 = new Villano(true,false,false,new Quirk("papaias intensas",6,true));

            v3 = new Villano(true,true,true,new Quirk("Hackear la nasa con HTML",600,true));
            pandilla = new Pandilla(new List<Villano>(){v0,v1,v2});
            pandillaYJefe = new Pandilla(new List<Villano>(){v0,v1,v2,v3});
        }

    #region ejercicio
        [Test]
        public void TestElQuirkDeEndeavorEsPeligroso()
        {
            Assert.IsFalse(endeavor.suQuirk.EsPeligroso);
        }
        
        [Test]
        public void TestEndeavorDerrotaAUnVillano()
        {
            endeavor.Luchar(v0);
            Assert.AreEqual(1, endeavor.Victorias);
        }

        [Test]
        public void TestEndeavorDerrotaAUnaPandilla()
        {
            endeavor.Luchar(pandilla);
            Assert.AreEqual(3, endeavor.Victorias);
        }

        [Test]
        public void TestEndeavorDerrotaAUnaPandillaYElJefeYPierde()
        {
            endeavor.Luchar(pandillaYJefe);
            Assert.AreEqual("acta de defuncion", endeavor.Papeles);
        }


    #endregion

    #region standard
        [Test]
        public void TestRomelioNoEsPeligroso()
        {
            romelio = new Persona(new Quirk("destripador de mares",15,true));
            Assert.IsFalse(romelio.suQuirk.EsPeligroso);
        }

        [Test]
        public void TestRomelioEsPeligroso()
        {
            romelio = new Persona(new Quirk("El todo poderosisimo destructor de huesos",960,false));
            Assert.IsTrue(romelio.suQuirk.EsPeligroso);
        }

        [Test]
        public void TestJoseAlgunaVezFueBueno()
        {
            jose = new Villano(true,false,true,new Quirk("aplasta perritos",10,false));
            Assert.IsTrue(jose.FueBueno);
        }

        [Test]
        public void TestEsMuyMalo()
        {
            jose = new Villano(true,true,true,new Quirk("aplasta perritos",10,false));
            Assert.IsTrue(jose.MuyMalo);
        }
        
    #endregion
       
    }
}