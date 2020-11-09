using NUnit.Framework;
using System;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        Persona romelio;
        Heroe endeavor;
        Heroe oruMaito;
        Heroe arturoMirodilla;

        //villanos
            Villano v0;
            Villano v1;
            Villano v2;
            Villano v3;
            Pandilla pandilla;
            Pandilla pandillaYJefe;

        //quirks
            Quirk hellFlame;
            Quirk aplastaPerritos;
            Quirk horizon;
            Quirk papaias;
            Quirk hackerHTML;

            Quirk oneForAll;
            Quirk allForOne;


        [SetUp]
        public void Setup()
        {
            #region quirks
                oneForAll = new Quirk("One For All",100,true);
                allForOne = new Quirk("All For One",100,true);

                hellFlame = new Quirk("Hell Flame",300,false);
                aplastaPerritos = new Quirk("aplasta perritos",34,false);
                horizon = new Quirk("event horizon",10,true);
                papaias = new Quirk("papaias intensas",6,true);
                hackerHTML = new Quirk("Hackear la nasa con HTML",600,true);

            #endregion

            #region villanos
                v0 = new Villano(true,false,false,aplastaPerritos);
                v1 = new Villano(true,true,true,horizon);
                v2 = new Villano(true,false,false,papaias);

                v3 = new Villano(true,true,true,hackerHTML);
                pandilla = new Pandilla(new List<Villano>(){v0,v1,v2});
                pandillaYJefe = new Pandilla(new List<Villano>(){v0,v1,v2,v3});
            #endregion

            romelio = new Persona(allForOne);
            endeavor = new Heroe(hellFlame);
            oruMaito = new Heroe(oneForAll);
            arturoMirodilla = new Heroe(papaias);
        }

    #region parte 2
    
        [Test]
        public void TestOruMaitoTraspasaSuQuirk()
        {
            oruMaito.Traspasar(arturoMirodilla);
            Assert.AreEqual("One For All",arturoMirodilla.suQuirk.Nombre);
        }
    
        [Test]
        public void TestOruTraspasaSuQuirkARomelioYEsteConservaElOriginalJuntoAlNuevo()
        {
            oruMaito.Traspasar(romelio);
            Assert.IsTrue(oneForAll==romelio.suQuirk && allForOne == romelio.QuirkOriginal);
        }

        [Test]
        public void TestUsaAllForOneYRobaLosQuirkDeOruEndeavorYArturo(){
            romelio.Robar(endeavor);
            romelio.Robar(oruMaito);
            romelio.Robar(arturoMirodilla);
            Assert.AreEqual(new List<Quirk>(){hellFlame,oneForAll,papaias},romelio.suQuirk.Robados);
        }
        
        [Test]
        public void TestRobaLosQuirkDeOruEndeavorYArturoYSuPOderEsDe(){
            romelio.Robar(endeavor);
            romelio.Robar(oruMaito);
            romelio.Robar(arturoMirodilla);
            Assert.AreEqual(4196,romelio.suQuirk.Poder());
        }
        
        [Test]
        public void TestRobaLosQuirkDeOruEndeavorYArturoYEsPeligroso(){
            romelio.Robar(endeavor);
            romelio.Robar(oruMaito);
            romelio.Robar(arturoMirodilla);
            Assert.IsTrue(romelio.suQuirk.Peligroso());
        }
        
        [Test]
        public void TetsTraspasaSuQuirkAEndeavorEsteAArturoYSuPoderEsDe1430()
        {
            oruMaito.Traspasar(endeavor);
            endeavor.Traspasar(arturoMirodilla);
            Assert.AreEqual(1430,arturoMirodilla.suQuirk.Poder());
        }

        [Test]
        public void TestOneForAllEsPeligroso()
        {
            Assert.IsTrue(oruMaito.suQuirk.Peligroso());
        }


    #endregion

    #region ejercicio
        [Test]
        public void TestElQuirkDeEndeavorEsPeligroso()
        {
            Assert.IsTrue(endeavor.suQuirk.Peligroso());
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

    }
}