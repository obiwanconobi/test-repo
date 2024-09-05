using Microsoft.EntityFrameworkCore;
using shearwell_test.DataAccess.Maps;
using shearwell_test.Models;
using System.Security.Principal;

namespace shearwell_test.DataAccess
{
    public class UnitOfWork : DbContext
    {

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<AnimalGroupRel> AnimalGroupRel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.ApplyConfiguration(new AnimalGroupRelMap());


        }

    }
}
