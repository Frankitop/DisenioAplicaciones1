using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;

namespace Entidades
{
    public class Maquina
    {
        public Maquina()
        {
            this.Perifericos = new List<Periferico>();
        }

        private int _ram;
        public int Id  { get; set; }

        public string CantidadProcesadores { get; set; }

        public int RAM
        {
            get { return this._ram; }
            set
            {
                if (value < 64 || value > 512)
                {
                    throw new ExeptionValiacionNumero("La RAM debe estar entre 64 y 512");
                }

                this._ram = value;
            }
        }

        public bool TieneMonitor { get; set; }

        public int EspacioEnDisco { get; set; }

        public List<Periferico> Perifericos { get; set; }

        public override string ToString()
        {
            return this.RAM + " " + this.CantidadProcesadores + " " + this.EspacioEnDisco + " " + this.TieneMonitor + " Cant Perifericos: " + this.Perifericos.Count  ;
        }
    }
}
