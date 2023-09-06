using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TrksetchgConfiguration : IEntityTypeConfiguration<Trksetchg>
    {
        public void Configure(EntityTypeBuilder<Trksetchg> builder)
        {
            builder.HasNoKey()
                .ToTable("TRKSETCHGS");

            builder.Property(e => e.AdminOnly).HasColumnName("ADMIN_ONLY");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.NewValue)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NEW_VALUE");
            builder.Property(e => e.OldValue)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OLD_VALUE");
            builder.Property(e => e.Scdatetime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SCDATETIME");
            builder.Property(e => e.Scdescript)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCDESCRIPT");
            builder.Property(e => e.Scfulltype)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCFULLTYPE");
            builder.Property(e => e.Sctype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCTYPE");
            builder.Property(e => e.Scuserid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCUSERID");
            builder.Property(e => e.Scusername)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCUSERNAME");

        }
    }
}