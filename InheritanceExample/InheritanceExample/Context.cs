using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Context: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public Context()
        {

        }

        #region TPH
        //CASO 1:
        //Una sola tabla padre
        //Cambiar discriminator por defecto (PersonType)

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>()
        //                .Map<Teacher>(m => m.Requires("PersonType").HasValue("T"))
        //                .Map<Student>(m => m.Requires("PersonType").HasValue("S"));
        //}
        #endregion

        #region TPT
        //CASO 2:
        //Tres tablas
        //Se puede hacer tambien mediante DataAnnotations [Table("Teachers")]

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Student>().ToTable("Students");
        }
        #endregion

        #region TPC
        //CASO 3:
        //Dos tablas hijas
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(p => p.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Teacher>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Teachers");
            });

            modelBuilder.Entity<Student>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Students");
            });
        }*/
        #endregion

    }
}
