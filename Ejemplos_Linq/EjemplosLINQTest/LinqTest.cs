using EjemplosLinq.Domino;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EjemplosLINQTest
{
    [TestClass]
    public class LinqTest
    {
        private Universidad universidad;

        [TestInitialize]
        // [DataRow()]
        public void TestInit()
        {
            this.universidad = new Universidad();

            #region CrearEstudiantes
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Cedula = 123456789;
            estudiante1.Nombre = "Estudiante 1";
            estudiante1.FechaDeNacimiento = new DateTime(1992, 01, 30);
            estudiante1.PAC = 91;

            Estudiante estudiante2 = new Estudiante();
            estudiante2.Cedula = 987654321;
            estudiante2.Nombre = "Estudiante 2";
            estudiante2.FechaDeNacimiento = new DateTime(2000, 05, 30);
            estudiante2.PAC = 85;

            Estudiante estudiante3 = new Estudiante();
            estudiante3.Cedula = 963852741;
            estudiante3.Nombre = "Estudiante 3";
            estudiante3.FechaDeNacimiento = new DateTime(1989, 08, 30);
            estudiante3.PAC = 98;

            Estudiante estudiante4 = new Estudiante();
            estudiante4.Cedula = 147258369;
            estudiante4.Nombre = "Estudiante 4";
            estudiante4.FechaDeNacimiento = new DateTime(2002, 08, 30);
            estudiante4.PAC = 78;

            universidad.AgregarEstudiantes(estudiante1, estudiante2, estudiante3, estudiante4);
            #endregion

            #region CrearDocentes
            Docente docente1 = new Docente();
            docente1.Cedula = 321654987;
            docente1.Nombre = "Docente 1";

            Docente docente2 = new Docente();
            docente2.Cedula = 741852963;
            docente2.Nombre = "Docente 2";

            Docente docente3 = new Docente();
            docente3.Cedula = 654789321;
            docente3.Nombre = "Docente 3";

            universidad.AgregarDocentes(docente1, docente2, docente3);
            #endregion

            #region CrearMaterias
            Materia algoritmos1 = new Materia();
            algoritmos1.Nombre = "Algoritmos 1";

            Materia programacion1 = new Materia();
            programacion1.Nombre = "Programacion 1";

            Materia arquitectura = new Materia();
            arquitectura.Nombre = "Arquitectura";

            Materia probabilidadYestadistica = new Materia();
            probabilidadYestadistica.Nombre = "Probabilidad y Estadistica";

            universidad.AgregarMaterias(algoritmos1, programacion1, arquitectura, probabilidadYestadistica);
            #endregion

            #region InscribirEstudiantes
            //Inscribir estudiantes a Algoritmos 1
            universidad.InscribirEstudianteMateria(estudiante1, algoritmos1);
            universidad.InscribirEstudianteMateria(estudiante2, algoritmos1);
            universidad.InscribirEstudianteMateria(estudiante3, algoritmos1);

            //Inscribir estudiates a Programacion 1
            universidad.InscribirEstudianteMateria(estudiante1, programacion1);
            universidad.InscribirEstudianteMateria(estudiante2, programacion1);
            universidad.InscribirEstudianteMateria(estudiante3, programacion1);
            universidad.InscribirEstudianteMateria(estudiante4, programacion1);

            //Inscribir estudiantes a Arquitectura
            universidad.InscribirEstudianteMateria(estudiante1, arquitectura);
            universidad.InscribirEstudianteMateria(estudiante4, arquitectura);

            //Inscribir estudiates a Probabilidad y Estadistica
            universidad.InscribirEstudianteMateria(estudiante2, probabilidadYestadistica);
            universidad.InscribirEstudianteMateria(estudiante3, probabilidadYestadistica);
            universidad.InscribirEstudianteMateria(estudiante4, probabilidadYestadistica);
            #endregion

            #region InscribirDocentes
            //Inscribir docente a Algoritmos 1
            universidad.InscribirDocenteMateria(docente1, algoritmos1);
            universidad.InscribirDocenteMateria(docente2, algoritmos1);

            //Inscribir docente a Programacion 1
            universidad.InscribirDocenteMateria(docente3, programacion1);

            //Inscribir docete a Arquitectura
            universidad.InscribirDocenteMateria(docente2, arquitectura);

            //Inscribir docente a probabilidad y estadistica
            universidad.InscribirDocenteMateria(docente1, probabilidadYestadistica);
            #endregion
        }

        [TestMethod]
        public void DocentesPorMateriaAlgoritmosTest()
        {
            Materia materia = new Materia() { Nombre = "Algoritmos 1" };

            List<Docente> expected = new List<Docente>() {
                new Docente { Cedula = 321654987, Nombre = "Docente 1" },
                new Docente { Cedula = 741852963, Nombre = "Docente 2" },
            };

            List<Docente> docentes = universidad.DocentesPorMateria(materia);
            CollectionAssert.AreEqual(expected, docentes);
        }

        [TestMethod]
        public void DocentesPorMateriaProgramacionTest()
        {
            Materia materia = new Materia();
            materia.Nombre = "Programacion 1";

            List<Docente> expected = new List<Docente>() {
                new Docente { Cedula = 654789321, Nombre = "Docente 3" },
            };

            List<Docente> docentes = universidad.DocentesPorMateria(materia);
            CollectionAssert.AreEqual(expected, docentes);
        }

        [TestMethod]
        public void DocentesPorMateriaArquitecturaTest()
        {
            Materia materia = new Materia();
            materia.Nombre = "Arquitectura";

            List<Docente> expected = new List<Docente>() {
                new Docente { Cedula = 741852963, Nombre = "Docente 2" },
            };

            List<Docente> docentes = universidad.DocentesPorMateria(materia);
            CollectionAssert.AreEqual(expected, docentes);
        }

        [TestMethod]
        public void DocentesPorMateriaProbabilidadYEstadisticaTest()
        {
            Materia materia = new Materia();
            materia.Nombre = "Probabilidad y Estadistica";

            List<Docente> expected = new List<Docente>() {
                new Docente { Cedula = 321654987, Nombre = "Docente 1" },
            };

            List<Docente> docentes = universidad.DocentesPorMateria(materia);
            CollectionAssert.AreEqual(expected, docentes);
        }

        [TestMethod]
        public void ObtenerEstudiantePorCedulaEstudiante1Test()
        {
            int cedula = 123456789;

            Estudiante resultado = universidad.ObtenerEstudiantePorCedula(cedula);
            Assert.AreEqual(cedula, resultado.Cedula);
        }

        [TestMethod]
        public void ObtenerEstudiantePorCedulaEstudiante2Test()
        {
            int cedula = 987654321;

            Estudiante resultado = universidad.ObtenerEstudiantePorCedula(cedula);
            Assert.AreEqual(cedula, resultado.Cedula);
        }

        [TestMethod]
        public void ObtenerEstudiantesPorRangoFechaNacimiento1Test()
        {
            DateTime inicio = new DateTime(1, 1, 1);
            DateTime limite = new DateTime(2022, 9, 5);

            List<Estudiante> expected = new List<Estudiante>()
            {
                new Estudiante(){ Cedula = 123456789, Nombre = "Estudiante 1", FechaDeNacimiento =  new DateTime(1992, 01, 30)},
                new Estudiante(){ Cedula = 987654321, Nombre = "Estudiante 2", FechaDeNacimiento =  new DateTime(2000, 05, 30)},
                new Estudiante(){ Cedula = 963852741, Nombre = "Estudiante 3", FechaDeNacimiento =  new DateTime(1989, 08, 30)},
                new Estudiante(){ Cedula = 147258369, Nombre = "Estudiante 4", FechaDeNacimiento =  new DateTime(2002, 08, 30)},
            };

            List<Estudiante> resultado = universidad.ObtenerEstudiantesPorRangoFechaNacimiento(inicio, limite);
            CollectionAssert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void ObtenerEstudiantesPorRangoFechaNacimiento2Test()
        {
            DateTime inicio = new DateTime(1900, 1, 1);
            DateTime limite = new DateTime(1999, 12, 31);

            List<Estudiante> expected = new List<Estudiante>()
            {
                new Estudiante(){ Cedula = 123456789, Nombre = "Estudiante 1", FechaDeNacimiento =  new DateTime(1992, 01, 30)},
                new Estudiante(){ Cedula = 963852741, Nombre = "Estudiante 3", FechaDeNacimiento =  new DateTime(1989, 08, 30)},
            };

            List<Estudiante> resultado = universidad.ObtenerEstudiantesPorRangoFechaNacimiento(inicio, limite);
            CollectionAssert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void ObtenerEstudiantesPorRangoFechaNacimiento3Test()
        {
            DateTime inicio = new DateTime(2002, 1, 1);
            DateTime limite = new DateTime(2002, 12, 31);

            List<Estudiante> expected = new List<Estudiante>()
            {
                new Estudiante(){ Cedula = 147258369, Nombre = "Estudiante 4", FechaDeNacimiento =  new DateTime(2002, 08, 30)},
            };

            List<Estudiante> resultado = universidad.ObtenerEstudiantesPorRangoFechaNacimiento(inicio, limite);
            CollectionAssert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void ObtenerEstudiantesConMayorPacTest()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cedula = 963852741;
            estudiante.Nombre = "Estudiante 3";
            estudiante.FechaDeNacimiento = new DateTime(1989, 08, 30);
            estudiante.PAC = 98;

            Estudiante resultado = universidad.ObtenerEstudianteConMayorPAC();
            Assert.AreEqual(estudiante, resultado);
            Assert.AreEqual(estudiante.PAC, resultado.PAC);
        }
    }
}