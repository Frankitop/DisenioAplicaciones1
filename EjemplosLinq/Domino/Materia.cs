using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq.Domino
{
    public class Materia
    {
        public Materia()
        {
            this.Estudiantes = new List<Estudiante>();  
            this.Docentes = new List<Docente>();    
        }
        public string Nombre { get; set; }

        public List<Estudiante> Estudiantes { get; set; }

        public List<Docente> Docentes { get; set; }

        public override bool Equals(object obj)
        {
            var materia = obj as Materia;
            if (materia == null) 
            {
                return false;
            }

            return this.Nombre == materia.Nombre;
        }

    }
}
