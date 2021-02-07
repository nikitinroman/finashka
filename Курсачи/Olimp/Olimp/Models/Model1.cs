namespace Olimp.Models
{
    using System.Data.Entity;
    
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Subject)
                .IsFixedLength();
        }
    }
}
