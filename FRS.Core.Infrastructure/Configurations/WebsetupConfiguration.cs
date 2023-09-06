using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebsetupConfiguration : IEntityTypeConfiguration<Websetup>
    {
        public void Configure(EntityTypeBuilder<Websetup> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBSETUP");

            builder.Property(e => e.AddExsum).HasColumnName("ADD_EXSUM");
            builder.Property(e => e.Al1Perpg).HasColumnName("AL_1_PERPG");
            builder.Property(e => e.AlCounty).HasColumnName("AL_COUNTY");
            builder.Property(e => e.AlDrivers).HasColumnName("AL_DRIVERS");
            builder.Property(e => e.AlDups).HasColumnName("AL_DUPS");
            builder.Property(e => e.AlSubject).HasColumnName("AL_SUBJECT");
            builder.Property(e => e.AlertDesc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALERT_DESC");
            builder.Property(e => e.CourtDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COURT_DESC");
            builder.Property(e => e.CrimMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIM_MSG");
            builder.Property(e => e.DispAlert)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DISP_ALERT");
            builder.Property(e => e.DlxhitMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLXHIT_MSG");
            builder.Property(e => e.Escrnid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ESCRNID");
            builder.Property(e => e.Escrnlogin)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ESCRNLOGIN");
            builder.Property(e => e.Escrnpswd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ESCRNPSWD");
            builder.Property(e => e.Exactkeywd).HasColumnName("EXACTKEYWD");
            builder.Property(e => e.ExpAlign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_ALIGN");
            builder.Property(e => e.ExpHcs)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_HCS");
            builder.Property(e => e.ExpHls)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_HLS");
            builder.Property(e => e.ExpMvr)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_MVR");
            builder.Property(e => e.ExpNation)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_NATION");
            builder.Property(e => e.ExpSor)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_SOR");
            builder.Property(e => e.ExpSsn)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXP_SSN");
            builder.Property(e => e.Formslink)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORMSLINK");
            builder.Property(e => e.FrzIadd).HasColumnName("FRZ_IADD");
            builder.Property(e => e.Frzvnetsri).HasColumnName("FRZVNETSRI");
            builder.Property(e => e.HomePage)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HOME_PAGE");
            builder.Property(e => e.I3pwd)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("I3PWD");
            builder.Property(e => e.I3userid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("I3USERID");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InfoEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INFO_EMAIL");
            builder.Property(e => e.InfoMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INFO_MSG");
            builder.Property(e => e.Instntcomp).HasColumnName("INSTNTCOMP");
            builder.Property(e => e.Loginwelcm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOGINWELCM");
            builder.Property(e => e.MaintTime)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("MAINT_TIME");
            builder.Property(e => e.MvrexprCa).HasColumnName("MVREXPR_CA");
            builder.Property(e => e.MvrexprNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVREXPR_NO");
            builder.Property(e => e.MvrhitMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVRHIT_MSG");
            builder.Property(e => e.Mvrhitfltr).HasColumnName("MVRHITFLTR");
            builder.Property(e => e.MyctyList).HasColumnName("MYCTY_LIST");
            builder.Property(e => e.Nofrzkeywd)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOFRZKEYWD");
            builder.Property(e => e.OsMain)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_MAIN");
            builder.Property(e => e.OscFed).HasColumnName("OSC_FED");
            builder.Property(e => e.OscFel).HasColumnName("OSC_FEL");
            builder.Property(e => e.OscFm).HasColumnName("OSC_FM");
            builder.Property(e => e.OscLc).HasColumnName("OSC_LC");
            builder.Property(e => e.OscMisd).HasColumnName("OSC_MISD");
            builder.Property(e => e.OscUc).HasColumnName("OSC_UC");
            builder.Property(e => e.OscUlc).HasColumnName("OSC_ULC");
            builder.Property(e => e.Ph5Afthrs).HasColumnName("PH5_AFTHRS");
            builder.Property(e => e.PostCred)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("POST_CRED");
            builder.Property(e => e.PostMvr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("POST_MVR");
            builder.Property(e => e.PostSsn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("POST_SSN");
            builder.Property(e => e.ReqAuto)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("REQ_AUTO");
            builder.Property(e => e.ReqCount)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("REQ_COUNT");
            builder.Property(e => e.SignupSet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SIGNUP_SET");
            builder.Property(e => e.Signupdisc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SIGNUPDISC");
            builder.Property(e => e.Signupintr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SIGNUPINTR");
            builder.Property(e => e.Signupterm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SIGNUPTERM");
            builder.Property(e => e.Smtpserver)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SMTPSERVER");
            builder.Property(e => e.SuformMsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUFORM_MSG");
            builder.Property(e => e.SuformTit)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUFORM_TIT");
            builder.Property(e => e.Suformadob).HasColumnName("SUFORMADOB");
            builder.Property(e => e.Suformfoot)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUFORMFOOT");
            builder.Property(e => e.Suformpage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUFORMPAGE");
            builder.Property(e => e.SuppresCf).HasColumnName("SUPPRES_CF");
            builder.Property(e => e.SuppresSu).HasColumnName("SUPPRES_SU");
            builder.Property(e => e.VcloseOut)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VCLOSE_OUT");
            builder.Property(e => e.VnCrtcnt)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("VN_CRTCNT");
            builder.Property(e => e.VnTotcnt)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("VN_TOTCNT");
            builder.Property(e => e.VnVercnt)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("VN_VERCNT");
            builder.Property(e => e.VndataSiz)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("VNDATA_SIZ");
            builder.Property(e => e.Vnemailcrt)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VNEMAILCRT");
            builder.Property(e => e.Vnemailver)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VNEMAILVER");
            builder.Property(e => e.VnhumCrt).HasColumnName("VNHUM_CRT");
            builder.Property(e => e.VnhumVer).HasColumnName("VNHUM_VER");
            builder.Property(e => e.VnpdfCnt)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("VNPDF_CNT");
            builder.Property(e => e.VnpdfSize)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("VNPDF_SIZE");
            builder.Property(e => e.VnrgenBpa)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNRGEN_BPA");
            builder.Property(e => e.Vnrgenassn)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNRGENASSN");
            builder.Property(e => e.Vnrgenover)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNRGENOVER");
            builder.Property(e => e.VnrptAssn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VNRPT_ASSN");
            builder.Property(e => e.VnrptBpa)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VNRPT_BPA");
            builder.Property(e => e.VnrptOver)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VNRPT_OVER");
            builder.Property(e => e.VntCrtlat)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("VNT_CRTLAT");
            builder.Property(e => e.VntProof)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VNT_PROOF");
            builder.Property(e => e.VntUcase).HasColumnName("VNT_UCASE");
            builder.Property(e => e.VntVerlat)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("VNT_VERLAT");
            builder.Property(e => e.VsendAddr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VSEND_ADDR");
            builder.Property(e => e.VsendSsn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VSEND_SSN");
            builder.Property(e => e.WdataCnt)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("WDATA_CNT");
            builder.Property(e => e.WdataSize)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("WDATA_SIZE");
            builder.Property(e => e.WpdfCnt)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("WPDF_CNT");
            builder.Property(e => e.WpdfSize)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("WPDF_SIZE");
            builder.Property(e => e.WrgOrMan)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WRG_OR_MAN");
        }
    }
}