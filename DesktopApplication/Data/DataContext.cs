



namespace DesktopApplication.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MercylessBeast\SQLEXPRESS;Database=JuneInternship;Trusted_Connection=True;trustserverCertificate=true;");
        }
     
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students1 { get; set; }
    }
}
