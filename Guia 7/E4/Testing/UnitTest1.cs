using Ejercicio;
using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace Testing
{
    public class Tests
    {
        Comun comun;
        Red red;
        Bomb bomb;
        Chuck chuck;
        Terence terence;
        Matilda matilda;

        List<Pajaro> pajaros;

        [SetUp]
        public void Setup()
        {
            comun = new Comun(2);
            red = new Red(10); 
            bomb = new Bomb(3);
            chuck = new Chuck(4);
            terence = new Terence(3,2);
            matilda = new Matilda(4,new List<Huevo>(){new Huevo(2),new Huevo(3),new Huevo(1),new Huevo(4)});

            pajaros = new List<Pajaro>(){comun,red,bomb,chuck,terence,matilda};
        }

    #region 1
        [Test]
        public void TestLaFuerzaDeComunEs4()
        {
            Assert.AreEqual(4,comun.Fuerza);
        }
        
        [Test]
        public void TestComunSeEnojaYSuFuerzaEs8()
        {
            comun.Enojarse();
            Assert.AreEqual(8,comun.Fuerza);
        }
        
        [Test]
        public void TestChuckEsElPajaroMasFuertes()
        {
            List<Pajaro> fortachones = pajaros.Where(p=> p.Fuerza > 50).ToList();
            Assert.AreEqual(new List<Pajaro>(){chuck},fortachones);
        }

        [Test]
        public void TestLaFuerzaDeLaIslaEs150()
        {
            Assert.AreEqual(150,pajaros.Where(p=> p.Fuerza > 50).ToList().Sum(p=>p.Fuerza));
        }

    #endregion
        

    #region standard pajaros
    //red
        [Test]
        public void TestLaFuerzaDeRedEs0()
        {
            Assert.AreEqual(0,red.Fuerza);
        }
        
        [Test]
        public void TestRedSeEnojaYSuFuerzaEs200()
        {
            red.Enojarse();
            Assert.AreEqual(200,red.Fuerza);
        }
    //bomb
        [Test]
        public void TestLaFuerzaDeBombEs6()
        {
            Assert.AreEqual(6,bomb.Fuerza);
        }

        [Test]
        public void TestBombSeEnoja12VecesYSuFuerzaQuedaEn6144()
        {
            for(int i=0;i<12;i++)
                bomb.Enojarse();
            Assert.AreEqual(6144,bomb.Fuerza);
        }
    //chuck
        [Test]
        public void TestLaFuerzaDeChuckEs150()
        {
            Assert.AreEqual(150,chuck.Fuerza);
        }

        [Test]
        public void TestChuckSeEnoja5VecesYSuFuerzaEs390()
        {
            for(int i=0;i<5;i++)
                chuck.Enojarse();
            Assert.AreEqual(390,chuck.Fuerza);
        }
    //terence
        [Test]
        public void TestLaFuerzaDeTerenceEs6()
        {
            Assert.AreEqual(6,terence.Fuerza);
        }

        [Test]
        public void TestTerenceSeEnojaVecesYSuFuerzaEs14()
        {
            terence.Enojarse();
            Assert.AreEqual(14,terence.Fuerza);
        }
    //matilda
        [Test]
        public void TestLaFuerzaDeMatildaEs18()
        {
            Assert.AreEqual(18,matilda.Fuerza);
        }

        [Test]
        public void TestMatildaSeEnojaVecesYSuFuerzaEs90()
        {
            matilda.Enojarse();
            Assert.AreEqual(20,matilda.Fuerza);
        }
    #endregion
    }
}