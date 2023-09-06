using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebadminConfiguration : IEntityTypeConfiguration<Webadmin>
    {
        public void Configure(EntityTypeBuilder<Webadmin> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBADMIN");

            builder.Property(e => e.Addrslteml)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRSLTEML");
            builder.Property(e => e.AdmAcct).HasColumnName("ADM_ACCT");
            builder.Property(e => e.AdmBill).HasColumnName("ADM_BILL");
            builder.Property(e => e.AdmOl2bg).HasColumnName("ADM_OL_2BG");
            builder.Property(e => e.AdmOlCfg).HasColumnName("ADM_OL_CFG");
            builder.Property(e => e.AdmOlFlg).HasColumnName("ADM_OL_FLG");
            builder.Property(e => e.AdmOlMe).HasColumnName("ADM_OL_ME");
            builder.Property(e => e.AdmOlPkg).HasColumnName("ADM_OL_PKG");
            builder.Property(e => e.AdmOlapps).HasColumnName("ADM_OLAPPS");
            builder.Property(e => e.AdmOlques).HasColumnName("ADM_OLQUES");
            builder.Property(e => e.AdmRpts).HasColumnName("ADM_RPTS");
            builder.Property(e => e.ApGrading).HasColumnName("AP_GRADING");
            builder.Property(e => e.CcAccess).HasColumnName("CC_ACCESS");
            builder.Property(e => e.CcUse).HasColumnName("CC_USE");
            builder.Property(e => e.ChangePf).HasColumnName("CHANGE_PF");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.ConthrTxt)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONTHR_TXT");
            builder.Property(e => e.EmailAdj).HasColumnName("EMAIL_ADJ");
            builder.Property(e => e.Emlrsltype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EMLRSLTYPE");
            builder.Property(e => e.Expand1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXPAND1");
            builder.Property(e => e.Fi9Approv).HasColumnName("FI9_APPROV");
            builder.Property(e => e.FpAnsCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FP_ANS_CNT");
            builder.Property(e => e.FpAnsSt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FP_ANS_ST");
            builder.Property(e => e.FpLogcnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FP_LOGCNT");
            builder.Property(e => e.FpStartD)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FP_START_D");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");
            builder.Property(e => e.Islocked).HasColumnName("ISLOCKED");
            builder.Property(e => e.Isonline).HasColumnName("ISONLINE");
            builder.Property(e => e.LActivity)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("L_ACTIVITY");
            builder.Property(e => e.Lastlockdt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTLOCKDT");
            builder.Property(e => e.Panswer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PANSWER");
            builder.Property(e => e.PchangeDt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PCHANGE_DT");
            builder.Property(e => e.Pquestion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PQUESTION");
            builder.Property(e => e.ReqEmail)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_EMAIL");
            builder.Property(e => e.ReqOnly).HasColumnName("REQ_ONLY");
            builder.Property(e => e.ReqPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_PHONE");
            builder.Property(e => e.Restrictp1).HasColumnName("RESTRICTP1");
            builder.Property(e => e.Restrictp2).HasColumnName("RESTRICTP2");
            builder.Property(e => e.Restrictp3).HasColumnName("RESTRICTP3");
            builder.Property(e => e.Restrictp4).HasColumnName("RESTRICTP4");
            builder.Property(e => e.Restrictp5).HasColumnName("RESTRICTP5");
            builder.Property(e => e.Restrictp6).HasColumnName("RESTRICTP6");
            builder.Property(e => e.Restrictp7).HasColumnName("RESTRICTP7");
            builder.Property(e => e.Restrictp8).HasColumnName("RESTRICTP8");
            builder.Property(e => e.Restrictp9).HasColumnName("RESTRICTP9");
            builder.Property(e => e.SecBill)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEC_BILL");
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
            builder.Property(e => e.SuprView).HasColumnName("SUPR_VIEW");
            builder.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Userinfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERINFO");
            builder.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");
            builder.Property(e => e.ViewAdjud).HasColumnName("VIEW_ADJUD");
            builder.Property(e => e.ViewPf).HasColumnName("VIEW_PF");
            builder.Property(e => e.VuAlSupr).HasColumnName("VU_AL_SUPR");
            builder.Property(e => e.VuAlerts).HasColumnName("VU_ALERTS");
            builder.Property(e => e.WebPw)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_PW");
            builder.Property(e => e.Wemail)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEMAIL");
        }
    }
}