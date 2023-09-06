using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace FRS.Core.Infrastructure.Configurations
{
    public class BkDlxrqConfiguration : IEntityTypeConfiguration<BkDlxrq>
    {
        public void Configure(EntityTypeBuilder<BkDlxrq> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_DLXRQ");

            builder.Property(e => e.AffSupCd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFF_SUP_CD");
            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.AttHist)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATT_HIST");
            builder.Property(e => e.Attempts)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ATTEMPTS");
            builder.Property(e => e.Billngcode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILLNGCODE");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DispJuris).HasColumnName("DISP_JURIS");
            builder.Property(e => e.DlinxDob)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_DOB");
            builder.Property(e => e.DlinxXtra)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTRA");
            builder.Property(e => e.Dlinxovral).HasColumnName("DLINXOVRAL");
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
            builder.Property(e => e.Frsproduct)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRSPRODUCT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Incnulldob).HasColumnName("INCNULLDOB");
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
            builder.Property(e => e.Namematch).HasColumnName("NAMEMATCH");
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
            builder.Property(e => e.NbrHits)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NBR_HITS");
            builder.Property(e => e.NumAkas)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("NUM_AKAS");
            builder.Property(e => e.OstDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_DESC");
            builder.Property(e => e.OstType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_TYPE");
            builder.Property(e => e.Password)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSWORD");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
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
            builder.Property(e => e.Reference)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REFERENCE");
            builder.Property(e => e.RespAka1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA1");
            builder.Property(e => e.RespAka2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA2");
            builder.Property(e => e.RespAka3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA3");
            builder.Property(e => e.RespAka4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA4");
            builder.Property(e => e.RespAka5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA5");
            builder.Property(e => e.RespAka6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA6");
            builder.Property(e => e.RespAka7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA7");
            builder.Property(e => e.RespAka8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA8");
            builder.Property(e => e.RespAka9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_AKA9");
            builder.Property(e => e.RespExtra)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_EXTRA");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.RextrAka1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA1");
            builder.Property(e => e.RextrAka2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA2");
            builder.Property(e => e.RextrAka3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA3");
            builder.Property(e => e.RextrAka4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA4");
            builder.Property(e => e.RextrAka5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA5");
            builder.Property(e => e.RextrAka6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA6");
            builder.Property(e => e.RextrAka7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA7");
            builder.Property(e => e.RextrAka8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA8");
            builder.Property(e => e.RextrAka9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTR_AKA9");
            builder.Property(e => e.SearchSt)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCH_ST");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.SiteId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SITE_ID");
            builder.Property(e => e.SreqAka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SREQ_AKA");
            builder.Property(e => e.Srequest)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SREQUEST");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.SubjName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Transid)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRANSID");
            builder.Property(e => e.Userid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VERSION");
        }
    }
}
