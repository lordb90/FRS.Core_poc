using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SinstConfiguration : IEntityTypeConfiguration<Sinst>
    {
        public void Configure(EntityTypeBuilder<Sinst> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SINST");

            builder.Property(e => e.Altunlname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTUNLNAME");
            builder.Property(e => e.ChnsExtra)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHNS_EXTRA");
            builder.Property(e => e.ChrgAkas).HasColumnName("CHRG_AKAS");
            builder.Property(e => e.ChwnExtr2)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTR2");
            builder.Property(e => e.ChwnExtr3)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTR3");
            builder.Property(e => e.ChwnExtra)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTRA");
            builder.Property(e => e.CrimRptit)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIM_RPTIT");
            builder.Property(e => e.DiscCb1).HasColumnName("DISC_CB_1");
            builder.Property(e => e.DiscFhead)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISC_FHEAD");
            builder.Property(e => e.DisclFull)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISCL_FULL");
            builder.Property(e => e.DlxhitMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLXHIT_MSG");
            builder.Property(e => e.EqAcctc)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_ACCTC");
            builder.Property(e => e.EqAcctdt)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_ACCTDT");
            builder.Property(e => e.EqAcctid)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_ACCTID");
            builder.Property(e => e.EqAcctp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_ACCTP");
            builder.Property(e => e.EqFcrasup).HasColumnName("EQ_FCRASUP");
            builder.Property(e => e.EqPpurC)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_PPUR_C");
            builder.Property(e => e.EqPpurDt)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_PPUR_DT");
            builder.Property(e => e.EqPpurId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_PPUR_ID");
            builder.Property(e => e.EqPpurP)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EQ_PPUR_P");
            builder.Property(e => e.FrsPw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRS_PW");
            builder.Property(e => e.FrsUserid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRS_USERID");
            builder.Property(e => e.IcHtml).HasColumnName("IC_HTML");
            builder.Property(e => e.IcequCred)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICEQU_CRED");
            builder.Property(e => e.IcequDtec)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICEQU_DTEC");
            builder.Property(e => e.IcequId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICEQU_ID");
            builder.Property(e => e.IcequPers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICEQU_PERS");
            builder.Property(e => e.IctrwCred)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTRW_CRED");
            builder.Property(e => e.IctrwEmpi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTRW_EMPI");
            builder.Property(e => e.IctrwSoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTRW_SOC");
            builder.Property(e => e.IctuCred)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTU_CRED");
            builder.Property(e => e.IctuPeer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTU_PEER");
            builder.Property(e => e.IctuRet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTU_RET");
            builder.Property(e => e.IctuTrace)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ICTU_TRACE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Instntcomp).HasColumnName("INSTNTCOMP");
            builder.Property(e => e.MvrCAcct)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_ACCT");
            builder.Property(e => e.MvrCPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_PASS");
            builder.Property(e => e.MvrCUrl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_URL");
            builder.Property(e => e.MvrCUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_USER");
            builder.Property(e => e.MvrhitMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVRHIT_MSG");
            builder.Property(e => e.Mvrhitfltr).HasColumnName("MVRHITFLTR");
            builder.Property(e => e.MyverChns).HasColumnName("MYVER_CHNS");
            builder.Property(e => e.MyverChwn).HasColumnName("MYVER_CHWN");
            builder.Property(e => e.NscRates)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("NSC_RATES");
            builder.Property(e => e.Nscaddrate).HasColumnName("NSCADDRATE");
            builder.Property(e => e.Premiumdlx).HasColumnName("PREMIUMDLX");
            builder.Property(e => e.Prntfrndly).HasColumnName("PRNTFRNDLY");
            builder.Property(e => e.Ssnsumonly).HasColumnName("SSNSUMONLY");
            builder.Property(e => e.Sti2016)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI2016");
            builder.Property(e => e.StiPw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_PW");
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
            builder.Property(e => e.Stica2ndpw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STICA2NDPW");
            builder.Property(e => e.Tenantost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TENANTOST");
            builder.Property(e => e.TrwCopykw)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("TRW_COPYKW");
            builder.Property(e => e.TrwCpream)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_CPREAM");
            builder.Property(e => e.TrwCredkw)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_CREDKW");
            builder.Property(e => e.TrwCsubpw)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_CSUBPW");
            builder.Property(e => e.TrwCsubs)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_CSUBS");
            builder.Property(e => e.TrwEpream)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_EPREAM");
            builder.Property(e => e.TrwEsubpw)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_ESUBPW");
            builder.Property(e => e.TrwEsubs)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_ESUBS");
            builder.Property(e => e.TrwSpream)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_SPREAM");
            builder.Property(e => e.TrwSspp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_SSPP");
            builder.Property(e => e.TrwSsubpw)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_SSUBPW");
            builder.Property(e => e.TrwSsubs)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TRW_SSUBS");
            builder.Property(e => e.TuCPw)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_C_PW");
            builder.Property(e => e.TuCSubs)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_C_SUBS");
            builder.Property(e => e.TuCicode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_CICODE");
            builder.Property(e => e.TuFcrasup).HasColumnName("TU_FCRASUP");
            builder.Property(e => e.TuMarket)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_MARKET");
            builder.Property(e => e.TuPPw)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_P_PW");
            builder.Property(e => e.TuPSubs)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_P_SUBS");
            builder.Property(e => e.TuPicode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_PICODE");
            builder.Property(e => e.TuRPw)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_R_PW");
            builder.Property(e => e.TuRSubs)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_R_SUBS");
            builder.Property(e => e.TuRicode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_RICODE");
            builder.Property(e => e.TuSubmark)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_SUBMARK");
            builder.Property(e => e.TuTPw)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_T_PW");
            builder.Property(e => e.TuTSubs)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_T_SUBS");
            builder.Property(e => e.TuTicode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TU_TICODE");
            builder.Property(e => e.Wkndeflglb)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WKNDEFLGLB");
        }
    }
}