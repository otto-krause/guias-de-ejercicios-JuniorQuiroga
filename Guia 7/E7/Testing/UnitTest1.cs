using NUnit.Framework;
using Ejercicio;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        Ciudad city;
        Pertenencia piramide;
        Pertenencia suero;
        Pertenencia luna;
        Villano grut;
        Minion m1;
        Minion m2;
        Minion m3;
        Arma recompensa3;


        [SetUp]
        public void Setup()
        {
            piramide = new Pertenencia("Piramides",10);
            suero = new Pertenencia("Suero Mutante");
            luna = new Pertenencia("La Luna");
            city = new Ciudad(50,new List<Pertenencia>(){piramide,suero,luna});
            recompensa3 = new Arma("Rayo Congelador",10);
            //con=190
            m1 = new Minion(new List<Arma>(){new Arma("Rayo Congelador",40)},150);
            //con=40
            m2 = new Minion(new List<Arma>(){new Arma("Rayo Congelador",10),new Arma("Rayo Congelador",20),new Arma("Rayo Encojedor",10)},20);
            //con=170
            m3 = new Minion(new List<Arma>(){new Arma("Rayo Congelador",20),new Arma("Rayo Encojedor",20),new Arma("Rayo Encojedor",50)},120);
        
            grut = new Villano(new List<Minion>(){m1,m2,m3});
        }

        [Test]
        public void TestElMinionMasUtilEsM3(){
            grut.Robar(suero,city);
            grut.Robar(piramide,city);
            
            Assert.IsTrue(m3 == grut.Minions.OrderByDescending(m=>m.Participaciones).First());   
        }
        
        [Test]
        public void TestElMinionMasInutilEsM1(){
            grut.Robar(luna,city);
            grut.Robar(suero,city);
            
            Assert.IsTrue(m1 == grut.Minions.OrderBy(m=>m.Participaciones).First());   
        }
        


        [Test]
        public void TestGrutRobaLasPiramides()
        {
            grut.Robar(piramide,city);
            Assert.IsFalse(city.Pertenencias.Contains(piramide));
        }
        
        [Test]
        public void TestGrutRobaElSueroYTodosLosMinionsSonVioleta()
        {
            grut.Robar(suero,city);
            Assert.IsTrue(grut.Minions.All(m=>m.Color=="violeta"));
        }
        
    }
}