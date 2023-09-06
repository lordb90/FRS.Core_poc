using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EcltacctConfiguration : IEntityTypeConfiguration<Ecltacct>
    {
        public void Configure(EntityTypeBuilder<Ecltacct> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTACCT");

            builder.Property(e => e.AdmAcct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADM_ACCT");
            builder.Property(e => e.AdmBill)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADM_BILL");
            builder.Property(e => e.AdmRpts)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADM_RPTS");
            builder.Property(e => e.Approved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("APPROVED");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Createdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Otherinfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO");
            builder.Property(e => e.ProcDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PROC_DATE");
            builder.Property(e => e.ProcUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROC_USER");
            builder.Property(e => e.Pwanswer)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PWANSWER");
            builder.Property(e => e.Pwquestion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PWQUESTION");
            builder.Property(e => e.ReqEmail)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_EMAIL");
            builder.Property(e => e.ReqName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_NAME");
            builder.Property(e => e.Requested)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REQUESTED");
            builder.Property(e => e.SecReq)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEC_REQ");
            builder.Property(e => e.SecRes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEC_RES");
            builder.Property(e => e.SecStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEC_STAT");
            builder.Property(e => e.Seereqonly)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEEREQONLY");
            builder.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");
            builder.Property(e => e.WebPw)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_PW");

        }
    }
}