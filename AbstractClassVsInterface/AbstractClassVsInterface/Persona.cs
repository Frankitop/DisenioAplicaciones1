using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    // Esta clase no compila por que la Class Persona que implementa al interfaz IPersona no esta implementando los metodos de la interfaz
    // Por lo tanto no esta cumpliendo con el "contrato"
    public class Persona : IPersona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        // Al descomentar el codigo de la linea de abajos

        //public void Comer()
        //{
        //    throw new NotImplementedException();
        //}

        //public string Viajar()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
