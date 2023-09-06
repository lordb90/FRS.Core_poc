using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Global
{
    public decimal Nextfaxid { get; set; }

    public decimal Tempfaxid { get; set; }

    public decimal Nextwebord { get; set; }

    public decimal NextemlId { get; set; }

    public decimal Nextkey { get; set; }

    public decimal Nextsbatch { get; set; }

    public decimal Nextinvimg { get; set; }

    public decimal Nextmstrin { get; set; }

    public decimal Nextempkey { get; set; }

    public string BillNote { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string Addr4 { get; set; } = null!;

    public decimal Whichphone { get; set; }

    public decimal CcasGreen { get; set; }

    public decimal CcasRed { get; set; }

    public bool AmAssign { get; set; }

    public decimal NextostCd { get; set; }

    public bool CtyflgDe { get; set; }

    public bool CtyflgRem { get; set; }

    public decimal MethExsum { get; set; }

    public decimal SuprExsum { get; set; }

    public bool DiscCb1 { get; set; }

    public string DisclFull { get; set; } = null!;

    public decimal DiscfFnt { get; set; }

    public string DiscFhead { get; set; } = null!;

    public decimal DiscfhFnt { get; set; }

    public bool DiscCb2 { get; set; }

    public string DisclRcap { get; set; } = null!;

    public decimal DiscrFnt { get; set; }

    public string DiscRhead { get; set; } = null!;

    public decimal DiscrhFnt { get; set; }

    public bool D2Execut { get; set; }

    public bool D2Partial { get; set; }

    public bool D2Recap { get; set; }

    public bool D2Allin1 { get; set; }

    public bool D2Deluxe { get; set; }

    public bool SlPause { get; set; }

    public bool SlmsgPage { get; set; }

    public string SlmsgEP1 { get; set; } = null!;

    public string SlmsgEP2 { get; set; } = null!;

    public bool SlmsgEnd { get; set; }

    public string SlmsgEE1 { get; set; } = null!;

    public string SlmsgEE2 { get; set; } = null!;

    public bool SlCompcod { get; set; }

    public bool SlAddress { get; set; }

    public bool SlUpper { get; set; }

    public string Ref2Labl { get; set; } = null!;

    public bool KeyToRef { get; set; }

    public string ConltrF1 { get; set; } = null!;

    public string ConltrF2 { get; set; } = null!;

    public decimal FaxMethod { get; set; }

    public decimal FaxRetry { get; set; }

    public decimal FaxPurge { get; set; }

    public string FaxLocal { get; set; } = null!;

    public string FaxPrefix { get; set; } = null!;

    public bool FaxPrsucc { get; set; }

    public bool FaxPrerr { get; set; }

    public decimal Resrpttype { get; set; }

    public decimal ResrptChg { get; set; }

    public decimal Resrptpric { get; set; }

    public decimal Resrptesum { get; set; }

    public decimal Resrptnarr { get; set; }

    public decimal BillDate { get; set; }

    public decimal BilldtChg { get; set; }

    public decimal Bidailygen { get; set; }

    public decimal InetScope { get; set; }

    public decimal CloseOut { get; set; }

    public decimal ConnPart { get; set; }

    public decimal CloseOuto { get; set; }

    public bool IimgFlag { get; set; }

    public decimal DlxOrder { get; set; }

    public string DlxTitle { get; set; } = null!;

    public decimal Dstatstyle { get; set; }

    public string MvrWords { get; set; } = null!;

    public string MvrForm { get; set; } = null!;

    public decimal CtyflgAss { get; set; }

    public decimal ResAssign { get; set; }

    public decimal Ctylumeth { get; set; }

    public string CrimRptit { get; set; } = null!;

    public string Btypenotes { get; set; } = null!;

    public decimal ProofRem { get; set; }

    public decimal ProofConn { get; set; }

    public decimal ProofAuto { get; set; }

    public decimal ConnCrtyr { get; set; }

    public decimal RemUp2del { get; set; }

    public string CrimnoReg { get; set; } = null!;

    public string CrimnoAka { get; set; } = null!;

    public decimal EditsubSw { get; set; }

    public decimal Specialaka { get; set; }

    public string AltcPhone { get; set; } = null!;

    public bool DlxReqdt { get; set; }

    public bool ShowCosts { get; set; }

    public string EmlRaRes { get; set; } = null!;

    public string EmlRaSrc { get; set; } = null!;

    public string EmlRaWeb { get; set; } = null!;

    public string EmlRaErr { get; set; } = null!;

    public decimal SmtpOrOt { get; set; }

    public string SmtpServr { get; set; } = null!;

    public decimal EmlPurge { get; set; }

    public decimal EmlRetry { get; set; }

    public decimal EmlNotify { get; set; }

    public string MsgRes { get; set; } = null!;

    public string MsgSrc { get; set; } = null!;

    public string MsgTrace { get; set; } = null!;

    public string MsgDstat { get; set; } = null!;

    public string MsgWeb { get; set; } = null!;

    public decimal Empparcomm { get; set; }

    public decimal Eduparcomm { get; set; }

    public decimal Pliparcomm { get; set; }

    public decimal InactNot { get; set; }

    public decimal EmpIncRh { get; set; }

    public bool BlremSep { get; set; }

    public string Blremaddr1 { get; set; } = null!;

    public string Blremaddr2 { get; set; } = null!;

    public string Blremaddr3 { get; set; } = null!;

    public string Blremaddr4 { get; set; } = null!;

    public bool FrzSearch { get; set; }

    public bool FrzResult { get; set; }

    public bool FrzCounty { get; set; }

    public bool FrzMvr { get; set; }

    public bool FrzCadd { get; set; }

    public bool FrzDups { get; set; }

    public string DburCred { get; set; } = null!;

    public string DburSsn { get; set; } = null!;

    public string ReqfrmEmp { get; set; } = null!;

    public string ReqfrmEd { get; set; } = null!;

    public string ReqfrmPl { get; set; } = null!;

    public decimal AutoInvdp { get; set; }

    public bool DisclNolh { get; set; }

    public string Stica2ndpw { get; set; } = null!;

    public DateTime Stica2nddt { get; set; }

    public decimal EmpLuUpd { get; set; }

    public bool FrzDlxerr { get; set; }

    public bool FrzDlxyes { get; set; }

    public bool FrzVnet { get; set; }

    public decimal AkaCase { get; set; }

    public string MsgVnet { get; set; } = null!;

    public string MsgBill { get; set; } = null!;

    public string Embilldesc { get; set; } = null!;

    public string EmlRaBil { get; set; } = null!;

    public decimal Dstatsygen { get; set; }

    public bool MyverAssn { get; set; }

    public bool MyverChwn { get; set; }

    public bool MyverChns { get; set; }

    public decimal VerAdDel { get; set; }

    public decimal ChwnExtra { get; set; }

    public decimal ChnsExtra { get; set; }

    public string ChwnDesc { get; set; } = null!;

    public string ChnsDesc { get; set; } = null!;

    public decimal Osthelpnbr { get; set; }

    public decimal Webmsgkey { get; set; }

    public decimal Webrptkey { get; set; }

    public bool FrzMyver { get; set; }

    public string Rpclientid { get; set; } = null!;

    public string Rppassword { get; set; } = null!;

    public string Rpclisubid { get; set; } = null!;

    public bool FrzRefpro { get; set; }

    public bool Disablrefp { get; set; }

    public string Frmoverall { get; set; } = null!;

    public string Fi9partid { get; set; } = null!;

    public string Fi9partlog { get; set; } = null!;

    public string Fi9partpw { get; set; } = null!;

    public string Fi9ostEi9 { get; set; } = null!;

    public string Fi9ostEvp { get; set; } = null!;

    public bool Fi9adnuI9 { get; set; }

    public bool Fi9adnuevp { get; set; }

    public string Fi9textI9 { get; set; } = null!;

    public string Fi9textevp { get; set; } = null!;

    public bool FrzMvryes { get; set; }

    public bool Qbtermcond { get; set; }

    public string Qbtermuser { get; set; } = null!;

    public DateTime Qbtermwhen { get; set; }

    public bool SlShowbtn { get; set; }

    public string OlappDemo { get; set; } = null!;

    public string IuserId { get; set; } = null!;

    public string IuserPswd { get; set; } = null!;

    public decimal FaxVia { get; set; }

    public bool Autologout { get; set; }

    public bool Noacrobat { get; set; }

    public bool Recrevcrim { get; set; }

    public bool Recrevempl { get; set; }

    public bool Recreveduc { get; set; }

    public bool Recrevplic { get; set; }

    public bool Recrevmlos { get; set; }

    public bool Norecap { get; set; }

    public bool Fi9setpri9 { get; set; }

    public bool Fi9setprev { get; set; }

    public bool ChrgAkas { get; set; }

    public bool Ssalert772 { get; set; }

    public string Altunlname { get; set; } = null!;

    public string IcNotes { get; set; } = null!;

    public string IcCrnotes { get; set; } = null!;

    public bool Propercity { get; set; }

    public bool SlNopasst { get; set; }

    public bool SlNodlinx { get; set; }

    public bool Recnotshow { get; set; }

    public bool Sldamskssn { get; set; }

    public bool Usefrs4eml { get; set; }

    public bool Itdispcost { get; set; }

    public string Nscsetup { get; set; } = null!;

    public string Wknsetup { get; set; } = null!;

    public decimal Dstatcrfrz { get; set; }

    public bool FrzMvrbad { get; set; }

    public bool FrzCredbd { get; set; }

    public decimal Nextinvnum { get; set; }

    public decimal Invnumtype { get; set; }

    public decimal Askextrwkn { get; set; }

    public decimal Askextrnsc { get; set; }

    public bool Nscaddrate { get; set; }

    public string Anetlogin { get; set; } = null!;

    public string Anettranky { get; set; } = null!;

    public decimal Numexpdays { get; set; }

    public string Ccexpmsg { get; set; } = null!;

    public bool SlNocred { get; set; }

    public string MsgMltres { get; set; } = null!;

    public string Purgelocn { get; set; } = null!;

    public bool Useagenum { get; set; }

    public bool Vnemincres { get; set; }

    public string Rsvdcompcd { get; set; } = null!;

    public string Advtextpre { get; set; } = null!;

    public string Advtextpst { get; set; } = null!;

    public string Aamloprefr { get; set; } = null!;

    public string Aamlopstfr { get; set; } = null!;

    public string Aamlopreec { get; set; } = null!;

    public string Aamlopstec { get; set; } = null!;

    public string Aafcralink { get; set; } = null!;

    public string Aaattach1 { get; set; } = null!;

    public string Aaattach2 { get; set; } = null!;

    public string Aaattach3 { get; set; } = null!;

    public string Aaattach4 { get; set; } = null!;

    public string Aaattach5 { get; set; } = null!;

    public string Aaattdesc1 { get; set; } = null!;

    public string Aaattdesc2 { get; set; } = null!;

    public string Aaattdesc3 { get; set; } = null!;

    public string Aaattdesc4 { get; set; } = null!;

    public string Aaattdesc5 { get; set; } = null!;

    public bool Hidebllogo { get; set; }

    public decimal ChwnExtr2 { get; set; }

    public decimal ChwnExtr3 { get; set; }

    public bool OlappCc { get; set; }

    public string OlappAddr { get; set; } = null!;

    public string OlapPhone { get; set; } = null!;

    public bool AalFcomp { get; set; }

    public bool Nofrzifclr { get; set; }

    public bool Recrevxdlx { get; set; }

    public bool Revallcrim { get; set; }

    public bool Recrevicrm { get; set; }

    public bool Recrevvnet { get; set; }

    public bool Recrevlinx { get; set; }

    public string Tenantost { get; set; } = null!;

    public string Id { get; set; } = null!;
}
