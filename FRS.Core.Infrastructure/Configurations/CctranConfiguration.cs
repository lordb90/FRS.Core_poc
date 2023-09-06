using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CctranConfiguration : IEntityTypeConfiguration<Cctran>
{
    public void Configure(EntityTypeBuilder<Cctran> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CCTRANS");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(10, 2)")
            .HasColumnName("AMOUNT");
        builder.Property(e => e.CcCharged).HasColumnName("CC_CHARGED");
        builder.Property(e => e.CcChrgdt)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("CC_CHRGDT");
        builder.Property(e => e.Cctranguid)
            .HasMaxLength(64)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CCTRANGUID");
        builder.Property(e => e.Cctransid)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CCTRANSID");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.CustId)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CUST_ID");
        builder.Property(e => e.Customerip)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CUSTOMERIP");
        builder.Property(e => e.Custprofid)
            .HasMaxLength(64)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CUSTPROFID");
        builder.Property(e => e.Dateenterd)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATEENTERD");
        builder.Property(e => e.Datetochrg)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATETOCHRG");
        builder.Property(e => e.Descript)
            .HasMaxLength(254)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DESCRIPT");
        builder.Property(e => e.Email)
            .HasMaxLength(254)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMAIL");
        builder.Property(e => e.Frsid)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FRSID");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Invnum)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("INVNUM");
        builder.Property(e => e.Invoiced).HasColumnName("INVOICED");
        builder.Property(e => e.LineItem)
            .HasMaxLength(254)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LINE_ITEM");
        builder.Property(e => e.Marked).HasColumnName("MARKED");
        builder.Property(e => e.Maskedcard)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MASKEDCARD");
        builder.Property(e => e.Paymprofid)
            .HasMaxLength(64)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PAYMPROFID");
        builder.Property(e => e.PoNum)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PO_NUM");
        builder.Property(e => e.Processed).HasColumnName("PROCESSED");
        builder.Property(e => e.RAuthcode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_AUTHCODE");
        builder.Property(e => e.RCode)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_CODE");
        builder.Property(e => e.RReason)
            .HasMaxLength(254)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_REASON");
        builder.Property(e => e.RReasoncd)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_REASONCD");
        builder.Property(e => e.RResponse)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_RESPONSE");
        builder.Property(e => e.RSubcode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("R_SUBCODE");
        builder.Property(e => e.Recurbill).HasColumnName("RECURBILL");
        builder.Property(e => e.Subjfirst)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUBJFIRST");
        builder.Property(e => e.Subjkey)
            .HasColumnType("numeric(8, 0)")
            .HasColumnName("SUBJKEY");
        builder.Property(e => e.Subjlast)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUBJLAST");
        builder.Property(e => e.Subjmid)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUBJMID");
        builder.Property(e => e.Subjssnmsk)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUBJSSNMSK");
        builder.Property(e => e.Synced).HasColumnName("SYNCED");
        builder.Property(e => e.Tstrequest)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TSTREQUEST");
        builder.Property(e => e.Typeofchrg)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TYPEOFCHRG");
        builder.Property(e => e.UnqOrder)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("UNQ_ORDER");
    }
}