using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class GlobalConfiguration : IEntityTypeConfiguration<Global>
    {
        public void Configure(EntityTypeBuilder<Global> builder)
        {
            builder
                .HasNoKey()
                .ToTable("GLOBALS");

            builder.Property(e => e.Aaattach1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTACH1");
            builder.Property(e => e.Aaattach2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTACH2");
            builder.Property(e => e.Aaattach3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTACH3");
            builder.Property(e => e.Aaattach4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTACH4");
            builder.Property(e => e.Aaattach5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTACH5");
            builder.Property(e => e.Aaattdesc1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTDESC1");
            builder.Property(e => e.Aaattdesc2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTDESC2");
            builder.Property(e => e.Aaattdesc3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTDESC3");
            builder.Property(e => e.Aaattdesc4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTDESC4");
            builder.Property(e => e.Aaattdesc5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAATTDESC5");
            builder.Property(e => e.Aafcralink)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAFCRALINK");
            builder.Property(e => e.AalFcomp).HasColumnName("AAL_FCOMP");
            builder.Property(e => e.Aamlopreec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAMLOPREEC");
            builder.Property(e => e.Aamloprefr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAMLOPREFR");
            builder.Property(e => e.Aamlopstec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAMLOPSTEC");
            builder.Property(e => e.Aamlopstfr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AAMLOPSTFR");
            builder.Property(e => e.Addr1)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDR1");
            builder.Property(e => e.Addr2)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDR2");
            builder.Property(e => e.Addr3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDR3");
            builder.Property(e => e.Addr4)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDR4");
            builder.Property(e => e.Advtextpre)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVTEXTPRE");
            builder.Property(e => e.Advtextpst)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADVTEXTPST");
            builder.Property(e => e.AkaCase)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("AKA_CASE");
            builder.Property(e => e.AltcPhone)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTC_PHONE");
            builder.Property(e => e.Altunlname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALTUNLNAME");
            builder.Property(e => e.AmAssign).HasColumnName("AM_ASSIGN");
            builder.Property(e => e.Anetlogin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANETLOGIN");
            builder.Property(e => e.Anettranky)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANETTRANKY");
            builder.Property(e => e.Askextrnsc)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ASKEXTRNSC");
            builder.Property(e => e.Askextrwkn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ASKEXTRWKN");
            builder.Property(e => e.AutoInvdp)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("AUTO_INVDP");
            builder.Property(e => e.Autologout).HasColumnName("AUTOLOGOUT");
            builder.Property(e => e.Bidailygen)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("BIDAILYGEN");
            builder.Property(e => e.BillDate)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("BILL_DATE");
            builder.Property(e => e.BillNote)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILL_NOTE");
            builder.Property(e => e.BilldtChg)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("BILLDT_CHG");
            builder.Property(e => e.BlremSep).HasColumnName("BLREM_SEP");
            builder.Property(e => e.Blremaddr1)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BLREMADDR1");
            builder.Property(e => e.Blremaddr2)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BLREMADDR2");
            builder.Property(e => e.Blremaddr3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BLREMADDR3");
            builder.Property(e => e.Blremaddr4)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BLREMADDR4");
            builder.Property(e => e.Btypenotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BTYPENOTES");
            builder.Property(e => e.CcasGreen)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CCAS_GREEN");
            builder.Property(e => e.CcasRed)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("CCAS_RED");
            builder.Property(e => e.Ccexpmsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CCEXPMSG");
            builder.Property(e => e.ChnsDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CHNS_DESC");
            builder.Property(e => e.ChnsExtra)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHNS_EXTRA");
            builder.Property(e => e.ChrgAkas).HasColumnName("CHRG_AKAS");
            builder.Property(e => e.ChwnDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CHWN_DESC");
            builder.Property(e => e.ChwnExtr2)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTR2");
            builder.Property(e => e.ChwnExtr3)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTR3");
            builder.Property(e => e.ChwnExtra)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHWN_EXTRA");
            builder.Property(e => e.CloseOut)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CLOSE_OUT");
            builder.Property(e => e.CloseOuto)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CLOSE_OUTO");
            builder.Property(e => e.ConltrF1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONLTR_F1");
            builder.Property(e => e.ConltrF2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONLTR_F2");
            builder.Property(e => e.ConnCrtyr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CONN_CRTYR");
            builder.Property(e => e.ConnPart)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CONN_PART");
            builder.Property(e => e.CrimRptit)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIM_RPTIT");
            builder.Property(e => e.CrimnoAka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIMNO_AKA");
            builder.Property(e => e.CrimnoReg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRIMNO_REG");
            builder.Property(e => e.CtyflgAss)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CTYFLG_ASS");
            builder.Property(e => e.CtyflgDe).HasColumnName("CTYFLG_DE");
            builder.Property(e => e.CtyflgRem).HasColumnName("CTYFLG_REM");
            builder.Property(e => e.Ctylumeth)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CTYLUMETH");
            builder.Property(e => e.D2Allin1).HasColumnName("D2_ALLIN_1");
            builder.Property(e => e.D2Deluxe).HasColumnName("D2_DELUXE");
            builder.Property(e => e.D2Execut).HasColumnName("D2_EXECUT");
            builder.Property(e => e.D2Partial).HasColumnName("D2_PARTIAL");
            builder.Property(e => e.D2Recap).HasColumnName("D2_RECAP");
            builder.Property(e => e.DburCred)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DBUR_CRED");
            builder.Property(e => e.DburSsn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DBUR_SSN");
            builder.Property(e => e.Disablrefp).HasColumnName("DISABLREFP");
            builder.Property(e => e.DiscCb1).HasColumnName("DISC_CB_1");
            builder.Property(e => e.DiscCb2).HasColumnName("DISC_CB_2");
            builder.Property(e => e.DiscFhead)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISC_FHEAD");
            builder.Property(e => e.DiscRhead)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISC_RHEAD");
            builder.Property(e => e.DiscfFnt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DISCF_FNT");
            builder.Property(e => e.DiscfhFnt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DISCFH_FNT");
            builder.Property(e => e.DisclFull)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISCL_FULL");
            builder.Property(e => e.DisclNolh).HasColumnName("DISCL_NOLH");
            builder.Property(e => e.DisclRcap)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISCL_RCAP");
            builder.Property(e => e.DiscrFnt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DISCR_FNT");
            builder.Property(e => e.DiscrhFnt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DISCRH_FNT");
            builder.Property(e => e.DlxOrder)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLX_ORDER");
            builder.Property(e => e.DlxReqdt).HasColumnName("DLX_REQDT");
            builder.Property(e => e.DlxTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLX_TITLE");
            builder.Property(e => e.Dstatcrfrz)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DSTATCRFRZ");
            builder.Property(e => e.Dstatstyle)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DSTATSTYLE");
            builder.Property(e => e.Dstatsygen)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DSTATSYGEN");
            builder.Property(e => e.EditsubSw)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EDITSUB_SW");
            builder.Property(e => e.Eduparcomm)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EDUPARCOMM");
            builder.Property(e => e.Embilldesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMBILLDESC");
            builder.Property(e => e.EmlNotify)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EML_NOTIFY");
            builder.Property(e => e.EmlPurge)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EML_PURGE");
            builder.Property(e => e.EmlRaBil)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_BIL");
            builder.Property(e => e.EmlRaErr)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_ERR");
            builder.Property(e => e.EmlRaRes)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_RES");
            builder.Property(e => e.EmlRaSrc)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_SRC");
            builder.Property(e => e.EmlRaWeb)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_WEB");
            builder.Property(e => e.EmlRetry)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EML_RETRY");
            builder.Property(e => e.EmpIncRh)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EMP_INC_RH");
            builder.Property(e => e.EmpLuUpd)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EMP_LU_UPD");
            builder.Property(e => e.Empparcomm)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("EMPPARCOMM");
            builder.Property(e => e.FaxLocal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_LOCAL");
            builder.Property(e => e.FaxMethod)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("FAX_METHOD");
            builder.Property(e => e.FaxPrefix)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_PREFIX");
            builder.Property(e => e.FaxPrerr).HasColumnName("FAX_PRERR");
            builder.Property(e => e.FaxPrsucc).HasColumnName("FAX_PRSUCC");
            builder.Property(e => e.FaxPurge)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FAX_PURGE");
            builder.Property(e => e.FaxRetry)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FAX_RETRY");
            builder.Property(e => e.FaxVia)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("FAX_VIA");
            builder.Property(e => e.Fi9adnuI9).HasColumnName("FI9ADNU_I9");
            builder.Property(e => e.Fi9adnuevp).HasColumnName("FI9ADNUEVP");
            builder.Property(e => e.Fi9ostEi9)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9OST_EI9");
            builder.Property(e => e.Fi9ostEvp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9OST_EVP");
            builder.Property(e => e.Fi9partid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9PARTID");
            builder.Property(e => e.Fi9partlog)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9PARTLOG");
            builder.Property(e => e.Fi9partpw)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9PARTPW");
            builder.Property(e => e.Fi9setprev).HasColumnName("FI9SETPREV");
            builder.Property(e => e.Fi9setpri9).HasColumnName("FI9SETPRI9");
            builder.Property(e => e.Fi9textI9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9TEXT_I9");
            builder.Property(e => e.Fi9textevp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FI9TEXTEVP");
            builder.Property(e => e.Frmoverall)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRMOVERALL");
            builder.Property(e => e.FrzCadd).HasColumnName("FRZ_CADD");
            builder.Property(e => e.FrzCounty).HasColumnName("FRZ_COUNTY");
            builder.Property(e => e.FrzCredbd).HasColumnName("FRZ_CREDBD");
            builder.Property(e => e.FrzDlxerr).HasColumnName("FRZ_DLXERR");
            builder.Property(e => e.FrzDlxyes).HasColumnName("FRZ_DLXYES");
            builder.Property(e => e.FrzDups).HasColumnName("FRZ_DUPS");
            builder.Property(e => e.FrzMvr).HasColumnName("FRZ_MVR");
            builder.Property(e => e.FrzMvrbad).HasColumnName("FRZ_MVRBAD");
            builder.Property(e => e.FrzMvryes).HasColumnName("FRZ_MVRYES");
            builder.Property(e => e.FrzMyver).HasColumnName("FRZ_MYVER");
            builder.Property(e => e.FrzRefpro).HasColumnName("FRZ_REFPRO");
            builder.Property(e => e.FrzResult).HasColumnName("FRZ_RESULT");
            builder.Property(e => e.FrzSearch).HasColumnName("FRZ_SEARCH");
            builder.Property(e => e.FrzVnet).HasColumnName("FRZ_VNET");
            builder.Property(e => e.Hidebllogo).HasColumnName("HIDEBLLOGO");
            builder.Property(e => e.IcCrnotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IC_CRNOTES");
            builder.Property(e => e.IcNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IC_NOTES");
            builder.Property(e => e.Id)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ID");
            builder.Property(e => e.IimgFlag).HasColumnName("IIMG_FLAG");
            builder.Property(e => e.InactNot)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("INACT_NOT");
            builder.Property(e => e.InetScope)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("INET_SCOPE");
            builder.Property(e => e.Invnumtype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("INVNUMTYPE");
            builder.Property(e => e.Itdispcost).HasColumnName("ITDISPCOST");
            builder.Property(e => e.IuserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IUSER_ID");
            builder.Property(e => e.IuserPswd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IUSER_PSWD");
            builder.Property(e => e.KeyToRef).HasColumnName("KEY_TO_REF");
            builder.Property(e => e.MethExsum)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("METH_EXSUM");
            builder.Property(e => e.MsgBill)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_BILL");
            builder.Property(e => e.MsgDstat)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_DSTAT");
            builder.Property(e => e.MsgMltres)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_MLTRES");
            builder.Property(e => e.MsgRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_RES");
            builder.Property(e => e.MsgSrc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_SRC");
            builder.Property(e => e.MsgTrace)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_TRACE");
            builder.Property(e => e.MsgVnet)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_VNET");
            builder.Property(e => e.MsgWeb)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSG_WEB");
            builder.Property(e => e.MvrForm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_FORM");
            builder.Property(e => e.MvrWords)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_WORDS");
            builder.Property(e => e.MyverAssn).HasColumnName("MYVER_ASSN");
            builder.Property(e => e.MyverChns).HasColumnName("MYVER_CHNS");
            builder.Property(e => e.MyverChwn).HasColumnName("MYVER_CHWN");
            builder.Property(e => e.NextemlId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("NEXTEML_ID");
            builder.Property(e => e.Nextempkey)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("NEXTEMPKEY");
            builder.Property(e => e.Nextfaxid)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("NEXTFAXID");
            builder.Property(e => e.Nextinvimg)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("NEXTINVIMG");
            builder.Property(e => e.Nextinvnum)
                .HasColumnType("numeric(11, 0)")
                .HasColumnName("NEXTINVNUM");
            builder.Property(e => e.Nextkey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NEXTKEY");
            builder.Property(e => e.Nextmstrin)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NEXTMSTRIN");
            builder.Property(e => e.NextostCd)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NEXTOST_CD");
            builder.Property(e => e.Nextsbatch)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("NEXTSBATCH");
            builder.Property(e => e.Nextwebord)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NEXTWEBORD");
            builder.Property(e => e.Noacrobat).HasColumnName("NOACROBAT");
            builder.Property(e => e.Nofrzifclr).HasColumnName("NOFRZIFCLR");
            builder.Property(e => e.Norecap).HasColumnName("NORECAP");
            builder.Property(e => e.Nscaddrate).HasColumnName("NSCADDRATE");
            builder.Property(e => e.Nscsetup)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NSCSETUP");
            builder.Property(e => e.Numexpdays)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUMEXPDAYS");
            builder.Property(e => e.OlapPhone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OLAP_PHONE");
            builder.Property(e => e.OlappAddr)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OLAPP_ADDR");
            builder.Property(e => e.OlappCc).HasColumnName("OLAPP_CC");
            builder.Property(e => e.OlappDemo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OLAPP_DEMO");
            builder.Property(e => e.Osthelpnbr)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("OSTHELPNBR");
            builder.Property(e => e.Pliparcomm)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PLIPARCOMM");
            builder.Property(e => e.ProofAuto)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PROOF_AUTO");
            builder.Property(e => e.ProofConn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PROOF_CONN");
            builder.Property(e => e.ProofRem)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PROOF_REM");
            builder.Property(e => e.Propercity).HasColumnName("PROPERCITY");
            builder.Property(e => e.Purgelocn)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PURGELOCN");
            builder.Property(e => e.Qbtermcond).HasColumnName("QBTERMCOND");
            builder.Property(e => e.Qbtermuser)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QBTERMUSER");
            builder.Property(e => e.Qbtermwhen)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("QBTERMWHEN");
            builder.Property(e => e.Recnotshow).HasColumnName("RECNOTSHOW");
            builder.Property(e => e.Recrevcrim).HasColumnName("RECREVCRIM");
            builder.Property(e => e.Recreveduc).HasColumnName("RECREVEDUC");
            builder.Property(e => e.Recrevempl).HasColumnName("RECREVEMPL");
            builder.Property(e => e.Recrevicrm).HasColumnName("RECREVICRM");
            builder.Property(e => e.Recrevlinx).HasColumnName("RECREVLINX");
            builder.Property(e => e.Recrevmlos).HasColumnName("RECREVMLOS");
            builder.Property(e => e.Recrevplic).HasColumnName("RECREVPLIC");
            builder.Property(e => e.Recrevvnet).HasColumnName("RECREVVNET");
            builder.Property(e => e.Recrevxdlx).HasColumnName("RECREVXDLX");
            builder.Property(e => e.Ref2Labl)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REF_2_LABL");
            builder.Property(e => e.RemUp2del)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("REM_UP2DEL");
            builder.Property(e => e.ReqfrmEd)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQFRM_ED");
            builder.Property(e => e.ReqfrmEmp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQFRM_EMP");
            builder.Property(e => e.ReqfrmPl)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQFRM_PL");
            builder.Property(e => e.ResAssign)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RES_ASSIGN");
            builder.Property(e => e.ResrptChg)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RESRPT_CHG");
            builder.Property(e => e.Resrptesum)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RESRPTESUM");
            builder.Property(e => e.Resrptnarr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RESRPTNARR");
            builder.Property(e => e.Resrptpric)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RESRPTPRIC");
            builder.Property(e => e.Resrpttype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RESRPTTYPE");
            builder.Property(e => e.Revallcrim).HasColumnName("REVALLCRIM");
            builder.Property(e => e.Rpclientid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPCLIENTID");
            builder.Property(e => e.Rpclisubid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPCLISUBID");
            builder.Property(e => e.Rppassword)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPPASSWORD");
            builder.Property(e => e.Rsvdcompcd)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RSVDCOMPCD");
            builder.Property(e => e.ShowCosts).HasColumnName("SHOW_COSTS");
            builder.Property(e => e.SlAddress).HasColumnName("SL_ADDRESS");
            builder.Property(e => e.SlCompcod).HasColumnName("SL_COMPCOD");
            builder.Property(e => e.SlNocred).HasColumnName("SL_NOCRED");
            builder.Property(e => e.SlNodlinx).HasColumnName("SL_NODLINX");
            builder.Property(e => e.SlNopasst).HasColumnName("SL_NOPASST");
            builder.Property(e => e.SlPause).HasColumnName("SL_PAUSE");
            builder.Property(e => e.SlShowbtn).HasColumnName("SL_SHOWBTN");
            builder.Property(e => e.SlUpper).HasColumnName("SL_UPPER");
            builder.Property(e => e.Sldamskssn).HasColumnName("SLDAMSKSSN");
            builder.Property(e => e.SlmsgEE1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SLMSG_E_E1");
            builder.Property(e => e.SlmsgEE2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SLMSG_E_E2");
            builder.Property(e => e.SlmsgEP1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SLMSG_E_P1");
            builder.Property(e => e.SlmsgEP2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SLMSG_E_P2");
            builder.Property(e => e.SlmsgEnd).HasColumnName("SLMSG_END");
            builder.Property(e => e.SlmsgPage).HasColumnName("SLMSG_PAGE");
            builder.Property(e => e.SmtpOrOt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SMTP_OR_OT");
            builder.Property(e => e.SmtpServr)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SMTP_SERVR");
            builder.Property(e => e.Specialaka)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SPECIALAKA");
            builder.Property(e => e.Ssalert772).HasColumnName("SSALERT772");
            builder.Property(e => e.Stica2nddt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("STICA2NDDT");
            builder.Property(e => e.Stica2ndpw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STICA2NDPW");
            builder.Property(e => e.SuprExsum)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SUPR_EXSUM");
            builder.Property(e => e.Tempfaxid)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TEMPFAXID");
            builder.Property(e => e.Tenantost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TENANTOST");
            builder.Property(e => e.Useagenum).HasColumnName("USEAGENUM");
            builder.Property(e => e.Usefrs4eml).HasColumnName("USEFRS4EML");
            builder.Property(e => e.VerAdDel)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VER_AD_DEL");
            builder.Property(e => e.Vnemincres).HasColumnName("VNEMINCRES");
            builder.Property(e => e.Webmsgkey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBMSGKEY");
            builder.Property(e => e.Webrptkey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBRPTKEY");
            builder.Property(e => e.Whichphone)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WHICHPHONE");
            builder.Property(e => e.Wknsetup)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WKNSETUP");
        }
    }
}