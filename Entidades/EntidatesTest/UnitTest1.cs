using Entidades;
using Entidades.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EntidatesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ExeptionValiacionNumero))]
        public void TestMethod1()
        {
            Maquina maquina = new Maquina();
            maquina.RAM = 20;

        }
    }
}
