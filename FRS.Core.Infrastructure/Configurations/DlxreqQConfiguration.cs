using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DlxreqQConfiguration : IEntityTypeConfiguration<DlxreqQ>
    {
        public void Configure(EntityTypeBuilder<DlxreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("DLXREQ_Q");

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
                .HasColumnType("numeric(3, 0)")
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
            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.DispJuris).HasColumnName("DISP_JURIS");
            builder.Property(e => e.DlinxA7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7Y");
            builder.Property(e => e.DlinxA7yn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YN");
            builder.Property(e => e.DlinxA7ys)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YS");
            builder.Property(e => e.DlinxDob)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_DOB");
            builder.Property(e => e.DlinxE7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_E7Y");
            builder.Property(e => e.DlinxNmtc)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_NMTC");
            builder.Property(e => e.DlinxProb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_PROB");
            builder.Property(e => e.DlinxXtr2)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR2");
            builder.Property(e => e.DlinxXtr3)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR3");
            builder.Property(e => e.DlinxXtr4)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR4");
            builder.Property(e => e.DlinxXtr5)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR5");
            builder.Property(e => e.DlinxXtra)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTRA");
            builder.Property(e => e.Dlinxovral).HasColumnName("DLINXOVRAL");
            builder.Property(e => e.Dlinxstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINXSTATE");
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
                .HasMaxLength(50)
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
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYID");
            builder.Property(e => e.Reaka1comp).HasColumnName("REAKA1COMP");
            builder.Property(e => e.Reaka1ucsz).HasColumnName("REAKA1UCSZ");
            builder.Property(e => e.Reaka2comp).HasColumnName("REAKA2COMP");
            builder.Property(e => e.Reaka2ucsz).HasColumnName("REAKA2UCSZ");
            builder.Property(e => e.Reaka3comp).HasColumnName("REAKA3COMP");
            builder.Property(e => e.Reaka3ucsz).HasColumnName("REAKA3UCSZ");
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
            builder.Property(e => e.RetrAtweb).HasColumnName("RETR_ATWEB");
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
            builder.Property(e => e.Rextracomp).HasColumnName("REXTRACOMP");
            builder.Property(e => e.Rextraucsz).HasColumnName("REXTRAUCSZ");
            builder.Property(e => e.SearchAdr)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCH_ADR");
            builder.Property(e => e.SearchCit)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCH_CIT");
            builder.Property(e => e.SearchSt)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCH_ST");
            builder.Property(e => e.SearchZip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEARCH_ZIP");
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
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
            builder.Property(e => e.Userid)
                .HasMaxLength(50)
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