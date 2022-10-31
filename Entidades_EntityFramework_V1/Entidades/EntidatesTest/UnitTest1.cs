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
        public void TestMethod1()
        {
            Sistema sistema = new Sistema();
            sistema.InitializeDB();
            Periferico periferico = new Periferico();
            periferico.Nombre = "Test";
            PerifericoContext context = new PerifericoContext(sistema);
            context.AgregarPeriferico(periferico);
            
            Assert.AreEqual(1, context.ObtenerListadoPerifericos().Count);

        }
    }
}
