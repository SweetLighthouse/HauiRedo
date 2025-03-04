using Microsoft.EntityFrameworkCore;

using HauiRedo.Domain.Entities;
using HauiRedo.Infrastructure.Configurations;

namespace HauiRedo.Domain.Context;

public class MainDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Computer> Computers { get; set; }

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
        this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new ComputerConfiguration());
    }
}
