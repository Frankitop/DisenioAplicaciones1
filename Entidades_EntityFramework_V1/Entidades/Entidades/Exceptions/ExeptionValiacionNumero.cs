using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class ExeptionValiacionNumero : Exception
    {
        public ExeptionValiacionNumero(string message) : base (message)
        {
        }
    }
}
