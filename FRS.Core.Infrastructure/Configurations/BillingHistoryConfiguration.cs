using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class BillingHistoryConfiguration : IEntityTypeConfiguration<BillingHistory>
{
    public void Configure(EntityTypeBuilder<BillingHistory> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BILLING_HISTORY");

        builder.Property(e => e.Adtlsetngs)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ADTLSETNGS");
        builder.Property(e => e.BasedOn)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BASED_ON");
        builder.Property(e => e.BlCopies)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("BL_COPIES");
        builder.Property(e => e.DueDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DUE_DATE");
        builder.Property(e => e.EndDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("END_DATE");
        builder.Property(e => e.GenDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("GEN_DATE");
        builder.Property(e => e.GenTime)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("GEN_TIME");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.InvCopies)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("INV_COPIES");
        builder.Property(e => e.InvDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("INV_DATE");
        builder.Property(e => e.Master)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MASTER");
        builder.Property(e => e.NbrClient)
            .HasColumnType("numeric(5, 0)")
            .HasColumnName("NBR_CLIENT");
        builder.Property(e => e.QbExport)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("QB_EXPORT");
        builder.Property(e => e.StartDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("START_DATE");
        builder.Property(e => e.UserName)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("USER_NAME");
    }
}