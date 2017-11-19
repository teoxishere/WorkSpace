namespace DrugStoreReloaded.Models.Domain
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
       
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Pacient> Pacients { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}