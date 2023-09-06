using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConvctrmConfiguration : IEntityTypeConfiguration<Convctrm>
{
    public void Configure(EntityTypeBuilder<Convctrm> builder)
    {
        builder.HasNoKey()
            .ToTable("CONVCTRM");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Text)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TEXT");
    }
}