using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoeFactory.Entities;

namespace ShoeFactory.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Description)
            .HasMaxLength(200);

        builder.Property(p => p.Code)
            .HasMaxLength(50);

        builder.Property(p => p.MinimalStock)
            .HasPrecision(11, 3);

        builder.Property(p => p.MaximumStock)
            .HasPrecision(11, 3);
    }
}