using Microsoft.EntityFrameworkCore;

namespace BackendFinal.Db.Factories.Contracts
{
    public interface IDbContextFactory<out TContext>
        where TContext : DbContext
    {
        TContext CreateContext();
    }
}
