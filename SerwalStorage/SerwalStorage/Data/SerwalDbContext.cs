using Microsoft.EntityFrameworkCore;
using SerwalStorage.Entities.MainEntities;

namespace GenericPower.Data
{
    public class SerwalDbContext : DbContext
    {
        public DbSet<Profile> ProfileSet => Set<Profile>();

        public DbSet<Uszczelki> UszczelkiSet => Set<Uszczelki>();

        public DbSet<Akcesoria> AkcesoriaSet => Set<Akcesoria>();   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Serwal");
        }
    }
}
