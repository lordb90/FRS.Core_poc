using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class InvPmtConfiguration : IEntityTypeConfiguration<InvPmt>
    {
        public void Configure(EntityTypeBuilder<InvPmt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("INV_PMTS");

            builder.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ENTEREDBY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Pmtamount)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PMTAMOUNT");
            builder.Property(e => e.Pmtcommnts)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PMTCOMMNTS");
            builder.Property(e => e.Pmtdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PMTDATE");
            builder.Property(e => e.Pmtdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PMTDESC");
            builder.Property(e => e.Pmtkeyid)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PMTKEYID");

        }
    }
}