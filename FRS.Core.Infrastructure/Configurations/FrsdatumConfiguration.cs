using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FrsdatumConfiguration : IEntityTypeConfiguration<Frsdatum>
    {
        public void Configure(EntityTypeBuilder<Frsdatum> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FRSDATA");

            builder.Property(e => e.Clegend)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLEGEND");
            builder.Property(e => e.Cxaxis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CXAXIS");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Ldetach).HasColumnName("LDETACH");
            builder.Property(e => e.Ncolor).HasColumnName("NCOLOR");
            builder.Property(e => e.Nvalue1)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("NVALUE1");
            builder.Property(e => e.Nvalue2)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("NVALUE2");
            builder.Property(e => e.Nvalue3)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("NVALUE3");
            builder.Property(e => e.Nvalue4)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("NVALUE4");
            builder.Property(e => e.Queryid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYID");
            builder.Property(e => e.Queryname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYNAME");

        }
    }
}