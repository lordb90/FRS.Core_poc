using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class Billcod2Configuration : IEntityTypeConfiguration<Billcod2>
{
    public void Configure(EntityTypeBuilder<Billcod2> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BILLCOD2");

        builder.Property(e => e.Desc)
            .HasMaxLength(31)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DESC");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Itemtype)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ITEMTYPE");
        builder.Property(e => e.Price)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("PRICE");
    }
}