using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sistema
    {
        public Sistema()
        {
            this.Maquinas = new List<Maquina>();
            this.Perifericos = new List<Periferico>();
        }

        public List<Maquina> Maquinas { get; set; }

        public List<Periferico> Perifericos { get; set; }

        //public void AgergarMaquina(Maquina m)

        //public Sistema getInstance()
        //{
        //    return this;
        //}
    }
}
