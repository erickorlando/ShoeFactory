using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoeFactory.Entities;

namespace ShoeFactory.Persistence.Configurations;

public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.Property(p => p.SunatCode)
            .IsUnicode(false)
            .HasMaxLength(10);
    }
}