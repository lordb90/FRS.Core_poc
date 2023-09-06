using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConbatchConfiguration : IEntityTypeConfiguration<Conbatch>
{
    public void Configure(EntityTypeBuilder<Conbatch> builder)
    {
        builder.HasNoKey()
            .ToTable("CONBATCH");

        builder.Property(e => e.Cmode)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CMODE");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Pickupdate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("PICKUPDATE");
        builder.Property(e => e.Pickuptime)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PICKUPTIME");
        builder.Property(e => e.SrchqNbr)
            .HasColumnType("numeric(7, 0)")
            .HasColumnName("SRCHQ_NBR");
    }
}