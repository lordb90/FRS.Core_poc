using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class AuditaddConfiguration : IEntityTypeConfiguration<Auditadd>
{
    public void Configure(EntityTypeBuilder<Auditadd> builder)
    {
        builder
            .HasNoKey()
            .ToTable("AUDITADD");

        builder.Property(e => e.AuditKey)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AUDIT_KEY");
        builder.Property(e => e.Extrainfo)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EXTRAINFO");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");

    }
}