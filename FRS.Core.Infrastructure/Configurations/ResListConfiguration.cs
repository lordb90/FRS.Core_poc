using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ResListConfiguration : IEntityTypeConfiguration<ResList>
    {
        public void Configure(EntityTypeBuilder<ResList> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RES_LIST");

            builder.Property(e => e.AddFromC).HasColumnName("ADD_FROM_C");
            builder.Property(e => e.AddOls).HasColumnName("ADD_OLS");
            builder.Property(e => e.Address1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS1");
            builder.Property(e => e.Address2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS2");
            builder.Property(e => e.Address3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS3");
            builder.Property(e => e.Attention)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTENTION");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Covshtsrch).HasColumnName("COVSHTSRCH");
            builder.Property(e => e.Current)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CURRENT");
            builder.Property(e => e.Emailzippw)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMAILZIPPW");
            builder.Property(e => e.EmlComprs).HasColumnName("EML_COMPRS");
            builder.Property(e => e.FaxNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_NUMBER");
            builder.Property(e => e.Faxcovsrch)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAXCOVSRCH");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Iemail)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IEMAIL");
            builder.Property(e => e.Lasttracer)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTTRACER");
            builder.Property(e => e.LxAddNew).HasColumnName("LX_ADD_NEW");
            builder.Property(e => e.LxEmRmsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_EM_RMSG");
            builder.Property(e => e.LxEmSmsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_EM_SMSG");
            builder.Property(e => e.LxEmladdr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_EMLADDR");
            builder.Property(e => e.LxEmnorec).HasColumnName("LX_EMNOREC");
            builder.Property(e => e.LxEmnosnt).HasColumnName("LX_EMNOSNT");
            builder.Property(e => e.LxKwFrz)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_KW_FRZ");
            builder.Property(e => e.LxLpath)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_LPATH");
            builder.Property(e => e.LxRrfmt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("LX_RRFMT");
            builder.Property(e => e.LxSiteid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_SITEID");
            builder.Property(e => e.LxWebsv).HasColumnName("LX_WEBSV");
            builder.Property(e => e.LxWsTodo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_WS_TODO");
            builder.Property(e => e.Notes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOTES");
            builder.Property(e => e.OdtNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ODT_NOTES");
            builder.Property(e => e.OlsCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OLS_CODE");
            builder.Property(e => e.OnetNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ONET_NOTES");
            builder.Property(e => e.PdfOrTxt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PDF_OR_TXT");
            builder.Property(e => e.Priority)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("PRIORITY");
            builder.Property(e => e.ResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_CODE");
            builder.Property(e => e.ResName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_NAME");
            builder.Property(e => e.Slstyle)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SLSTYLE");
            builder.Property(e => e.Slsupprssn).HasColumnName("SLSUPPRSSN");
            builder.Property(e => e.VnetCtcur)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("VNET_CTCUR");
            builder.Property(e => e.VnetCttot)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("VNET_CTTOT");
            builder.Property(e => e.VnetLasta)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNET_LASTA");
            builder.Property(e => e.VnetLastu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VNET_LASTU");
            builder.Property(e => e.VnetLogin)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("VNET_LOGIN");
            builder.Property(e => e.VnetNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VNET_NOTES");
            builder.Property(e => e.VnetNtclr)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNET_NTCLR");
            builder.Property(e => e.VnetNtpst)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VNET_NTPST");
            builder.Property(e => e.VnetRes).HasColumnName("VNET_RES");
            builder.Property(e => e.VnetVrcur)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("VNET_VRCUR");
            builder.Property(e => e.VnetVrtot)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("VNET_VRTOT");
            builder.Property(e => e.VoicePhon)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VOICE_PHON");
            builder.Property(e => e.WebEnotif).HasColumnName("WEB_ENOTIF");
            builder.Property(e => e.XmitMeth)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("XMIT_METH");
        }
    }
}