using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder
                .HasNoKey()
                .ToTable("INVOICE");

            builder.Property(e => e.Amtpaid)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("AMTPAID");
            builder.Property(e => e.BldtBasis)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("BLDT_BASIS");
            builder.Property(e => e.Comments)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMMENTS");
            builder.Property(e => e.CompName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_NAME");
            builder.Property(e => e.Datepaid)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATEPAID");
            builder.Property(e => e.DelMeth)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DEL_METH");
            builder.Property(e => e.DueDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DUE_DATE");
            builder.Property(e => e.Exportname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXPORTNAME");
            builder.Property(e => e.GenDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("GEN_DATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Invamt)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("INVAMT");
            builder.Property(e => e.InvimgNbr)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("INVIMG_NBR");
            builder.Property(e => e.Invnum)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INVNUM");
            builder.Property(e => e.Invnum2)
                .HasColumnType("numeric(11, 0)")
                .HasColumnName("INVNUM2");
            builder.Property(e => e.NbrSearch)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NBR_SEARCH");
            builder.Property(e => e.Pmtkeyid)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PMTKEYID");
            builder.Property(e => e.Pmtprocamt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PMTPROCAMT");
            builder.Property(e => e.Salestax)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SALESTAX");
            builder.Property(e => e.SuppCost)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SUPP_COST");
            builder.Property(e => e.Workdates)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORKDATES");
        }
    }
}