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

        Obstaculo madera;
        Obstaculo vidrio;
        Obstaculo piedra;
        Obstaculo obrero;
        Obstaculo armadoEscudo;
        Obstaculo armadoCasco;
        
        Isla isla;
        Isla_Cerdo islaCerditos;

        [SetUp]
        public void Setup()
        {
            comun = new Comun(2);
            red = new Red(10); 
            bomb = new Bomb(3);
            chuck = new Chuck(4);
            terence = new Terence(3,2);
            matilda = new Matilda(4,new List<Huevo>(){new Huevo(2),new Huevo(3),new Huevo(1),new Huevo(4)});

            madera = new Madera(3);
            vidrio = new Vidrio(1);
            piedra = new Piedra(2);
            obrero = new Obrero();
            armadoEscudo = new Armado(new Escudo(2));
            armadoCasco = new Armado(new Casco(4));

            isla = new Isla(new List<Pajaro>(){comun,red,bomb,chuck,terence,matilda});
            islaCerditos = new Isla_Cerdo(new List<Obstaculo>(){madera,vidrio,piedra,obrero,armadoCasco,armadoEscudo});
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
            List<Pajaro> fortachones = isla.Pajaros.Where(p=> p.Fuerza > 50).ToList();
            Assert.AreEqual(new List<Pajaro>(){chuck},fortachones);
        }

        [Test]
        public void TestLaFuerzaDeLaIslaEs150()
        {
            Assert.AreEqual(150,isla.Pajaros.Where(p=> p.Fuerza > 50).ToList().Sum(p=>p.Fuerza));
        }

    #endregion
        
    #region 2
        [Test]
        public void TestTodaLaIslaTomaUnaSecionDeManejoDeIraPeroChuckNoLoLogra()
        {
            List<int> iras = new List<int>();
            isla.ManejoDeIra();
            isla.Pajaros.ForEach(p=>iras.Add(p.Ira));
            Assert.IsTrue(new List<int>(){0,5,0,4,0,0}.SequenceEqual(iras)&& chuck.Ira==4);
        }

        [Test]
        public void Test256CerdosLLeganALaIslaYLosPajarosSeEnojan2Veces()
        {
            List<int> iras = new List<int>();
            isla.Invacion(256);
            isla.Pajaros.ForEach(p=>iras.Add(p.Ira));
            Assert.IsTrue(new List<int>(){8,40,12,16,12,4}.SequenceEqual(iras) && matilda.Fuerza == 22);
        }

        [Test]
        public void TestFiestaSorpresaARedYAMatildaYSeEnojan()
        {
            isla.Fiesta(new List<Pajaro>(){red,matilda});
            Assert.IsTrue(red.Ira==20 && matilda.Fuerza==20);
        }

        [Test]
        public void TestCuandoNoHayANadieAQuienHomenajearTiraError()
        {
            Assert.Throws<System.Exception>(() => isla.Fiesta(new List<Pajaro>(){}));
        }
        
        [Test]
        public void TestSerieDeEventosDesafortunados()
        {
            isla.EventosDesafortunados(new List<Pajaro>(){red,comun},492);

            Assert.IsTrue(red.Ira==310&& comun.Ira==54&& bomb.Ira==43&& chuck.Ira==64&& terence.Ira==43 && matilda.Fuerza==26);
        }
    #endregion 

    #region 3
        [Test]
        public void TestChuckRompeUnaParedDeVidrioDe1DeAncho()
        {
            chuck.Derribar(vidrio);
            Assert.AreEqual("derribado",vidrio.Estado);
        }
        
        [Test]
        public void TestLaIslaAtacaALaIslaDeCerditosPeroNoDerribanTodo()
        {
            isla.Atacar(islaCerditos);
            Assert.IsFalse(islaCerditos.Obstaculos.All(o=>o.Estado == "derribado"));
        }
        
        [Test]
        public void TestLosPajarosSeEnojan5VecesYLaIslaAtacaALaIslaDeCerditosYRecuperanTodosLosHuevos()
        {
            for (int i = 0; i < 5; i++)
                isla.Pajaros.ForEach(p=>p.Enojarse());
            
            isla.Atacar(islaCerditos);
            Assert.IsTrue(islaCerditos.Obstaculos.All(o=>o.Estado == "derribado"));
        }

    #endregion

    #region 4

        [Test]
        public void TestSeAbreUnHUevoYSeSumaUnPajaroALaIsla()
        {
            isla.HuevoSeAbre(new Huevo(3));
            Assert.AreEqual(7,isla.Pajaros.Count());
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
        public void TestRedSeEnoja2VecesYSuFuerzaEs400()
        {
            red.Enojarse();
            red.Enojarse();
            Assert.AreEqual(400,red.Fuerza);
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
        public void TestTerenceSeEnojaVecesYSuFuerzaEs12()
        {
            terence.Enojarse();
            Assert.AreEqual(12,terence.Fuerza);
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