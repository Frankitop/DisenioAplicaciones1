using Entidades;
using Entidades.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace EntidatesTest
{
    [TestClass]
    public class UnitTest1
    {
        private Sistema sistema;
        [TestInitialize]
        public void Initialize()
        {
            Sistema sistema = new Sistema();
            this.sistema = sistema;
            this.sistema.InitializeDB();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            Periferico periferico = new Periferico();
            periferico.Nombre = "Test";
            PerifericoContext context = new PerifericoContext(this.sistema);
            context.AgregarPeriferico(periferico);

            Assert.AreEqual(1, context.ObtenerListadoPerifericos().Count);

        }

        [TestMethod]
        public void AgregarLaptop()
        {

            Laptop lap = new Laptop();
            lap.RAM = 100;
            lap.EspacioEnDisco = 10;
            lap.AperiosBateria = 100;
            MaquinaContext context = new MaquinaContext(this.sistema);
            context.AgregaLaptop(lap);

            Assert.AreEqual(1, context.ObtenerListadoMaquinas().Count);

        }

        [TestCleanup]
        public void CleanUp()
        {
            foreach (Periferico periferico in this.sistema.Perifericos.ToList())
            {
                this.sistema.Perifericos.Remove(periferico);
            }
            this.sistema.SaveChanges();
        }
    }
}