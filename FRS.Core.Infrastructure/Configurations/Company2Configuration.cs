using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class Company2Configuration : IEntityTypeConfiguration<Company2>
    {
        public void Configure(EntityTypeBuilder<Company2> builder)
        {
            builder
                .HasNoKey()
                .ToTable("COMPANY2");

            builder.Property(e => e.AcctEml)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCT_EML");
            builder.Property(e => e.AdjuFcomp).HasColumnName("ADJU_FCOMP");
            builder.Property(e => e.AdjuNofrz).HasColumnName("ADJU_NOFRZ");
            builder.Property(e => e.Adjwksheet)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADJWKSHEET");
            builder.Property(e => e.Advactadr1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTADR1");
            builder.Property(e => e.Advactadr2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTADR2");
            builder.Property(e => e.Advactadr3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTADR3");
            builder.Property(e => e.Advactadr4)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTADR4");
            builder.Property(e => e.Advactdelm)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTDELM");
            builder.Property(e => e.Advactfeml)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTFEML");
            builder.Property(e => e.Advactlogo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTLOGO");
            builder.Property(e => e.Advactnme)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVACTNME");
            builder.Property(e => e.Adverrange)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ADVERRANGE");
            builder.Property(e => e.Advtextpre)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVTEXTPRE");
            builder.Property(e => e.Advtextpst)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVTEXTPST");
            builder.Property(e => e.Advusepre).HasColumnName("ADVUSEPRE");
            builder.Property(e => e.Advusepst).HasColumnName("ADVUSEPST");
            builder.Property(e => e.Agenexcel).HasColumnName("AGENEXCEL");
            builder.Property(e => e.Altfromeml)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTFROMEML");
            builder.Property(e => e.Altverbgrn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTVERBGRN");
            builder.Property(e => e.Altverbgry)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTVERBGRY");
            builder.Property(e => e.Altverbred)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTVERBRED");
            builder.Property(e => e.Altverbwht)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTVERBWHT");
            builder.Property(e => e.Altverbylw)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTVERBYLW");
            builder.Property(e => e.Amcfeeadd).HasColumnName("AMCFEEADD");
            builder.Property(e => e.Amcfeeamt)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("AMCFEEAMT");
            builder.Property(e => e.Amcpurge)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("AMCPURGE");
            builder.Property(e => e.ApAltemlr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AP_ALTEMLR");
            builder.Property(e => e.ApEmredgr).HasColumnName("AP_EMREDGR");
            builder.Property(e => e.ApErgygw1).HasColumnName("AP_ERGYGW1");
            builder.Property(e => e.ApErgygw2).HasColumnName("AP_ERGYGW2");
            builder.Property(e => e.ApFeeamt)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("AP_FEEAMT");
            builder.Property(e => e.ApFeedesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AP_FEEDESC");
            builder.Property(e => e.ApIncpend).HasColumnName("AP_INCPEND");
            builder.Property(e => e.ApNeedsri).HasColumnName("AP_NEEDSRI");
            builder.Property(e => e.ApNopend).HasColumnName("AP_NOPEND");
            builder.Property(e => e.ApStndmsg).HasColumnName("AP_STNDMSG");
            builder.Property(e => e.ApUseaeml).HasColumnName("AP_USEAEML");
            builder.Property(e => e.Cltrxchrg).HasColumnName("CLTRXCHRG");
            builder.Property(e => e.Co2caption)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO2CAPTION");
            builder.Property(e => e.Co2text)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO2TEXT");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Coocaption)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COOCAPTION");
            builder.Property(e => e.Cootext)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COOTEXT");
            builder.Property(e => e.Covshtres).HasColumnName("COVSHTRES");
            builder.Property(e => e.Current)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CURRENT");
            builder.Property(e => e.Dontdelay).HasColumnName("DONTDELAY");
            builder.Property(e => e.DotRegula).HasColumnName("DOT_REGULA");
            builder.Property(e => e.Drugpkgs)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DRUGPKGS");
            builder.Property(e => e.Emailexcel).HasColumnName("EMAILEXCEL");
            builder.Property(e => e.Emailpass).HasColumnName("EMAILPASS");
            builder.Property(e => e.EmlMulti).HasColumnName("EML_MULTI");
            builder.Property(e => e.Emladdref).HasColumnName("EMLADDREF");
            builder.Property(e => e.Emlapplcnt).HasColumnName("EMLAPPLCNT");
            builder.Property(e => e.Emlfrmamgr).HasColumnName("EMLFRMAMGR");
            builder.Property(e => e.Enotifcltr).HasColumnName("ENOTIFCLTR");
            builder.Property(e => e.Enotifemls)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ENOTIFEMLS");
            builder.Property(e => e.FaxNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_NUMBER");
            builder.Property(e => e.Faxcovres)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAXCOVRES");
            builder.Property(e => e.Frreqnotor).HasColumnName("FRREQNOTOR");
            builder.Property(e => e.Frz18cstm).HasColumnName("FRZ18CSTM");
            builder.Property(e => e.Frz18lxml).HasColumnName("FRZ18LXML");
            builder.Property(e => e.Frz18manl).HasColumnName("FRZ18MANL");
            builder.Property(e => e.Frz18web).HasColumnName("FRZ18WEB");
            builder.Property(e => e.Frzakaweb).HasColumnName("FRZAKAWEB");
            builder.Property(e => e.Frzmultjur).HasColumnName("FRZMULTJUR");
            builder.Property(e => e.Frzrstrct).HasColumnName("FRZRSTRCT");
            builder.Property(e => e.Frzusers)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRZUSERS");
            builder.Property(e => e.Genrandpwd).HasColumnName("GENRANDPWD");
            builder.Property(e => e.Hits2send)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("HITS2SEND");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Inreqnotor).HasColumnName("INREQNOTOR");
            builder.Property(e => e.IntTrk1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_1");
            builder.Property(e => e.IntTrk2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_2");
            builder.Property(e => e.IntTrk3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_3");
            builder.Property(e => e.IntTrk4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_4");
            builder.Property(e => e.IntTrk5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_5");
            builder.Property(e => e.Lockbyuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCKBYUSER");
            builder.Property(e => e.Lockdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOCKDATE");
            builder.Property(e => e.LogoSet).HasColumnName("LOGO_SET");
            builder.Property(e => e.LxAdjudD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_ADJUD_D");
            builder.Property(e => e.LxAdjudS)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LX_ADJUD_S");
            builder.Property(e => e.LxFrzdups).HasColumnName("LX_FRZDUPS");
            builder.Property(e => e.LxPkgAdd).HasColumnName("LX_PKG_ADD");
            builder.Property(e => e.LxPkgRem).HasColumnName("LX_PKG_REM");
            builder.Property(e => e.Lxreqnotor).HasColumnName("LXREQNOTOR");
            builder.Property(e => e.Nobillist).HasColumnName("NOBILLIST");
            builder.Property(e => e.Noctygroup).HasColumnName("NOCTYGROUP");
            builder.Property(e => e.Nofrzinst).HasColumnName("NOFRZINST");
            builder.Property(e => e.OdNoblank).HasColumnName("OD_NOBLANK");
            builder.Property(e => e.PdfPswd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PDF_PSWD");
            builder.Property(e => e.Pmtprocfee)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("PMTPROCFEE");
            builder.Property(e => e.ProofOver)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PROOF_OVER");
            builder.Property(e => e.PstCivlow).HasColumnName("PST_CIVLOW");
            builder.Property(e => e.PstCivupp).HasColumnName("PST_CIVUPP");
            builder.Property(e => e.PstCtytoo).HasColumnName("PST_CTYTOO");
            builder.Property(e => e.PstFulsta).HasColumnName("PST_FULSTA");
            builder.Property(e => e.Pstnotlst4).HasColumnName("PSTNOTLST4");
            builder.Property(e => e.Remindcand).HasColumnName("REMINDCAND");
            builder.Property(e => e.Rmdbdytxt)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RMDBDYTXT");
            builder.Property(e => e.Rmdhdrtxt)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RMDHDRTXT");
            builder.Property(e => e.SalesTax)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("SALES_TAX");
            builder.Property(e => e.Scorecard)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCORECARD");
            builder.Property(e => e.Setoverall).HasColumnName("SETOVERALL");
            builder.Property(e => e.Settings)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTINGS");
            builder.Property(e => e.Showcrdrep).HasColumnName("SHOWCRDREP");
            builder.Property(e => e.Sortbycnty).HasColumnName("SORTBYCNTY");
            builder.Property(e => e.StiPacode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI_PACODE");
            builder.Property(e => e.Taxsupchrg).HasColumnName("TAXSUPCHRG");
            builder.Property(e => e.Tenantscrn).HasColumnName("TENANTSCRN");
            builder.Property(e => e.Trnsfeeadd).HasColumnName("TRNSFEEADD");
            builder.Property(e => e.Trnsfeeamt)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("TRNSFEEAMT");
            builder.Property(e => e.Wbdsusehst).HasColumnName("WBDSUSEHST");
            builder.Property(e => e.Wbpurarcvw).HasColumnName("WBPURARCVW");
            builder.Property(e => e.Wbpurgarc)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("WBPURGARC");
            builder.Property(e => e.Wbpurgifvw).HasColumnName("WBPURGIFVW");
            builder.Property(e => e.Wbreqnotor).HasColumnName("WBREQNOTOR");
            builder.Property(e => e.WdsBegday)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("WDS_BEGDAY");
            builder.Property(e => e.WdsBegdte)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WDS_BEGDTE");
            builder.Property(e => e.WdsBegmth)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("WDS_BEGMTH");
            builder.Property(e => e.WdsEndday)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("WDS_ENDDAY");
            builder.Property(e => e.WdsEnddte)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WDS_ENDDTE");
            builder.Property(e => e.WdsEndmth)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("WDS_ENDMTH");
            builder.Property(e => e.WdsUserng).HasColumnName("WDS_USERNG");
            builder.Property(e => e.Webmov2arc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("WEBMOV2ARC");
            builder.Property(e => e.Webmovifvw).HasColumnName("WEBMOVIFVW");
            builder.Property(e => e.Wknglobcli)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WKNGLOBCLI");
            builder.Property(e => e.Wknsetup)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WKNSETUP");
            builder.Property(e => e.Yesreceml)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YESRECEML");
        }
    }
}