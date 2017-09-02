namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBiblioteca : DbContext
    {
        public ModelBiblioteca()
            : base("name=ModelBiblioteca")
        {
        }

        public virtual DbSet<cliente> cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cliente>()
                .Property(e => e.nombre_cliente)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.apellido_paterno)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>().Property(e => e.apellido_materno).IsUnicode(false);
        }
    }
}
