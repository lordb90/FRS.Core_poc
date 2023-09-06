using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EcltbillConfiguration : IEntityTypeConfiguration<Ecltbill>
    {
        public void Configure(EntityTypeBuilder<Ecltbill> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTBILL");

            builder.Property(e => e.AmountDue)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("AMOUNT_DUE");
            builder.Property(e => e.BlistPdf)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BLIST_PDF");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Dtsent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DTSENT");
            builder.Property(e => e.DueDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DUE_DATE");
            builder.Property(e => e.Group)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GROUP");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InvDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("INV_DATE");
            builder.Property(e => e.InvPdf)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INV_PDF");
            builder.Property(e => e.Invamt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INVAMT");
            builder.Property(e => e.Invnum)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INVNUM");
            builder.Property(e => e.MasterInv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MASTER_INV");
            builder.Property(e => e.Mstrgroup)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSTRGROUP");
            builder.Property(e => e.NbrSearch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NBR_SEARCH");
            builder.Property(e => e.Paid).HasColumnName("PAID");
            builder.Property(e => e.PaidDt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PAID_DT");
            builder.Property(e => e.Remdttime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REMDTTIME");
            builder.Property(e => e.Remfromweb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMFROMWEB");
            builder.Property(e => e.Remusrname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMUSRNAME");
            builder.Property(e => e.Reprintweb).HasColumnName("REPRINTWEB");
            builder.Property(e => e.Sent2web).HasColumnName("SENT2WEB");
            builder.Property(e => e.ToRemove).HasColumnName("TO_REMOVE");
            builder.Property(e => e.Viewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VIEWED");
            builder.Property(e => e.Workdates)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORKDATES");
        }
    }
}