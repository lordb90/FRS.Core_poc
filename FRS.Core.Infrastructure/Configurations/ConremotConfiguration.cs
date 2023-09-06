using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConremotConfiguration : IEntityTypeConfiguration<Conremot>
{
    public void Configure(EntityTypeBuilder<Conremot> builder)
    {
        builder.HasNoKey()
            .ToTable("CONREMOT");

        builder.Property(e => e.FcId)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FC_ID");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.ModemNbr)
            .HasMaxLength(17)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MODEM_NBR");
        builder.Property(e => e.SiteName)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SITE_NAME");
    }
}