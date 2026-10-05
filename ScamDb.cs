using Microsoft.EntityFrameworkCore;

class ScamDb : DbContext
{
    public ScamDb(DbContextOptions<ScamDb> options)
        : base(options) { }

    public DbSet<Scam> Scams => Set<Scam>();
}