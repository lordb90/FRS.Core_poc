using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SalestaxConfiguration : IEntityTypeConfiguration<Salestax>
    {
        public void Configure(EntityTypeBuilder<Salestax> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SALESTAX");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InvDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("INV_DATE");
            builder.Property(e => e.InvNum)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INV_NUM");
            builder.Property(e => e.InvNum2)
                .HasColumnType("numeric(11, 0)")
                .HasColumnName("INV_NUM2");
            builder.Property(e => e.SalesTax1)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("SALES_TAX");
            builder.Property(e => e.Salestxamt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SALESTXAMT");
            builder.Property(e => e.Taxsupchrg).HasColumnName("TAXSUPCHRG");

        }
    }
}