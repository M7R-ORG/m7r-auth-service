using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Auth.Persistence.DBContext;

public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
{
    public EFContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Database=AuthDB;Username=postgres;Password=postgres");
        return new EFContext(optionsBuilder.Options);
    }
}
