//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class DupclntConfiguration : IEntityTypeConfiguration<Dupclnt>
//    {
//        public void Configure(EntityTypeBuilder<Dupclnt> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("DUPCLNT");

//            builder.Property(e => e.AcctMgr)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ACCT_MGR");
//            builder.Property(e => e.AcctNbr)
//                .HasMaxLength(12)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ACCT_NBR");
//            builder.Property(e => e.Address1)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADDRESS1");
//            builder.Property(e => e.Address2)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADDRESS2");
//            builder.Property(e => e.Address3)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADDRESS3");
//            builder.Property(e => e.AdmAcct)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADM_ACCT");
//            builder.Property(e => e.AdmBill)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADM_BILL");
//            builder.Property(e => e.AdmRpts)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ADM_RPTS");
//            builder.Property(e => e.Attention)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ATTENTION");
//            builder.Property(e => e.AttnBill)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ATTN_BILL");
//            builder.Property(e => e.Baddr1)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("BADDR1");
//            builder.Property(e => e.Baddr2)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("BADDR2");
//            builder.Property(e => e.Baddr3)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("BADDR3");
//            builder.Property(e => e.Biemail)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("BIEMAIL");
//            builder.Property(e => e.CliState)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CLI_STATE");
//            builder.Property(e => e.CompCode)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMP_CODE");
//            builder.Property(e => e.CompName)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMP_NAME");
//            builder.Property(e => e.ConthrTxt)
//                .HasMaxLength(254)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CONTHR_TXT");
//            builder.Property(e => e.Emailzippw)
//                .HasMaxLength(65)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMAILZIPPW");
//            builder.Property(e => e.FaxNumber)
//                .HasMaxLength(17)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FAX_NUMBER");
//            builder.Property(e => e.Faxcall1st).HasColumnName("FAXCALL1ST");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Iemail)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("IEMAIL");
//            builder.Property(e => e.Post2Req).HasColumnName("POST_2_REQ");
//            builder.Property(e => e.Priority)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("PRIORITY");
//            builder.Property(e => e.ReqEmail)
//                .HasMaxLength(45)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REQ_EMAIL");
//            builder.Property(e => e.ReqOnly)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REQ_ONLY");
//            builder.Property(e => e.SecBill)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SEC_BILL");
//            builder.Property(e => e.SecReq)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SEC_REQ");
//            builder.Property(e => e.SecRes)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SEC_RES");
//            builder.Property(e => e.SecStat)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SEC_STAT");
//            builder.Property(e => e.SepBaddr).HasColumnName("SEP_BADDR");
//            builder.Property(e => e.Userid)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("USERID");
//            builder.Property(e => e.Username)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("USERNAME");
//            builder.Property(e => e.ViewAdjud)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("VIEW_ADJUD");
//            builder.Property(e => e.VoicePhon)
//                .HasMaxLength(17)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("VOICE_PHON");
//            builder.Property(e => e.VuAlerts)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("VU_ALERTS");
//            builder.Property(e => e.WebPw)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WEB_PW");
//            builder.Property(e => e.Wemail)
//                .HasMaxLength(45)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WEMAIL");

//        }
//    }
//}