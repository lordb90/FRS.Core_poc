using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EmailQConfiguration : IEntityTypeConfiguration<EmailQ>
    {
        public void Configure(EntityTypeBuilder<EmailQ> builder)
        {
            builder.HasNoKey()
                .ToTable("EMAIL_Q");

            builder.Property(e => e.Addtlcode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDTLCODE");
            builder.Property(e => e.Comprescod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMPRESCOD");
            builder.Property(e => e.Desc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Ecode)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ECODE");
            builder.Property(e => e.EmailAddr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMAIL_ADDR");
            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.Format)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FORMAT");
            builder.Property(e => e.Fromemladr)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FROMEMLADR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Invrdy2snd).HasColumnName("INVRDY2SND");
            builder.Property(e => e.Message)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MESSAGE");
            builder.Property(e => e.Printed).HasColumnName("PRINTED");
            builder.Property(e => e.Replyto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REPLYTO");
            builder.Property(e => e.Retries)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("RETRIES");
            builder.Property(e => e.Rpassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPASSWORD");
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
            builder.Property(e => e.Subtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBTYPE");
            builder.Property(e => e.Toname)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TONAME");
            builder.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
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