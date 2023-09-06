using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class AuditlstConfiguration : IEntityTypeConfiguration<Auditlst>
{
    public void Configure(EntityTypeBuilder<Auditlst> builder)
    {
        builder
            .HasNoKey()
            .ToTable("AUDITLST");

        builder.Property(e => e.Aucode)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AUCODE");
        builder.Property(e => e.Audesc)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AUDESC");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
    }
}