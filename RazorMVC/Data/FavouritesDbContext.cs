using Microsoft.EntityFrameworkCore;

namespace RazorMVC.Data
{
    public class FavouritesDbContext : DbContext
    {
        public FavouritesDbContext(DbContextOptions<FavouritesDbContext> options) : base(options)
        {
        }

        public DbSet<Favourite> Favourites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favourite>().ToTable("Favourite");
        }
    }
}
