using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebcctrlConfiguration : IEntityTypeConfiguration<Webcctrl>
    {
        public void Configure(EntityTypeBuilder<Webcctrl> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBCCTRL");

            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Crit)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIT");
            builder.Property(e => e.DlxProd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLX_PROD");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Order)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ORDER");
            builder.Property(e => e.Searchtype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCHTYPE");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");

        }
    }
}