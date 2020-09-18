using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        Batman batman;
        Psicopata psico;
        Ladron blanco;
        Ladron marron;
        Ladron robin;
        Extraterrestre et;

        Herramienta h1;
        Herramienta h2;

        List<Herramienta> batiCinturon;
        List<Villano> pandilla;
        List<Ciudadano> ciudadanos;

        Ciudadano c1;
        Ciudadano c2;
        Ciudadano c3;
        Ciudadano c4;
        Ciudadano c5;
        Ciudadano c6;
        

        [SetUp]
        public void Setup()
        {
            //1
            h1 = new Herramienta("bati_navaja",6,2);
            h2 = new Herramienta("bati_lazo",10,7);
            batiCinturon = new List<Herramienta>(){h1,h2};
            batman = new Batman(batiCinturon);

            psico = new Psicopata(10);
            marron = new Guante_Marron();
            blanco = new Guante_Blanco();
            robin = new Robin_Hood();
            et = new Extraterrestre(2);

            c1 = new Ciudadano(10000000);
            c2 = new Ciudadano(1000000);
            c3 = new Ciudadano(5000);
            c4 = new Ciudadano(2000000);
            c5 = new Ciudadano(5000);
            c6 = new Ciudadano(5000);

            pandilla = new List<Villano>(){blanco,marron,psico};

            ciudadanos = new List<Ciudadano>(){c1,c2,c3,c4,c5,c6};

            int cant = ciudadanos.Count();
        }

    #region 1
        //2
        [Test]
        public void TestBatmanNoEstaEstresado()
        {
            Assert.IsFalse(batman.EstaEstresado());
        }

        //3
        [Test]
        public void TestCombateContraUnPsicopataYEsteQuedoInconsciente()
        {
            batman.CombatirCrimen(psico);
            Assert.AreEqual("inconsciente",psico.Estado);
        }
        [Test]
        public void TestCombateContraUnaPandillaYTodosQuedanInconscientes()
        {
            batman.CombatirCrimen(pandilla);
            Assert.IsTrue(pandilla.All(v => v.Estado=="inconsciente"));
        }

        //4
        [Test]
        public void TestBatmanEstaALaModa()
        {
           Assert.IsTrue(batman.Riñonera.All(h => h.Nombre.StartsWith("bati")));
        }

        //5
        [Test]
        public void TestBatmanBailaElBatiTwistYGana100PuntosDeVida()
        {
            batman.BatiTwist();
            Assert.AreEqual(900,batman.Vida);
        }

        //6
        [Test]
        public void TestUnaPandillaDeVillanosHaceMaldades()
        {
            pandilla.ForEach(v => v.HacerMaldades(ciudadanos));
            Assert.IsTrue(psico.Asesinatos==5 && marron.Dinero==2000000 && blanco.Dinero == 10000000);
        }

    #endregion

    #region standard_ciudadanos
        [Test]
        public void TestC1EsRico()
        {
            Assert.AreEqual("rico",c1.Clase);
        }
        
        [Test]
        public void TestC2EsClaseMedia()
        {
            Assert.AreEqual("media",c2.Clase);
        }
        
        [Test]
        public void TestC3EsClaseBaja()
        {
            Assert.AreEqual("baja",c3.Clase);
        }
        
        [Test]
        public void TestElDineroTotalEsDe()
        {
            Assert.AreEqual(13015000,ciudadanos.Sum(c=>c.Dinero));
        }


    #endregion

    #region standard_batman

        [Test]
        public void TestLaSumaDeLosPoderesDeLaBatiRiñoneraDa4()
        {
            Assert.AreEqual(4,batiCinturon.Sum(b => b.Poder));
        }

        [Test]
        public void TestLaFuerzaDeBatmanEsDe804()
        {
            Assert.AreEqual(804,batman.Fuerza);
        }

        [Test]
        public void TestBatmanLloraYPierdeH1()
        {
            batman.Llorar();
            Assert.That(batman.Riñonera, Does.Not.Contain(h1));
        }

        [Test]
        public void TestBatmanLloraYQuedaCon0DeEstres()
        {
            batman.Llorar();
            Assert.IsTrue(batman.Estres == 0);
        }

    #endregion
    
    #region standard_villanos
        [Test]
        public void TestElPsicopataTieneUnaFuerzaDe50LuegoDeHacerMaldades()
        {
            psico.HacerMaldades(ciudadanos);
            Assert.AreEqual(50,psico.Fuerza);
        }

        [Test]
        public void TestLadronDeGuanteBlancoRobaYConsigue10000000(){
            blanco.HacerMaldades(ciudadanos);
            Assert.AreEqual(10000000,blanco.Dinero);
        }

        [Test]
        public void TestLadronDeGuanteMarronRobaYConsigue2000000(){
            marron.HacerMaldades(ciudadanos);
            Assert.AreEqual(2000000,marron.Dinero);
        }

        [Test]
        public void TestRobinHoodRobaYLosClaseBajaYAhoraTienen3338333(){
            robin.HacerMaldades(ciudadanos);
            Assert.AreEqual(3338333,ciudadanos.Where(c=>c.Clase == "baja").ToList().First().Dinero);
        }

        [Test]
        public void TestExtraterrestreAbduce3Veces(){
            et.HacerMaldades(ciudadanos);
            et.HacerMaldades(ciudadanos);
            et.HacerMaldades(ciudadanos);
            Assert.AreEqual(3,ciudadanos.Count());
        }

        [Test]
        public void TestExtraterrestreAbduce3VecesYSuFuerzaEsDe1(){
            et.HacerMaldades(ciudadanos);
            et.HacerMaldades(ciudadanos);
            et.HacerMaldades(ciudadanos);
            Assert.AreEqual(1,et.Fuerza);
        }

    #endregion
    }
}