using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FaxqueueConfiguration : IEntityTypeConfiguration<Faxqueue>
    {
        public void Configure(EntityTypeBuilder<Faxqueue> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FAXQUEUE");

            builder.Property(e => e.Codetype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CODETYPE");
            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Ecode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("ECODE");
            builder.Property(e => e.FaxPort)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FAX_PORT");
            builder.Property(e => e.FaxSpeed)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("FAX_SPEED");
            builder.Property(e => e.FaxVia)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("FAX_VIA");
            builder.Property(e => e.Faxid)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("FAXID");
            builder.Property(e => e.Faxlogid)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("FAXLOGID");
            builder.Property(e => e.Hangcode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("HANGCODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IrecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("IREC_DATE");
            builder.Property(e => e.IrecTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IREC_TIME");
            builder.Property(e => e.IrtnStat)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IRTN_STAT");
            builder.Property(e => e.IrtnTrans)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IRTN_TRANS");
            builder.Property(e => e.IsentResp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ISENT_RESP");
            builder.Property(e => e.IsentXml)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ISENT_XML");
            builder.Property(e => e.IstatResp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ISTAT_RESP");
            builder.Property(e => e.ItransId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ITRANS_ID");
            builder.Property(e => e.PagesSent)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("PAGES_SENT");
            builder.Property(e => e.Printed).HasColumnName("PRINTED");
            builder.Property(e => e.Priority)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("PRIORITY");
            builder.Property(e => e.Remoteid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMOTEID");
            builder.Property(e => e.Resub).HasColumnName("RESUB");
            builder.Property(e => e.Retries)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RETRIES");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.SentDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENT_DATE");
            builder.Property(e => e.SentTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENT_TIME");
            builder.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");
            builder.Property(e => e.Timelength)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIMELENGTH");
            builder.Property(e => e.Toname)
                .HasMaxLength(42)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TONAME");
            builder.Property(e => e.Tonumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TONUMBER");
            builder.Property(e => e.Totalpages)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TOTALPAGES");
            builder.Property(e => e.WhoDel)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WHO_DEL");
            builder.Property(e => e.WhoSub)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WHO_SUB");

        }
    }
}