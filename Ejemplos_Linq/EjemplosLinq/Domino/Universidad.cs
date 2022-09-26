using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq.Domino
{
    public class Universidad
    {
        public Universidad()
        {
            this.Estudiantes = new List<Estudiante>();
            this.Materias = new List<Materia>();    
            this.Docentes = new List<Docente>();    
        }

        public List<Materia> Materias { get; private set; }

        public List<Estudiante> Estudiantes { get; private set; }

        public List<Docente> Docentes { get; private set; }

        public void AgregarEstudiantes(params Estudiante[] estudiantes) 
        {
            this.Estudiantes.AddRange(estudiantes);
        }

        public void AgregarDocentes(params Docente[] docentes)
        {
            this.Docentes.AddRange(docentes);   
        }

        public void AgregarMaterias(params Materia[] materias) 
        {
            this.Materias.AddRange(materias);   
        }

        public void InscribirEstudianteMateria(Estudiante estudiante, Materia materiaAinscribir) 
        {
            // Busco la materia a la cual el estudiante se quiere inscribir.
            Materia materiaBusqueda = this.Materias.Where(materia => materia.Equals(materiaAinscribir)).FirstOrDefault();

            //El FirstOrDefault devuelve el primer item que cumple la condicion del where y si no lo encontro develve null;
            if (materiaBusqueda == null) 
            {
                throw new InvalidOperationException("La materia no existe.");
            }

            materiaBusqueda.Estudiantes.Add(estudiante);
        }

        public void InscribirDocenteMateria(Docente docente, Materia materiaAinscribir) 
        {
            // Busco la materia a la cual el docente se quiere inscribir.
            Materia materiaBusqueda = this.Materias.Where(materia => materia.Equals(materiaAinscribir)).FirstOrDefault();

            //El FirstOrDefault devuelve el primer item que cumple la condicion del where y si no lo encontro develve null;
            if (materiaBusqueda == null)
            {
                throw new InvalidOperationException("La materia no existe.");
            }

            materiaBusqueda.Docentes.Add(docente);  
        }

        /*
         * Dada una materia, retornar todos los docentes que esten inscriptos a esa materia
         */
        public List<Docente> DocentesPorMateria(Materia materiaFiltro)
        {
            List<Docente> docentes = this.Materias
                                        .Where(materia => materia.Nombre == materiaFiltro.Nombre)
                                        .SelectMany(materia => materia.Docentes).Distinct().ToList(); ; //TO DO LINQ
            return docentes;
        }

        /*
         * Dada una cedula, retornar el estudiante al que le pertenece dicha cedula
         */
        public Estudiante ObtenerEstudiantePorCedula(int cedula)
        {
            Estudiante estudianteCI = this.Estudiantes
                                    .Where( estudiante => estudiante.Cedula == cedula) as Estudiante; //TO DO LINQ

            if (estudianteCI == null)
            {
                throw new InvalidOperationException("La cedula: " + cedula  + " no existe.");
            }

            return estudianteCI;
        }

        /*
         * Dada una fecha de inicio y una fecha limite, retornar todos los estudiantes que hayan nacido durante ese periodo
         */
        public List<Estudiante> ObtenerEstudiantesPorRangoFechaNacimiento(DateTime fechaInicio, DateTime fechaLimite)
        {
            return null; //TO DO LINQ
        }

        /*
         * Retorna el estudiante con el PAC mayor
         */
        public Estudiante ObtenerEstudianteConMayorPAC()
        {
            return null; //TO DO LINQ
        }
    }
}
