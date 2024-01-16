using AloyMysql.Models;
using Microsoft.EntityFrameworkCore;

namespace AloyMysql.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action"},
                new Category { Id = 2, Name = "Horror"},
                new Category { Id = 3, Name = "History"}
                );
        }
    }
}
