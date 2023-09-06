using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ChwrknbrConfiguration : IEntityTypeConfiguration<Chwrknbr>
{
    public void Configure(EntityTypeBuilder<Chwrknbr> builder)
    {
       builder
            .HasNoKey()
            .ToTable("CHWRKNBR");

        builder.Property(e => e.EmpCode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMP_CODE");
        builder.Property(e => e.EmpName)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMP_NAME");
        builder.Property(e => e.Enameclean)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ENAMECLEAN");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.VerNum)
            .HasColumnType("numeric(6, 0)")
            .HasColumnName("VER_NUM");
    }
}