using Microsoft.EntityFrameworkCore;
using SerwalStorage.Entities.MainEntities;

namespace GenericPower.Data
{
    public class SerwalDbContext : DbContext
    {
        public DbSet<Profiles> ProfileSet => Set<Profiles>();

        public DbSet<Gaskets> UszczelkiSet => Set<Gaskets>();

        public DbSet<Accessories> AkcesoriaSet => Set<Accessories>();   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Serwal");
        }
    }
}
