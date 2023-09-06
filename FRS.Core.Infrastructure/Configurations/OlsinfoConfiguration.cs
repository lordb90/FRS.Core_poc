//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class OlsinfoConfiguration : IEntityTypeConfiguration<Olsinfo>
//    {
//        public void Configure(EntityTypeBuilder<Olsinfo> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("OLSINFO");

//            builder.Property(e => e.Coexpdir)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COEXPDIR");
//            builder.Property(e => e.DacAcode)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DAC_ACODE");
//            builder.Property(e => e.DacCsNbr)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DAC_CS_NBR");
//            builder.Property(e => e.DacCustN)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DAC_CUST_N");
//            builder.Property(e => e.DacFbaud)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("DAC_FBAUD");
//            builder.Property(e => e.DacFcalls)
//                .HasColumnType("numeric(5, 0)")
//                .HasColumnName("DAC_FCALLS");
//            builder.Property(e => e.DacFport)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("DAC_FPORT");
//            builder.Property(e => e.EqAcctc)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_ACCTC");
//            builder.Property(e => e.EqAcctdt)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_ACCTDT");
//            builder.Property(e => e.EqAcctid)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_ACCTID");
//            builder.Property(e => e.EqAcctp)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_ACCTP");
//            builder.Property(e => e.EqDialnbr)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_DIALNBR");
//            builder.Property(e => e.EqFbaud)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("EQ_FBAUD");
//            builder.Property(e => e.EqFcalls)
//                .HasColumnType("numeric(5, 0)")
//                .HasColumnName("EQ_FCALLS");
//            builder.Property(e => e.EqFcrasup).HasColumnName("EQ_FCRASUP");
//            builder.Property(e => e.EqFport)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("EQ_FPORT");
//            builder.Property(e => e.EqPpurC)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_PPUR_C");
//            builder.Property(e => e.EqPpurDt)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_PPUR_DT");
//            builder.Property(e => e.EqPpurId)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_PPUR_ID");
//            builder.Property(e => e.EqPpurP)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQ_PPUR_P");
//            builder.Property(e => e.EquMethod)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EQU_METHOD");
//            builder.Property(e => e.FlBtchDt)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("FL_BTCH_DT");
//            builder.Property(e => e.FlBtchnbr)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("FL_BTCHNBR");
//            builder.Property(e => e.FlOri)
//                .HasMaxLength(9)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FL_ORI");
//            builder.Property(e => e.Flexpdir)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FLEXPDIR");
//            builder.Property(e => e.IcHtml).HasColumnName("IC_HTML");
//            builder.Property(e => e.IcequCred)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICEQU_CRED");
//            builder.Property(e => e.IcequDtec)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICEQU_DTEC");
//            builder.Property(e => e.IcequId)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICEQU_ID");
//            builder.Property(e => e.IcequPers)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICEQU_PERS");
//            builder.Property(e => e.IctrwCred)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTRW_CRED");
//            builder.Property(e => e.IctrwEmpi)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTRW_EMPI");
//            builder.Property(e => e.IctrwSoc)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTRW_SOC");
//            builder.Property(e => e.IctuCred)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTU_CRED");
//            builder.Property(e => e.IctuPeer)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTU_PEER");
//            builder.Property(e => e.IctuRet)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTU_RET");
//            builder.Property(e => e.IctuTrace)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ICTU_TRACE");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.TrwCopykw)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("TRW_COPYKW");
//            builder.Property(e => e.TrwCpream)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_CPREAM");
//            builder.Property(e => e.TrwCredkw)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_CREDKW");
//            builder.Property(e => e.TrwCsNbr)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_CS_NBR");
//            builder.Property(e => e.TrwCsubpw)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_CSUBPW");
//            builder.Property(e => e.TrwCsubs)
//                .HasMaxLength(7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_CSUBS");
//            builder.Property(e => e.TrwEpream)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_EPREAM");
//            builder.Property(e => e.TrwEsubpw)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_ESUBPW");
//            builder.Property(e => e.TrwEsubs)
//                .HasMaxLength(7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_ESUBS");
//            builder.Property(e => e.TrwFbaud)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("TRW_FBAUD");
//            builder.Property(e => e.TrwFcalls)
//                .HasColumnType("numeric(5, 0)")
//                .HasColumnName("TRW_FCALLS");
//            builder.Property(e => e.TrwFport)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("TRW_FPORT");
//            builder.Property(e => e.TrwHost)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_HOST");
//            builder.Property(e => e.TrwMethod)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_METHOD");
//            builder.Property(e => e.TrwSpream)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_SPREAM");
//            builder.Property(e => e.TrwSspp)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_SSPP");
//            builder.Property(e => e.TrwSsubpw)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_SSUBPW");
//            builder.Property(e => e.TrwSsubs)
//                .HasMaxLength(7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_SSUBS");
//            builder.Property(e => e.TrwUic)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TRW_UIC");
//            builder.Property(e => e.TuCPw)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_C_PW");
//            builder.Property(e => e.TuCSubs)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_C_SUBS");
//            builder.Property(e => e.TuCicode)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_CICODE");
//            builder.Property(e => e.TuDialnbr)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_DIALNBR");
//            builder.Property(e => e.TuFbaud)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("TU_FBAUD");
//            builder.Property(e => e.TuFcalls)
//                .HasColumnType("numeric(5, 0)")
//                .HasColumnName("TU_FCALLS");
//            builder.Property(e => e.TuFcrasup).HasColumnName("TU_FCRASUP");
//            builder.Property(e => e.TuFport)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("TU_FPORT");
//            builder.Property(e => e.TuMarket)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_MARKET");
//            builder.Property(e => e.TuMethod)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_METHOD");
//            builder.Property(e => e.TuPPw)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_P_PW");
//            builder.Property(e => e.TuPSubs)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_P_SUBS");
//            builder.Property(e => e.TuPicode)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_PICODE");
//            builder.Property(e => e.TuRPw)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_R_PW");
//            builder.Property(e => e.TuRSubs)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_R_SUBS");
//            builder.Property(e => e.TuRicode)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_RICODE");
//            builder.Property(e => e.TuSubmark)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_SUBMARK");
//            builder.Property(e => e.TuTPw)
//                .HasMaxLength(4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_T_PW");
//            builder.Property(e => e.TuTSubs)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_T_SUBS");
//            builder.Property(e => e.TuTicode)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TU_TICODE");

//        }
//    }
//}