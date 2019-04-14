using BackendFinal.Db.Context;
using BackendFinal.Db.Factories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BackendFinal.Db.Factories
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>
    {
        private readonly DbContextOptions _options;

        public AppDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public AppDbContext CreateContext()
        {
            return new AppDbContext(_options);
        }
    }
}
