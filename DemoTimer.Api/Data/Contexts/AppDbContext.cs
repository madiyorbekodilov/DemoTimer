using Microsoft.EntityFrameworkCore;

namespace DemoTimer.Api.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {   }
}
