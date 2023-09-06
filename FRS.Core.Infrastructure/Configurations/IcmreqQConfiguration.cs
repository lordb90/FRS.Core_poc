using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IcmreqQConfiguration : IEntityTypeConfiguration<IcmreqQ>
    {
        public void Configure(EntityTypeBuilder<IcmreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ICMREQ_Q");

            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.AttHist)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATT_HIST");
            builder.Property(e => e.Attempts)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("ATTEMPTS");
            builder.Property(e => e.Billngcode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILLNGCODE");
            builder.Property(e => e.CcCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CODE");
            builder.Property(e => e.CcExpire)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_EXPIRE");
            builder.Property(e => e.CcZip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_ZIP");
            builder.Property(e => e.Cmcv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.CtyToSnd)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CTY_TO_SND");
            builder.Property(e => e.DelayComp)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DELAY_COMP");
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
            builder.Property(e => e.FlgSpecin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FLG_SPECIN");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IhrRun)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IHR_RUN");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LastAtt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_ATT");
            builder.Property(e => e.MultiPass).HasColumnName("MULTI_PASS");
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
            builder.Property(e => e.NbrHits)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("NBR_HITS");
            builder.Property(e => e.NumAkas)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("NUM_AKAS");
            builder.Property(e => e.Partial).HasColumnName("PARTIAL");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.Provider)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROVIDER");
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
            builder.Property(e => e.Receipt)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("RECEIPT");
            builder.Property(e => e.ReqAcct).HasColumnName("REQ_ACCT");
            builder.Property(e => e.ReqCc).HasColumnName("REQ_CC");
            builder.Property(e => e.RespExtra)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESP_EXTRA");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.Retrieved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETRIEVED");
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
            builder.Property(e => e.SpecInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPEC_INSTR");
            builder.Property(e => e.SrcArrFd).HasColumnName("SRC_ARR_FD");
            builder.Property(e => e.SrcCrit)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRC_CRIT");
            builder.Property(e => e.SrcDelay)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("SRC_DELAY");
            builder.Property(e => e.SrcDobpm)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("SRC_DOBPM");
            builder.Property(e => e.SrcDobval)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SRC_DOBVAL");
            builder.Property(e => e.SrcFreeze).HasColumnName("SRC_FREEZE");
            builder.Property(e => e.SrcMiddle)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SRC_MIDDLE");
            builder.Property(e => e.SrcNchars)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("SRC_NCHARS");
            builder.Property(e => e.SrcNmatch)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SRC_NMATCH");
            builder.Property(e => e.SrcWkend).HasColumnName("SRC_WKEND");
            builder.Property(e => e.SrcYrsret)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SRC_YRSRET");
            builder.Property(e => e.Srequest)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SREQUEST");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
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
            builder.Property(e => e.SubjName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Transid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRANSID");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
            builder.Property(e => e.WsAcct)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WS_ACCT");
            builder.Property(e => e.WsPass)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WS_PASS");
            builder.Property(e => e.WsUserid)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WS_USERID");
        }
    }
}