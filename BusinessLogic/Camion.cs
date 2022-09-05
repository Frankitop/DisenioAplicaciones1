using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Camion
    {
        public string Chapa { get; set; }
        public int Carga { get; set; }
        public static double Costoxkilo { get; private set; } = 0.5;

    }
}
