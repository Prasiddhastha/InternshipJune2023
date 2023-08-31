using Microsoft.Extensions.Options;
using WindowsApplication.Models;

namespace WindowsApplication.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MercylessBeast\SQLEXPRESS;Database=JuneInternship;Trusted_Connection=True;trustserverCertificate=true;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .Property(s => s.Id)
        //        .ValueGeneratedOnAdd();

        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Student> Students { get; set; }
    }
}
