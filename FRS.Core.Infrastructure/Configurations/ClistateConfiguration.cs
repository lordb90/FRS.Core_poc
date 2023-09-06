using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ClistateConfiguration : IEntityTypeConfiguration<Clistate>
{
    public void Configure(EntityTypeBuilder<Clistate> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CLISTATE");

        builder.Property(e => e.CcEc10)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CC_EC10");
        builder.Property(e => e.CcEc15)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CC_EC15");
        builder.Property(e => e.CcEcUnl)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CC_EC_UNL");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.CourtDesc)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COURT_DESC");
        builder.Property(e => e.CvlCourt)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CVL_COURT");
        builder.Property(e => e.CvlEc10)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CVL_EC10");
        builder.Property(e => e.CvlEc15)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CVL_EC15");
        builder.Property(e => e.CvlEcUnl)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("CVL_EC_UNL");
        builder.Property(e => e.CvlYears)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CVL_YEARS");
        builder.Property(e => e.FedCourt)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FED_COURT");
        builder.Property(e => e.FedEc10)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("FED_EC10");
        builder.Property(e => e.FedEc15)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("FED_EC15");
        builder.Property(e => e.FedEcUnl)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("FED_EC_UNL");
        builder.Property(e => e.FedYears)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FED_YEARS");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.OthCourt)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("OTH_COURT");
        builder.Property(e => e.OthEc10)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("OTH_EC10");
        builder.Property(e => e.OthEc15)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("OTH_EC15");
        builder.Property(e => e.OthEcUnl)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("OTH_EC_UNL");
        builder.Property(e => e.OthYears)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("OTH_YEARS");
        builder.Property(e => e.State)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STATE");
        builder.Property(e => e.SwCourt)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SW_COURT");
        builder.Property(e => e.SwEc10)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("SW_EC10");
        builder.Property(e => e.SwEc15)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("SW_EC15");
        builder.Property(e => e.SwEcUnl)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("SW_EC_UNL");
        builder.Property(e => e.SwYears)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SW_YEARS");
        builder.Property(e => e.Years)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("YEARS");
    }
}