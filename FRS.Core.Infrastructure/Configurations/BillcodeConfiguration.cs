using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class BillcodeConfiguration : IEntityTypeConfiguration<Billcode>
{
    public void Configure(EntityTypeBuilder<Billcode> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BILLCODE");

        builder.Property(e => e.Billcode1)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILLCODE");
        builder.Property(e => e.Desc)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DESC");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Inactive)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("INACTIVE");
        builder.Property(e => e.Order)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("ORDER");
        builder.Property(e => e.Price)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("PRICE");
    }
}