using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SupprtktConfiguration : IEntityTypeConfiguration<Supprtkt>
    {
        public void Configure(EntityTypeBuilder<Supprtkt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SUPPRTKT");

            builder.Property(e => e.TktAttch1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_ATTCH1");
            builder.Property(e => e.TktAttch2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_ATTCH2");
            builder.Property(e => e.TktAttch3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_ATTCH3");
            builder.Property(e => e.TktDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("TKT_DATE");
            builder.Property(e => e.TktEmail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_EMAIL");
            builder.Property(e => e.TktEncpw)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_ENCPW");
            builder.Property(e => e.TktId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TKT_ID");
            builder.Property(e => e.TktIssue)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_ISSUE");
            builder.Property(e => e.TktName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_NAME");
            builder.Property(e => e.TktNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_NOTES");
            builder.Property(e => e.TktNum)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("TKT_NUM");
            builder.Property(e => e.TktRetrys)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("TKT_RETRYS");
            builder.Property(e => e.TktSent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("TKT_SENT");
            builder.Property(e => e.TktSite)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_SITE");
            builder.Property(e => e.TktStatus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_STATUS");
            builder.Property(e => e.TktTime)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_TIME");
            builder.Property(e => e.TktUnqnm1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_UNQNM1");
            builder.Property(e => e.TktUnqnm2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_UNQNM2");
            builder.Property(e => e.TktUnqnm3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_UNQNM3");
            builder.Property(e => e.TktVernum)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKT_VERNUM");
        }
    }
}