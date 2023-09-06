using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CinstConfiguration : IEntityTypeConfiguration<Cinst>
{
    public void Configure(EntityTypeBuilder<Cinst> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CINST");

        builder.Property(e => e.AcctNbr)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ACCT_NBR");
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
        builder.Property(e => e.Afflbltype)
            .HasMaxLength(14)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AFFLBLTYPE");
        builder.Property(e => e.AkasOfees)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("AKAS_OFEES");
        builder.Property(e => e.AltLetter).HasColumnName("ALT_LETTER");
        builder.Property(e => e.AltLtrhd)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("ALT_LTRHD");
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
        builder.Property(e => e.BillType)
            .HasMaxLength(7)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILL_TYPE");
        builder.Property(e => e.Billcode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILLCODE");
        builder.Property(e => e.BurCred)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BUR_CRED");
        builder.Property(e => e.BurSsn)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BUR_SSN");
        builder.Property(e => e.ChrgAfees)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("CHRG_AFEES");
        builder.Property(e => e.ChrgCfees)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("CHRG_CFEES");
        builder.Property(e => e.ChrgMvrfe)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("CHRG_MVRFE");
        builder.Property(e => e.ChrgOfees)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("CHRG_OFEES");
        builder.Property(e => e.CliState)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CLI_STATE");
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
        builder.Property(e => e.CompName)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_NAME");
        builder.Property(e => e.Coocaption)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COOCAPTION");
        builder.Property(e => e.Cootext)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COOTEXT");
        builder.Property(e => e.Crmautoalr).HasColumnName("CRMAUTOALR");
        builder.Property(e => e.CrtfeeExc).HasColumnName("CRTFEE_EXC");
        builder.Property(e => e.CrtfeeLst)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CRTFEE_LST");
        builder.Property(e => e.CrtfeeNot).HasColumnName("CRTFEE_NOT");
        builder.Property(e => e.Drugpkgs)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DRUGPKGS");
        builder.Property(e => e.FaxNumber)
            .HasMaxLength(17)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FAX_NUMBER");
        builder.Property(e => e.Gclogoname)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("GCLOGONAME");
        builder.Property(e => e.Hlsexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("HLSEXPRESS");
        builder.Property(e => e.Hsexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("HSEXPRESS");
        builder.Property(e => e.I3pkgs)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("I3PKGS");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Itembltype)
            .HasMaxLength(14)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ITEMBLTYPE");
        builder.Property(e => e.LicAffil).HasColumnName("LIC_AFFIL");
        builder.Property(e => e.LogoSet).HasColumnName("LOGO_SET");
        builder.Property(e => e.MvrCAcct)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MVR_C_ACCT");
        builder.Property(e => e.MvrCPass)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MVR_C_PASS");
        builder.Property(e => e.MvrCUser)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("MVR_C_USER");
        builder.Property(e => e.MvrFlUnl).HasColumnName("MVR_FL_UNL");
        builder.Property(e => e.Mvrautoalr).HasColumnName("MVRAUTOALR");
        builder.Property(e => e.Nwexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("NWEXPRESS");
        builder.Property(e => e.PatNoRec)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PAT_NO_REC");
        builder.Property(e => e.PatYesrec)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PAT_YESREC");
        builder.Property(e => e.Pospiklist)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("POSPIKLIST");
        builder.Property(e => e.PstAcAsn).HasColumnName("PST_AC_ASN");
        builder.Property(e => e.PstAlAka).HasColumnName("PST_AL_AKA");
        builder.Property(e => e.PstAlDob).HasColumnName("PST_AL_DOB");
        builder.Property(e => e.PstAlDod).HasColumnName("PST_AL_DOD");
        builder.Property(e => e.PstAlSsn).HasColumnName("PST_AL_SSN");
        builder.Property(e => e.PstCtyNa).HasColumnName("PST_CTY_NA");
        builder.Property(e => e.PstCtyasn)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_CTYASN");
        builder.Property(e => e.PstCtynbr)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_CTYNBR");
        builder.Property(e => e.PstCtysrc)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_CTYSRC");
        builder.Property(e => e.PstCtyyrs)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_CTYYRS");
        builder.Property(e => e.PstFedasn)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_FEDASN");
        builder.Property(e => e.PstFednbr)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_FEDNBR");
        builder.Property(e => e.PstFedyrs)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_FEDYRS");
        builder.Property(e => e.PstFooter)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PST_FOOTER");
        builder.Property(e => e.PstResfmt)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_RESFMT");
        builder.Property(e => e.PstResmsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PST_RESMSG");
        builder.Property(e => e.PstRfDob).HasColumnName("PST_RF_DOB");
        builder.Property(e => e.PstRfSsn).HasColumnName("PST_RF_SSN");
        builder.Property(e => e.PstRfddup).HasColumnName("PST_RFDDUP");
        builder.Property(e => e.PstRfmism).HasColumnName("PST_RFMISM");
        builder.Property(e => e.PstRfnas).HasColumnName("PST_RFNAS");
        builder.Property(e => e.PstRftfrm).HasColumnName("PST_RFTFRM");
        builder.Property(e => e.PstSwAsn).HasColumnName("PST_SW_ASN");
        builder.Property(e => e.Pstnotlst4).HasColumnName("PSTNOTLST4");
        builder.Property(e => e.RcCliId)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RC_CLI_ID");
        builder.Property(e => e.RcProfId)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RC_PROF_ID");
        builder.Property(e => e.RmaskDln).HasColumnName("RMASK_DLN");
        builder.Property(e => e.Rrpt1addr)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RRPT_1ADDR");
        builder.Property(e => e.Rrpt2addr)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RRPT_2ADDR");
        builder.Property(e => e.Rrpt3addr)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RRPT_3ADDR");
        builder.Property(e => e.Rrpt4addr)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RRPT_4ADDR");
        builder.Property(e => e.RrptComp)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RRPT_COMP");
        builder.Property(e => e.RsupprDob).HasColumnName("RSUPPR_DOB");
        builder.Property(e => e.RsupprSsn).HasColumnName("RSUPPR_SSN");
        builder.Property(e => e.Scorecard)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SCORECARD");
        builder.Property(e => e.Sorexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SOREXPRESS");
        builder.Property(e => e.SpecialC).HasColumnName("SPECIAL_C");
        builder.Property(e => e.StiPacode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STI_PACODE");
        builder.Property(e => e.StiPasswd)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("STI_PASSWD");
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
        builder.Property(e => e.StrNmM1).HasColumnName("STR_NM_M1");
        builder.Property(e => e.StrNmM2).HasColumnName("STR_NM_M2");
        builder.Property(e => e.StrNmM9).HasColumnName("STR_NM_M9");
        builder.Property(e => e.TrwCredkw)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TRW_CREDKW");
        builder.Property(e => e.TrwSsnkw)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TRW_SSNKW");
        builder.Property(e => e.TuCAddon)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_C_ADDON");
        builder.Property(e => e.TuCProd)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_C_PROD");
        builder.Property(e => e.TuIcode)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_ICODE");
        builder.Property(e => e.TuMarket)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_MARKET");
        builder.Property(e => e.TuPurp)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_PURP");
        builder.Property(e => e.TuPw)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_PW");
        builder.Property(e => e.TuSAddon)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_S_ADDON");
        builder.Property(e => e.TuSProd)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_S_PROD");
        builder.Property(e => e.TuSubmark)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_SUBMARK");
        builder.Property(e => e.TuSubs)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TU_SUBS");
        builder.Property(e => e.TusIcode)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TUS_ICODE");
        builder.Property(e => e.TusMarket)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TUS_MARKET");
        builder.Property(e => e.TusPw)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TUS_PW");
        builder.Property(e => e.TusSubmar)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TUS_SUBMAR");
        builder.Property(e => e.TusSubs)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TUS_SUBS");
        builder.Property(e => e.VoicePhon)
            .HasMaxLength(17)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("VOICE_PHON");
        builder.Property(e => e.Wbpurarcvw).HasColumnName("WBPURARCVW");
        builder.Property(e => e.Wbpurgarc)
            .HasColumnType("numeric(4, 0)")
            .HasColumnName("WBPURGARC");
        builder.Property(e => e.Wbpurgifvw).HasColumnName("WBPURGIFVW");
        builder.Property(e => e.WebPurge)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("WEB_PURGE");
        builder.Property(e => e.Webmov2arc)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("WEBMOV2ARC");
        builder.Property(e => e.Webmovifvw).HasColumnName("WEBMOVIFVW");
        builder.Property(e => e.Wknaddcost)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("WKNADDCOST");
        builder.Property(e => e.Wkncostcur)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("WKNCOSTCUR");
        builder.Property(e => e.Wkncostemp)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("WKNCOSTEMP");
        builder.Property(e => e.Wkncostpre)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("WKNCOSTPRE");
        builder.Property(e => e.Wkndeflmth)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("WKNDEFLMTH");
        builder.Property(e => e.Wknglobcli)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("WKNGLOBCLI");

    }
}