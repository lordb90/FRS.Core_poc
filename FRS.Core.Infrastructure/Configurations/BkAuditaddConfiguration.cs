using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace FRS.Core.Infrastructure.Configurations
{
    public class BkAuditaddConfiguration : IEntityTypeConfiguration<BkAuditadd>
    {
        public void Configure(EntityTypeBuilder<BkAuditadd> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_AUDITADD");

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
}
