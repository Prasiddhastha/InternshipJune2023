


using EntityPrac.Models;

namespace EntityPrac.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=MercylessBeast\SQLEXPRESS;Database=JuneInternship;Trusted_Connection=True;trustserverCertificate=true;");
        }
        public DbSet<Customer>Customers { get; set; }
    }
}
