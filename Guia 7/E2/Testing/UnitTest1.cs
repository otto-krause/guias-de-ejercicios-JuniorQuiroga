using Ejercicio;
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
        //Niño n3;

        [SetUp]
        public void Setup()
        {
            abuelo = new Abuelo();
            necio = new Necio();
            comun = new Comun();

            mary = new Niño(new Maquillaje(),new Traje_Tierno(),16);
            jony = new Niño(new Maquillaje(),new Traje_Terrorifico(),0);
            //n3 = new Niño(new Maquillaje(),new Traje_Terrorifico());
        }

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
    }
}