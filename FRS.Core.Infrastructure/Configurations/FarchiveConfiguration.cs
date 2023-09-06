using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FarchiveConfiguration : IEntityTypeConfiguration<Farchive>
    {
        public void Configure(EntityTypeBuilder<Farchive> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FARCHIVE");

            builder.Property(e => e.ArchDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ARCH_DATE");
            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Name)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.RecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REC_DATE");
            builder.Property(e => e.RecFound)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_FOUND");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
        }
    }
}