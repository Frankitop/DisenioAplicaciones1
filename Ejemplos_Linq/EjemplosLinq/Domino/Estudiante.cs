using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq.Domino
{
    public class Estudiante
    {
        public string Nombre { get; set; }

        public int Cedula { get; set; }
        
        public DateTime FechaDeNacimiento { get; set; }

        public double PAC { get; set; }

        public override bool Equals(object obj)
        {
            var estudiante = obj as Estudiante;
            if (estudiante == null)
            {
                return false;
            }

            return this.Cedula == estudiante.Cedula && this.Nombre == estudiante.Nombre && this.FechaDeNacimiento == estudiante.FechaDeNacimiento;
        }
    }
}
