using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class AffiltblConfiguration : IEntityTypeConfiguration<Affiltbl>
    {
        public void Configure(EntityTypeBuilder<Affiltbl> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AFFILTBL");

            builder.Property(e => e.Address1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS1");
            builder.Property(e => e.Address2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS2");
            builder.Property(e => e.Address3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS3");
            builder.Property(e => e.Aemail)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AEMAIL");
            builder.Property(e => e.AffCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFF_CODE");
            builder.Property(e => e.AffName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFF_NAME");
            builder.Property(e => e.Altfromeml)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTFROMEML");
            builder.Property(e => e.Attention)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTENTION");
            builder.Property(e => e.Billtype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("BILLTYPE");
            builder.Property(e => e.FaxNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_NUMBER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Logo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOGO");
            builder.Property(e => e.MvrCAcct)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_ACCT");
            builder.Property(e => e.MvrCDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("MVR_C_DATE");
            builder.Property(e => e.MvrCPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_PASS");
            builder.Property(e => e.MvrCUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_USER");
            builder.Property(e => e.Notes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOTES");
            builder.Property(e => e.StiPacode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_PACODE");
            builder.Property(e => e.StiPasswd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_PASSWD");
            builder.Property(e => e.StiUsercd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_USERCD");
            builder.Property(e => e.StiUserid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_USERID");
            builder.Property(e => e.Stica2date)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("STICA2DATE");
            builder.Property(e => e.Stica2ndpw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STICA2NDPW");
            builder.Property(e => e.Stipasdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("STIPASDATE");
            builder.Property(e => e.VoicePhon)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VOICE_PHON");


        }
    }
}
