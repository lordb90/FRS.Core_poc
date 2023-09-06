using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PstreqQConfiguration : IEntityTypeConfiguration<PstreqQ>
    {
        public void Configure(EntityTypeBuilder<PstreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PSTREQ_Q");

            builder.Property(e => e.Address1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS1");
            builder.Property(e => e.Address2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS2");
            builder.Property(e => e.Addrlast)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRLAST");
            builder.Property(e => e.Agehigh)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AGEHIGH");
            builder.Property(e => e.Agelow)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AGELOW");
            builder.Property(e => e.Alerts)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALERTS");
            builder.Property(e => e.AttCompre).HasColumnName("ATT_COMPRE");
            builder.Property(e => e.AttHist)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATT_HIST");
            builder.Property(e => e.AttUncosz).HasColumnName("ATT_UNCOSZ");
            builder.Property(e => e.Attempts)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ATTEMPTS");
            builder.Property(e => e.Bankruptcy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BANKRUPTCY");
            builder.Property(e => e.Billngcode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILLNGCODE");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Dlpurpose)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLPURPOSE");
            builder.Property(e => e.Dobday)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOBDAY");
            builder.Property(e => e.Dobmonth)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOBMONTH");
            builder.Property(e => e.Dobyear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOBYEAR");
            builder.Property(e => e.Ecode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ECODE");
            builder.Property(e => e.Glbpurpose)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GLBPURPOSE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.Namefirst)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMEFIRST");
            builder.Property(e => e.Namelast)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMELAST");
            builder.Property(e => e.Namemiddle)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMEMIDDLE");
            builder.Property(e => e.Namesuffix)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMESUFFIX");
            builder.Property(e => e.NbrAddr)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NBR_ADDR");
            builder.Property(e => e.NbrCtys)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NBR_CTYS");
            builder.Property(e => e.Nonickname)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NONICKNAME");
            builder.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSWORD");
            builder.Property(e => e.Phone10)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PHONE10");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.Pstreviewd).HasColumnName("PSTREVIEWD");
            builder.Property(e => e.Qdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("QDATE");
            builder.Property(e => e.Qtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QTIME");
            builder.Property(e => e.Queryid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYID");
            builder.Property(e => e.Radius)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RADIUS");
            builder.Property(e => e.Reference)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REFERENCE");
            builder.Property(e => e.RespRfmt)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_RFMT");
            builder.Property(e => e.RespRtn)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_RTN");
            builder.Property(e => e.Respcompre).HasColumnName("RESPCOMPRE");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.Respuncosz).HasColumnName("RESPUNCOSZ");
            builder.Property(e => e.RetrAtweb).HasColumnName("RETR_ATWEB");
            builder.Property(e => e.Returncnt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETURNCNT");
            builder.Property(e => e.Rfmtcompre).HasColumnName("RFMTCOMPRE");
            builder.Property(e => e.Rfmtuncosz).HasColumnName("RFMTUNCOSZ");
            builder.Property(e => e.Rrtncompre).HasColumnName("RRTNCOMPRE");
            builder.Property(e => e.Rrtnuncosz).HasColumnName("RRTNUNCOSZ");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.Srequest)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SREQUEST");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Ssnlast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSNLAST4");
            builder.Property(e => e.StartingR)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STARTING_R");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.Streetname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STREETNAME");
            builder.Property(e => e.Streetnbr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STREETNBR");
            builder.Property(e => e.Streetpost)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STREETPOST");
            builder.Property(e => e.Streetpre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STREETPRE");
            builder.Property(e => e.Streetsuff)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STREETSUFF");
            builder.Property(e => e.SubjName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Subpriorad)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBPRIORAD");
            builder.Property(e => e.Unitnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("UNITNUMBER");
            builder.Property(e => e.Usephonet)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USEPHONET");
            builder.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Verifyssns)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VERIFYSSNS");
            builder.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VERSION");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
            builder.Property(e => e.Zip4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP4");
        }
    }
}