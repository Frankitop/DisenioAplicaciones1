using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MaquinaContext
    {
        private Sistema dataContext;

        public MaquinaContext(Sistema dataContext)
        {
             this.dataContext = dataContext;
        }

        public List<Maquina> ObtenerListadoMaquinas()
        {
            return this.dataContext.Maquinas.Include("Perifericos").ToList();  
        }

        public void AgregarMaquina(Maquina maquina) 
        {
            this.dataContext.Maquinas.Add(maquina);
            this.dataContext.SaveChanges(); 
        }

        public void AgregaLaptop(Laptop maquina)
        {
            this.dataContext.Laptops.Add(maquina);
            this.dataContext.SaveChanges();
        }

        public void AgregarEscritorio(Escritorio maquina)
        {
            this.dataContext.Escritorios.Add(maquina);
            this.dataContext.SaveChanges();
        }

        public void ActualizarMaquina(Maquina maquina)
        {
            Maquina prevMaquina = this.dataContext.Maquinas.Where(maquinaFiltrada => maquinaFiltrada.Id == maquina.Id).FirstOrDefault();
            if (prevMaquina != null)
            {
                prevMaquina = maquina;
                this.dataContext.SaveChanges();
            }
        }

        public Maquina ObtenerPorId(int id)
        {
            Maquina find = this.dataContext.Maquinas.Where(m => m.Id == id).FirstOrDefault();
            this.dataContext.Entry(find).Collection(m => m.Perifericos).Load();
            return find;
        }
    }
}
