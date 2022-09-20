using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq.Domino
{
    public class Docente
    {
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public override bool Equals(object obj)
        {
            var docente = obj as Docente;
            if (docente == null)
            {
                return false;
            }

            return this.Cedula == docente.Cedula && this.Nombre == docente.Nombre;
        }

    }
}
