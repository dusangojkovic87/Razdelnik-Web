using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Razdelnik.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> User { get; set; }


}

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        // Ovde stavi connection string direktno ili iz env var
        optionsBuilder.UseSqlServer("Server=DUSAN;Database=Razdelnik;Trusted_Connection=True;Encrypt=False;");

        return new AppDbContext(optionsBuilder.Options);
    }
}
