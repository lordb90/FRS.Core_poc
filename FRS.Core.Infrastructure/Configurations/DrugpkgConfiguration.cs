using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DrugpkgConfiguration : IEntityTypeConfiguration<Drugpkg>
    {
        public void Configure(EntityTypeBuilder<Drugpkg> builder)
        {
            builder
                .HasNoKey()
                .ToTable("DRUGPKGS");

            builder.Property(e => e.Action)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACTION");
            builder.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CATEGORY");
            builder.Property(e => e.Codevalue)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODEVALUE");
            builder.Property(e => e.Disporder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("DISPORDER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Inactive).HasColumnName("INACTIVE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.PkgKey)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PKG_KEY");
            builder.Property(e => e.Pkgdescrpt)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PKGDESCRPT");
            builder.Property(e => e.Pkgname)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PKGNAME");
            builder.Property(e => e.Prodclass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRODCLASS");
            builder.Property(e => e.Reasontest)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REASONTEST");
            builder.Property(e => e.Regtype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REGTYPE");
            builder.Property(e => e.Regulation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REGULATION");
            builder.Property(e => e.Selectdpkg).HasColumnName("SELECTDPKG");
            builder.Property(e => e.SiteId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SITE_ID");
            builder.Property(e => e.Spectype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPECTYPE");
            builder.Property(e => e.VerNum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("VER_NUM");

        }
    }
}