using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class BillxtraConfiguration : IEntityTypeConfiguration<Billxtra>
{
    public void Configure(EntityTypeBuilder<Billxtra> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BILLXTRA");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(10, 2)")
            .HasColumnName("AMOUNT");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.CompName)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_NAME");
        builder.Property(e => e.Datebilled)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATEBILLED");
        builder.Property(e => e.Dateenterd)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATEENTERD");
        builder.Property(e => e.Descript)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DESCRIPT");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Invoiced)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("INVOICED");
        builder.Property(e => e.Key)
            .HasColumnType("numeric(8, 0)")
            .HasColumnName("KEY");
        builder.Property(e => e.SubjName)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUBJ_NAME");
        builder.Property(e => e.Username)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("USERNAME");
    }
}