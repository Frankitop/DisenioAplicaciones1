using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sistema : DbContext
    {
        public Sistema()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //CASO 1:
            //Una sola tabla padre
            //Cambiar discriminator por defecto (Type)
            modelBuilder.Entity<Maquina>()
                .Map<Maquina>(m => m.Requires("Type").HasValue("Maquina"))
                .Map<Laptop>(m => m.Requires("Type").HasValue("Laptop"))
                .Map<Escritorio>(m => m.Requires("Type").HasValue("Escritorio"));

        }

        public DbSet<Maquina> Maquinas { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Escritorio> Escritorios { get; set; }

        public DbSet<Periferico> Perifericos { get; set; }

        public void InitializeDB()
        {
            this.Database.CreateIfNotExists();
        }

    }
}
