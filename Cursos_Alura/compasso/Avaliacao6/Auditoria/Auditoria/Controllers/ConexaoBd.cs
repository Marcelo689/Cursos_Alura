using Microsoft.EntityFrameworkCore;

namespace Auditoria
{
    public class ConexaoBd : DbContext
    {
        public DbSet<Auditoria> Auditoria { get; set; }
        public DbSet<Login> Login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Auditoria;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
