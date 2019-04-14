using BackendFinal.Db.Configurations;
using BackendFinal.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendFinal.Db.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Model> Models { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModelTypeConfiguration());
        }
    }
}
