using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PerifericoContext
    {
        private Sistema dataContext;

        public PerifericoContext(Sistema dataContext)
        {
            this.dataContext = dataContext;
        }

        public void AgregarPeriferico(Periferico periferico)
        {
            this.dataContext.Perifericos.Add(periferico);
            this.dataContext.SaveChanges();
        }

        public List<Periferico> ObtenerListadoPerifericos()
        {
           return this.dataContext.Perifericos.ToList();
        }
    }
}
