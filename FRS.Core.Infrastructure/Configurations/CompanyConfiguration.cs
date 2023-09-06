using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder
            .HasNoKey()
            .ToTable("COMPANY");

        builder.Property(e => e.AcctMgr)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ACCT_MGR");
        builder.Property(e => e.AcctNbr)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ACCT_NBR");
        builder.Property(e => e.AddDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("ADD_DATE");
        builder.Property(e => e.Addendum)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ADDENDUM");
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
        builder.Property(e => e.Addverb).HasColumnName("ADDVERB");
        builder.Property(e => e.Addvrbfail)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ADDVRBFAIL");
        builder.Property(e => e.Addvrbpass)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ADDVRBPASS");
        builder.Property(e => e.AdjprodSt).HasColumnName("ADJPROD_ST");
        builder.Property(e => e.Adjprograd).HasColumnName("ADJPROGRAD");
        builder.Property(e => e.AffCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AFF_CODE");
        builder.Property(e => e.Afflbltype)
            .HasMaxLength(14)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AFFLBLTYPE");
        builder.Property(e => e.Akadisptxt)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("AKADISPTXT");
        builder.Property(e => e.AkasOfees)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("AKAS_OFEES");
        builder.Property(e => e.AltLtrhd)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("ALT_LTRHD");
        builder.Property(e => e.Archive)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("ARCHIVE");
        builder.Property(e => e.Attention)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ATTENTION");
        builder.Property(e => e.AttnBill)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ATTN_BILL");
        builder.Property(e => e.Baddr1)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BADDR1");
        builder.Property(e => e.Baddr2)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BADDR2");
        builder.Property(e => e.Baddr3)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BADDR3");
        builder.Property(e => e.Biemail)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BIEMAIL");
        builder.Property(e => e.Bifaxnum)
            .HasMaxLength(70)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BIFAXNUM");
        builder.Property(e => e.BillMeth)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("BILL_METH");
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
        builder.Property(e => e.Billselect)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILLSELECT");
        builder.Property(e => e.Bilwebpost).HasColumnName("BILWEBPOST");
        builder.Property(e => e.BkgAuto).HasColumnName("BKG_AUTO");
        builder.Property(e => e.BkgCemail)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BKG_CEMAIL");
        builder.Property(e => e.BkgDeliv)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("BKG_DELIV");
        builder.Property(e => e.BkgIncr)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("BKG_INCR");
        builder.Property(e => e.BkgMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BKG_MSG");
        builder.Property(e => e.BkgOemail)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BKG_OEMAIL");
        builder.Property(e => e.BkgPasst).HasColumnName("BKG_PASST");
        builder.Property(e => e.BkgRechk).HasColumnName("BKG_RECHK");
        builder.Property(e => e.BkgStwide).HasColumnName("BKG_STWIDE");
        builder.Property(e => e.BkgTiming)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("BKG_TIMING");
        builder.Property(e => e.Bkgautoday)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("BKGAUTODAY");
        builder.Property(e => e.Bkgnextdt)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("BKGNEXTDT");
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
        builder.Property(e => e.CIntNote)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("C_INT_NOTE");
        builder.Property(e => e.Ccautopay).HasColumnName("CCAUTOPAY");
        builder.Property(e => e.Ccexpnotif)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("CCEXPNOTIF");
        builder.Property(e => e.Ccholddays)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("CCHOLDDAYS");
        builder.Property(e => e.CcredMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CCRED_MSG");
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
        builder.Property(e => e.CmvrMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CMVR_MSG");
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
        builder.Property(e => e.CompRpt).HasColumnName("COMP_RPT");
        builder.Property(e => e.ComplCred).HasColumnName("COMPL_CRED");
        builder.Property(e => e.ComplMvr).HasColumnName("COMPL_MVR");
        builder.Property(e => e.ComplSoc).HasColumnName("COMPL_SOC");
        builder.Property(e => e.Confirmaka).HasColumnName("CONFIRMAKA");
        builder.Property(e => e.Confirmsri).HasColumnName("CONFIRMSRI");
        builder.Property(e => e.CreditFrz).HasColumnName("CREDIT_FRZ");
        builder.Property(e => e.Crimassign)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CRIMASSIGN");
        builder.Property(e => e.Crmautoalr).HasColumnName("CRMAUTOALR");
        builder.Property(e => e.CrprtCred).HasColumnName("CRPRT_CRED");
        builder.Property(e => e.CrprtSsn).HasColumnName("CRPRT_SSN");
        builder.Property(e => e.CrsntCred).HasColumnName("CRSNT_CRED");
        builder.Property(e => e.CrsntSsn).HasColumnName("CRSNT_SSN");
        builder.Property(e => e.CrtfeeExc).HasColumnName("CRTFEE_EXC");
        builder.Property(e => e.CrtfeeLst)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CRTFEE_LST");
        builder.Property(e => e.CrtfeeNot).HasColumnName("CRTFEE_NOT");
        builder.Property(e => e.CsocMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CSOC_MSG");
        builder.Property(e => e.Csri2comnt).HasColumnName("CSRI2COMNT");
        builder.Property(e => e.DiscrRes).HasColumnName("DISCR_RES");
        builder.Property(e => e.DiscrRpt).HasColumnName("DISCR_RPT");
        builder.Property(e => e.DiscrTerm)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DISCR_TERM");
        builder.Property(e => e.Dlinxovral).HasColumnName("DLINXOVRAL");
        builder.Property(e => e.DmdefaCc).HasColumnName("DMDEFA_CC");
        builder.Property(e => e.DmdefaVr).HasColumnName("DMDEFA_VR");
        builder.Property(e => e.DmdefaWk).HasColumnName("DMDEFA_WK");
        builder.Property(e => e.DsupprDob).HasColumnName("DSUPPR_DOB");
        builder.Property(e => e.DsupprSsn).HasColumnName("DSUPPR_SSN");
        builder.Property(e => e.EclDsXls).HasColumnName("ECL_DS_XLS");
        builder.Property(e => e.EclacMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ECLAC_MSG");
        builder.Property(e => e.Eclconfmsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ECLCONFMSG");
        builder.Property(e => e.EcldobMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ECLDOB_MSG");
        builder.Property(e => e.EclpkgMsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ECLPKG_MSG");
        builder.Property(e => e.Eclwelcmsg)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ECLWELCMSG");
        builder.Property(e => e.Emailclnt)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("EMAILCLNT");
        builder.Property(e => e.Emailnotif).HasColumnName("EMAILNOTIF");
        builder.Property(e => e.Emailzippw)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMAILZIPPW");
        builder.Property(e => e.EmlComprs).HasColumnName("EML_COMPRS");
        builder.Property(e => e.Enotifpart)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("ENOTIFPART");
        builder.Property(e => e.Enotiftype)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("ENOTIFTYPE");
        builder.Property(e => e.Exglobwmsg).HasColumnName("EXGLOBWMSG");
        builder.Property(e => e.Faxcall1st).HasColumnName("FAXCALL1ST");
        builder.Property(e => e.Firstfildt)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("FIRSTFILDT");
        builder.Property(e => e.Forcepwchg)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("FORCEPWCHG");
        builder.Property(e => e.Freezeaka).HasColumnName("FREEZEAKA");
        builder.Property(e => e.Freezesri).HasColumnName("FREEZESRI");
        builder.Property(e => e.FrzAdjpro).HasColumnName("FRZ_ADJPRO");
        builder.Property(e => e.FrzAll).HasColumnName("FRZ_ALL");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Iemail)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("IEMAIL");
        builder.Property(e => e.InactLev)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("INACT_LEV");
        builder.Property(e => e.Intidlimit)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("INTIDLIMIT");
        builder.Property(e => e.Itembltype)
            .HasMaxLength(14)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("ITEMBLTYPE");
        builder.Property(e => e.Lx1Per).HasColumnName("LX_1_PER");
        builder.Property(e => e.LxAdjudN)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_ADJUD_N");
        builder.Property(e => e.LxAdjudP)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_ADJUD_P");
        builder.Property(e => e.LxAdjudX).HasColumnName("LX_ADJUD_X");
        builder.Property(e => e.LxAdjudY)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_ADJUD_Y");
        builder.Property(e => e.LxConfirm).HasColumnName("LX_CONFIRM");
        builder.Property(e => e.LxDelxOn).HasColumnName("LX_DELX_ON");
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
        builder.Property(e => e.LxExintid).HasColumnName("LX_EXINTID");
        builder.Property(e => e.LxExsumm).HasColumnName("LX_EXSUMM");
        builder.Property(e => e.LxExtraid).HasColumnName("LX_EXTRAID");
        builder.Property(e => e.LxFtpinfo)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_FTPINFO");
        builder.Property(e => e.LxLpath)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_LPATH");
        builder.Property(e => e.LxPthtype)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("LX_PTHTYPE");
        builder.Property(e => e.LxRrfmt)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("LX_RRFMT");
        builder.Property(e => e.LxSexrace).HasColumnName("LX_SEXRACE");
        builder.Property(e => e.LxSiteid)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_SITEID");
        builder.Property(e => e.LxSupdob).HasColumnName("LX_SUPDOB");
        builder.Property(e => e.LxSupname).HasColumnName("LX_SUPNAME");
        builder.Property(e => e.LxSupssn).HasColumnName("LX_SUPSSN");
        builder.Property(e => e.LxWebalso).HasColumnName("LX_WEBALSO");
        builder.Property(e => e.LxWebpart).HasColumnName("LX_WEBPART");
        builder.Property(e => e.LxWebsv).HasColumnName("LX_WEBSV");
        builder.Property(e => e.LxWpath)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_WPATH");
        builder.Property(e => e.LxWsTodo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LX_WS_TODO");
        builder.Property(e => e.Lxstrucmvr).HasColumnName("LXSTRUCMVR");
        builder.Property(e => e.MvrDeFrz).HasColumnName("MVR_DE_FRZ");
        builder.Property(e => e.MvrFlUnl).HasColumnName("MVR_FL_UNL");
        builder.Property(e => e.Mvrautoalr).HasColumnName("MVRAUTOALR");
        builder.Property(e => e.NoComplet).HasColumnName("NO_COMPLET");
        builder.Property(e => e.NocrimTyp)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("NOCRIM_TYP");
        builder.Property(e => e.Noremcntys).HasColumnName("NOREMCNTYS");
        builder.Property(e => e.Notes)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("NOTES");
        builder.Property(e => e.PartRpt).HasColumnName("PART_RPT");
        builder.Property(e => e.Partalldet).HasColumnName("PARTALLDET");
        builder.Property(e => e.Partsndall).HasColumnName("PARTSNDALL");
        builder.Property(e => e.PatNoRec)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PAT_NO_REC");
        builder.Property(e => e.PatYesrec)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PAT_YESREC");
        builder.Property(e => e.PdfOrTxt)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PDF_OR_TXT");
        builder.Property(e => e.Pospiklist)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("POSPIKLIST");
        builder.Property(e => e.Post2Req).HasColumnName("POST_2_REQ");
        builder.Property(e => e.Priority)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("PRIORITY");
        builder.Property(e => e.Prtyclient)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PRTYCLIENT");
        builder.Property(e => e.PstAcAsn).HasColumnName("PST_AC_ASN");
        builder.Property(e => e.PstAlAka).HasColumnName("PST_AL_AKA");
        builder.Property(e => e.PstAlBbd).HasColumnName("PST_AL_BBD");
        builder.Property(e => e.PstAlDob).HasColumnName("PST_AL_DOB");
        builder.Property(e => e.PstAlDod).HasColumnName("PST_AL_DOD");
        builder.Property(e => e.PstAlEae).HasColumnName("PST_AL_EAE");
        builder.Property(e => e.PstAlFrz).HasColumnName("PST_AL_FRZ");
        builder.Property(e => e.PstAlIss).HasColumnName("PST_AL_ISS");
        builder.Property(e => e.PstAlNul).HasColumnName("PST_AL_NUL");
        builder.Property(e => e.PstAlSsn).HasColumnName("PST_AL_SSN");
        builder.Property(e => e.PstAlTra).HasColumnName("PST_AL_TRA");
        builder.Property(e => e.PstAlU21).HasColumnName("PST_AL_U21");
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
        builder.Property(e => e.PstCurasn).HasColumnName("PST_CURASN");
        builder.Property(e => e.PstCurfed).HasColumnName("PST_CURFED");
        builder.Property(e => e.PstErFrz).HasColumnName("PST_ER_FRZ");
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
        builder.Property(e => e.PstFrzall).HasColumnName("PST_FRZALL");
        builder.Property(e => e.PstInccty).HasColumnName("PST_INCCTY");
        builder.Property(e => e.PstNaFrz).HasColumnName("PST_NA_FRZ");
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
        builder.Property(e => e.Pstautoalr).HasColumnName("PSTAUTOALR");
        builder.Property(e => e.Pstshowsum).HasColumnName("PSTSHOWSUM");
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
        builder.Property(e => e.RefReq)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("REF_REQ");
        builder.Property(e => e.RmaskDln).HasColumnName("RMASK_DLN");
        builder.Property(e => e.Rpclisubid)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RPCLISUBID");
        builder.Property(e => e.Rsnlogfail)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RSNLOGFAIL");
        builder.Property(e => e.RsupprDob).HasColumnName("RSUPPR_DOB");
        builder.Property(e => e.RsupprSsn).HasColumnName("RSUPPR_SSN");
        builder.Property(e => e.SepBaddr).HasColumnName("SEP_BADDR");
        builder.Property(e => e.Setnumfail)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("SETNUMFAIL");
        builder.Property(e => e.SocialFrz).HasColumnName("SOCIAL_FRZ");
        builder.Property(e => e.Spec2Do)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("SPEC_2_DO");
        builder.Property(e => e.SpecProc)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SPEC_PROC");
        builder.Property(e => e.Special2).HasColumnName("SPECIAL_2");
        builder.Property(e => e.Special3).HasColumnName("SPECIAL_3");
        builder.Property(e => e.Special4).HasColumnName("SPECIAL_4");
        builder.Property(e => e.Special5).HasColumnName("SPECIAL_5");
        builder.Property(e => e.SpecialC).HasColumnName("SPECIAL_C");
        builder.Property(e => e.SriDest)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("SRI_DEST");
        builder.Property(e => e.SriSend)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("SRI_SEND");
        builder.Property(e => e.Sriweb2cmt).HasColumnName("SRIWEB2CMT");
        builder.Property(e => e.StrNmFrs).HasColumnName("STR_NM_FRS");
        builder.Property(e => e.StrNmM1).HasColumnName("STR_NM_M1");
        builder.Property(e => e.StrNmM2).HasColumnName("STR_NM_M2");
        builder.Property(e => e.StrNmM9).HasColumnName("STR_NM_M9");
        builder.Property(e => e.Suspended)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SUSPENDED");
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
        builder.Property(e => e.Typpwcrypt)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("TYPPWCRYPT");
        builder.Property(e => e.Usestrngpw).HasColumnName("USESTRNGPW");
        builder.Property(e => e.Usrchgpass).HasColumnName("USRCHGPASS");
        builder.Property(e => e.Valnotes)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("VALNOTES");
        builder.Property(e => e.Valpresuff)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("VALPRESUFF");
        builder.Property(e => e.VoicePhon)
            .HasMaxLength(17)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("VOICE_PHON");
        builder.Property(e => e.Web2ref).HasColumnName("WEB2REF");
        builder.Property(e => e.WebClient).HasColumnName("WEB_CLIENT");
        builder.Property(e => e.WebDsdays)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("WEB_DSDAYS");
        builder.Property(e => e.WebEnotif).HasColumnName("WEB_ENOTIF");
        builder.Property(e => e.WebGroup)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("WEB_GROUP");
        builder.Property(e => e.WebLastac)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("WEB_LASTAC");
        builder.Property(e => e.WebLastus)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("WEB_LASTUS");
        builder.Property(e => e.WebLoginc)
            .HasColumnType("numeric(7, 0)")
            .HasColumnName("WEB_LOGINC");
        builder.Property(e => e.WebPurge)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("WEB_PURGE");
        builder.Property(e => e.WebReqcnt)
            .HasColumnType("numeric(10, 0)")
            .HasColumnName("WEB_REQCNT");
        builder.Property(e => e.XmitMeth)
            .HasColumnType("numeric(8, 0)")
            .HasColumnName("XMIT_METH");
    }
}