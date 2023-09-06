using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FRS.Core.Infrastructure.Configurations
{
    public class BkAuditConfiguration : IEntityTypeConfiguration<BkAudit>
    {
        public void Configure(EntityTypeBuilder<BkAudit> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_AUDIT");

            builder.Property(e => e.Acode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACODE");
            builder.Property(e => e.Adate)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADATE");
            builder.Property(e => e.Akey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("AKEY");
            builder.Property(e => e.Aref)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AREF");
            builder.Property(e => e.Atime)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATIME");
            builder.Property(e => e.Auser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AUSER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        }
    }
}
