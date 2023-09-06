using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class BlcdjurConfiguration : IEntityTypeConfiguration<Blcdjur>
{
    public void Configure(EntityTypeBuilder<Blcdjur> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BLCDJUR");

        builder.Property(e => e.Billcode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILLCODE");
        builder.Property(e => e.CmcvFlag)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CMCV_FLAG");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.County)
            .HasMaxLength(26)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COUNTY");
        builder.Property(e => e.Court)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COURT");
        builder.Property(e => e.Crstate)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CRSTATE");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Noaddst).HasColumnName("NOADDST");
        builder.Property(e => e.OthDesc)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("OTH_DESC");
        builder.Property(e => e.SrchCrit)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SRCH_CRIT");
        builder.Property(e => e.SrchFed).HasColumnName("SRCH_FED");
        builder.Property(e => e.SrchFel).HasColumnName("SRCH_FEL");
        builder.Property(e => e.SrchLc).HasColumnName("SRCH_LC");
        builder.Property(e => e.SrchMisd).HasColumnName("SRCH_MISD");
        builder.Property(e => e.SrchOth).HasColumnName("SRCH_OTH");
        builder.Property(e => e.SrchUc).HasColumnName("SRCH_UC");
    }
}