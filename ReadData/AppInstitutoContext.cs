using Microsoft.EntityFrameworkCore;

namespace ReadData
{
    public class AppInstitutoContext : DbContext
    {
        private const string connectionString = @"server=127.0.0.1;port=3306;database=instituto;user=developerOne;password=Cometsora-4;old guids=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Profesor>().HasKey( pi => new { pi.dni } );
        }

        public DbSet<Profesor> Profesor { get; set; }
    }
}