using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraStrings;


namespace CalculadoraStringsTest
{
    [TestClass]
    public class CalculadoraStringsTest
    {
        [TestMethod]
        public void SumarStringVacioTest()
        {
            Calculadora unaCalculadora = new Calculadora(); 
            Assert.AreEqual(0, unaCalculadora.Sumar(""));
        }

        [TestMethod]
        public void SumarStringUnicoNumeroTest()
        {
            Calculadora unaCalculadora = new Calculadora();
            Assert.AreEqual(1, unaCalculadora.Sumar("1"));
        }
        
        [TestMethod]
        public void SumarStringDosNumerosSeparadosPorComaTest()
        {
            Calculadora unaCalculadora = new Calculadora();
            Assert.AreEqual(3, unaCalculadora.Sumar("1,2"));
        }

    }
}
