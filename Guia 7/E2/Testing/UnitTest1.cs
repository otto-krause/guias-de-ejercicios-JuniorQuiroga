using Ejercicio;
using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace Testing
{
    public class Tests
    {
        Abuelo abuelo;
        Necio necio;
        Comun comun;
        
        Niño mary;
        Niño jony;
        Niño romo;
        Niño flor;

        Legion legion;
        Legion legionDeLegiones;
        
        List<Asustador> niños;

        Maquillaje maqui;
        Traje tierno;
        Traje terror; 

        [SetUp]
        public void Setup()
        {
            abuelo = new Abuelo();
            necio = new Necio();
            comun = new Comun();

            maqui = new Maquillaje();
            tierno = new Traje_Tierno();
            terror = new Traje_Terrorifico();

            mary = new Niño(maqui,tierno,16);
            jony = new Niño(maqui,terror,0);
            romo = new Niño(maqui,terror,5);
            flor = new Niño(maqui,terror,10);

            niños = new List<Asustador>(){mary,jony,romo};

            legion = new Legion(niños);
            legionDeLegiones = new Legion(new List<Asustador>(){legion,flor});
    
            niños.Add(flor);
        }

    #region A
            [Test]
            public void TestLaCapacidadDeAsustarDeMaryEsDe5()
            {
                Assert.AreEqual(5,mary.Capacidad);
            }
            
            [Test]
            public void TestLaCapacidadDeAsustarDeJonyEsDe8()
            {
                Assert.AreEqual(8,jony.Capacidad);
            }

            [Test]
            public void TestMaryAsustaUnAdultoComunYLuegoJonyLoIntentaPeroSuToleranciaEsMayorYNoConsigueNada()
            {
                mary.Asustar(comun);
                jony.Asustar(comun);
                
                Assert.AreEqual(0,jony.Caramelos);
            }

            [Test]
            public void TestMaryAsustaUnAbueloYLuegoJonyLoAsusta2VecesYConsigue4Caramelos()
            {
                mary.Asustar(abuelo);
                jony.Asustar(abuelo);
                jony.Asustar(abuelo);
                
                Assert.AreEqual(4,jony.Caramelos);
            }

            [Test]
            public void TestJonyIntentaAsustarAUnNecioPeroNoObtieneNada()
            {
                jony.Asustar(necio);
                Assert.AreEqual(0,jony.Caramelos);
            }
    #endregion

    #region B

        //1
        [Test]
        public void TestCuandoUnaLegionTieneSoloUnNIñoTiraError()
        {
            Assert.Throws<System.Exception>(() => new Legion(new List<Asustador>(){mary}));
        }

        //2
        [Test]
        public void TestLaLegionAsusta2VecesAUnAbueloYAhoraTienen23Caramelos()
        {
            legion.Asustar(abuelo);
            legion.Asustar(abuelo);
            Assert.AreEqual(23,legion.Caramelos);
        }

        //3: Es posible implementar las legiones de legiones debido a que 
        //ambos heredan de Asustador y justamente legiones tomo parametros de ese tipo

        //standard - legion
        [Test]
        public void TestElLiderDeLaLegionEsJony()
        {
            Assert.AreEqual(jony,legion.Lider);
        }

        [Test]
        public void TestLaCapacidadDeAsustarDeLaLegionEsDe21()
        {
            Assert.AreEqual(21,legion.Capacidad);
        }

        [Test]
        public void TestLaCantidadDeCaramelosDeLaLegionEsDe21()
        {
            Assert.AreEqual(21,legion.Caramelos);
        }
        
        [Test]
        public void TestLaLegionAsusta2VecesAUnAbueloYElLiderGana2Caramelos()
        {
            legion.Asustar(abuelo);
            legion.Asustar(abuelo);
            Assert.AreEqual(2,legion.Lider.Caramelos);
        }

        [Test]
        public void TestLaLegionAsusta2VecesAUnComunAhoraLaLegionTiene26Caramelos()
        {
            legion.Asustar(comun);
            legion.Asustar(comun);
            Assert.AreEqual(26,legion.Caramelos);
        }
        
        [Test]
        public void TestLaLegionIntentaAsustarAUnNecioPeroNoConsiguenNadaYQuedanCon21()
        {
            legion.Asustar(necio);
            Assert.AreEqual(21,legion.Caramelos);
        }

        //standard - legiones de legiones
        [Test]
        public void TestElLiderDeLegionDeLegionesEsLegion()
        {
            Assert.AreEqual(legion,legionDeLegiones.Lider);
        }

        [Test]
        public void TestLegionDeLegionesTiene31Caramelos()
        {
            Assert.AreEqual(31,legionDeLegiones.Caramelos);
        }

        [Test]
        public void TestLegionDeLegionesTiene31DeCapacidadDeSusto()
        {
            Assert.AreEqual(29,legionDeLegiones.Capacidad);
        }

        [Test]
        public void TestLegionDeLegionesAsustaAUnAbuelo2VecesYAhoraTienen33Caramelos()
        {
            legionDeLegiones.Asustar(abuelo);
            legionDeLegiones.Asustar(abuelo);
            Assert.AreEqual(33,legionDeLegiones.Caramelos);
        }

        [Test]
        public void TestLegionDeLegionesAsustaAUnComun2VecesYAhoraTienen36Caramelos()
        {
            legionDeLegiones.Asustar(comun);
            legionDeLegiones.Asustar(comun);
            Assert.AreEqual(36,legionDeLegiones.Caramelos);
        }

        [Test]
        public void TestLegionDeLegionesIntentaAsustarAUnNecioYNoConsiguieronNada()
        {
            legionDeLegiones.Asustar(necio);
            Assert.AreEqual(31,legionDeLegiones.Caramelos);
        }

    #endregion

    #region C
        //1
        [Test]
        public void TestElNiñoConMasCaramelosEsMary()
        {
            Assert.AreEqual(mary,niños.OrderByDescending(n=>n.Caramelos).First());
        }

        [Test]
        public void TestElSegundoNiñoConMasCaramelosEsFlor()
        {
            Assert.AreEqual(flor,niños.OrderByDescending(n=>n.Caramelos).Take(2).Last());
        }

        [Test]
        public void TestElTercerNiñoConMasCaramelosEsRomo()
        {
            Assert.AreEqual(romo,niños.OrderByDescending(n=>n.Caramelos).Take(3).Last());
        }

        //2
        [Test]
        public void TestLosNIñosCuentanConMaquillajeYUnTrajeTiernoOTerrorifico()
        {
            List<Elemento> lista = new List<Elemento>();
            niños.Select(n => n.getMaqui).Distinct().ToList().ForEach(m => lista.Add(m));
            niños.Select(n => n.getTraje).Distinct().ToList().ForEach(t => lista.Add(t));
            Assert.AreEqual(new List<Elemento>(){maqui,tierno,terror},lista);
        }
    #endregion
    }
}