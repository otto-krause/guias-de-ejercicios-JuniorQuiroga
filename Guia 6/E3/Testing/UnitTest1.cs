using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;
using System;

namespace Testing
{
    public class Tests
    {
        Zero zero;

        Maverik Roberto;
        Maverik Carlos;

        Arma SableDeLuz;
        Arma BlasterGastado;
        Arma Katana;
        
        List<Maverik> maveriks;

        [SetUp]
        public void Setup()
        {
            SableDeLuz = new Sable(100,1);
            BlasterGastado = new Blaster(300,70);
            Katana = new Sable(55,2);
            
            zero = new Zero(new List<Arma>(){SableDeLuz,BlasterGastado,Katana});
            
            Roberto = new Maverik(SableDeLuz,20);
            Carlos = new Maverik(Katana,100);

            maveriks = new List<Maverik>(){Roberto,Carlos}; 
        }

        [Test]
        public void TestComprobarQueElPoderDelSableDeLuzSea200()
        {
            Assert.AreEqual(200,SableDeLuz.Poder());
        }

        [Test]
        public void TestComprobarQueElPoderDelBlasterGastadoSea230()
        {
            Assert.AreEqual(230,BlasterGastado.Poder());
        }

        [Test]
        public void TestComprobarQueElPoderDeLaKatanaSea220()
        {
            Assert.AreEqual(220,Katana.Poder());
        }

        [Test]
        public void TestComprobarQueElElArmaMasPoderosaDeZeroSeaElBlasterGastadoYSiElPoderDeZeroEsDe230()
        {
            Assert.IsTrue(zero.LaMasPolentosa() == BlasterGastado && zero.Poder() == 230);
        }

        [Test]
        public void TestComprobarQueZeroPuedeVencerARoberto()
        {
            Assert.IsTrue(zero.LoPuedeVencer(Roberto));
        }
        
        [Test]
        public void TestComprobarQueZeroNoPuedeVencerACarlos()
        {
            Assert.IsFalse(zero.LoPuedeVencer(Carlos));
        }

        [Test]
        public void TestComprobarQueZeroNoPuedeVencerATodosLosMaveriks()
        {
            Assert.IsFalse(zero.LosPuedeVencer(maveriks));
        }
    }
}