using Microsoft.EntityFrameworkCore;
using ShoeFactory.Entities;

namespace ShoeFactory.Persistence;

public class ShoeFactoryDbContext : DbContext
{
    public ShoeFactoryDbContext(DbContextOptions<ShoeFactoryDbContext> options)
    : base(options)
    {

    }

    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<DocumentType> DocumentTypes { get; set; } = default!;
    public DbSet<Movement> Movements { get; set; } = default!;
    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Currency> Currencies { get; set; } = default!;
    public DbSet<Leather> Leathers { get; set; } = default!;
    public DbSet<Model> Models { get; set; } = default!;
    public DbSet<PaymentType> PaymentTypes { get; set; } = default!;
    public DbSet<SectionCode> SectionCodes { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShoeFactoryDbContext).Assembly);
    }


}
