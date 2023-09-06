using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CountyConfiguration : IEntityTypeConfiguration<County>
{
    public void Configure(EntityTypeBuilder<County> builder)
    {
        builder
            .HasNoKey()
            .ToTable("COUNTY");

        builder.Property(e => e.AssocCty)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ASSOC_CTY");
        builder.Property(e => e.City)
            .HasMaxLength(26)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CITY");
        builder.Property(e => e.County1)
            .HasMaxLength(26)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COUNTY");
        builder.Property(e => e.ExtraEta)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EXTRA_ETA");
        builder.Property(e => e.Federal)
            .HasMaxLength(26)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FEDERAL");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.State)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STATE");
        builder.Property(e => e.TatHrs)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("TAT_HRS");
        builder.Property(e => e.Zip)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ZIP");
    }
}