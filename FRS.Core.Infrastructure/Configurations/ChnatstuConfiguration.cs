using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ChnatstuConfiguration : IEntityTypeConfiguration<Chnatstu>
{
    public void Configure(EntityTypeBuilder<Chnatstu> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CHNATSTU");

        builder.Property(e => e.Activation)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("ACTIVATION");
        builder.Property(e => e.Campus)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CAMPUS");
        builder.Property(e => e.City)
            .HasMaxLength(21)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CITY");
        builder.Property(e => e.Feescolleg)
            .HasColumnType("numeric(10, 2)")
            .HasColumnName("FEESCOLLEG");
        builder.Property(e => e.Feesretail)
            .HasColumnType("numeric(10, 2)")
            .HasColumnName("FEESRETAIL");
        builder.Property(e => e.Frscity)
            .HasMaxLength(21)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FRSCITY");
        builder.Property(e => e.Frsstate)
            .HasMaxLength(21)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FRSSTATE");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Match)
            .HasMaxLength(90)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MATCH");
        builder.Property(e => e.SchCode)
            .HasMaxLength(11)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SCH_CODE");
        builder.Property(e => e.SchName)
            .HasMaxLength(90)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SCH_NAME");
        builder.Property(e => e.Snameclean)
            .HasMaxLength(90)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SNAMECLEAN");
        builder.Property(e => e.State)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STATE");
        builder.Property(e => e.VerNum)
            .HasColumnType("numeric(6, 0)")
            .HasColumnName("VER_NUM");
    }
}