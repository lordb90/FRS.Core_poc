using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FrsupdQConfiguration : IEntityTypeConfiguration<FrsupdQ>
    {
        public void Configure(EntityTypeBuilder<FrsupdQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FRSUPD_Q");

            builder.Property(e => e.Action)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACTION");
            builder.Property(e => e.AuditKey)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AUDIT_KEY");
            builder.Property(e => e.Codedata)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODEDATA");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.CompDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_DATE");
            builder.Property(e => e.DateEnter)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DATE_ENTER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Source)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SOURCE");
            builder.Property(e => e.Subjectkey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJECTKEY");
            builder.Property(e => e.Synced).HasColumnName("SYNCED");
            builder.Property(e => e.TimeEnter)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIME_ENTER");
            builder.Property(e => e.Timezone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIMEZONE");
            builder.Property(e => e.Username)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");

        }
    }
}