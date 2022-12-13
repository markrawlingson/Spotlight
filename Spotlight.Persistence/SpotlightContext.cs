using Microsoft.EntityFrameworkCore;
using Spotlight.Entities;

namespace Spotlight.Persistence;

public class SpotlightContext : DbContext
{

    public SpotlightContext(DbContextOptions<SpotlightContext> options)
        : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Spotlight.db3");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<Show> Shows { get; set; }
    public DbSet<Controller> Controllers { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Sequence> Sequences { get; set; }
    public DbSet<Preference> Preferences { get; set; }
}
