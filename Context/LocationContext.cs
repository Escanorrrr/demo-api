using my_app.Entities;
using Microsoft.EntityFrameworkCore;

namespace my_app.Context
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options) { }


        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
