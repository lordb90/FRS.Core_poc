using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConmatchConfiguration : IEntityTypeConfiguration<Conmatch>
{
    public void Configure(EntityTypeBuilder<Conmatch> builder)
    {
        builder.HasNoKey()
            .ToTable("CONMATCH");

        builder.Property(e => e.AvgCall)
            .HasColumnType("numeric(4, 0)")
            .HasColumnName("AVG_CALL");
        builder.Property(e => e.Call).HasColumnName("CALL");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.FcId)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FC_ID");
        builder.Property(e => e.Fusercalls)
            .HasColumnType("numeric(8, 0)")
            .HasColumnName("FUSERCALLS");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.LastCall)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("LAST_CALL");
        builder.Property(e => e.ModemNbr)
            .HasMaxLength(17)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MODEM_NBR");
        builder.Property(e => e.Status)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STATUS");
        builder.Property(e => e.TSitename)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("T_SITENAME");
    }
}