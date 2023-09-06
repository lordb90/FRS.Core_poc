using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Company
{
    public string CompCode { get; set; } = null!;

    public string CompName { get; set; } = null!;

    public string BillType { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public bool SepBaddr { get; set; }

    public string Baddr1 { get; set; } = null!;

    public string Baddr2 { get; set; } = null!;

    public string Baddr3 { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string AttnBill { get; set; } = null!;

    public string VoicePhon { get; set; } = null!;

    public string Iemail { get; set; } = null!;

    public string Biemail { get; set; } = null!;

    public decimal NocrimTyp { get; set; }

    public decimal AltLtrhd { get; set; }

    public decimal RefReq { get; set; }

    public string AcctMgr { get; set; } = null!;

    public decimal XmitMeth { get; set; }

    public string AcctNbr { get; set; } = null!;

    public string Billselect { get; set; } = null!;

    public DateTime Archive { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime AddDate { get; set; }

    public string BurCred { get; set; } = null!;

    public string BurSsn { get; set; } = null!;

    public string TuPurp { get; set; } = null!;

    public string TuCProd { get; set; } = null!;

    public string TuSProd { get; set; } = null!;

    public string TuCAddon { get; set; } = null!;

    public string TuSAddon { get; set; } = null!;

    public string TrwCredkw { get; set; } = null!;

    public string TrwSsnkw { get; set; } = null!;

    public string TuMarket { get; set; } = null!;

    public string TuSubmark { get; set; } = null!;

    public string TuIcode { get; set; } = null!;

    public string TuSubs { get; set; } = null!;

    public string TuPw { get; set; } = null!;

    public string TusMarket { get; set; } = null!;

    public string TusSubmar { get; set; } = null!;

    public string TusIcode { get; set; } = null!;

    public string TusSubs { get; set; } = null!;

    public string TusPw { get; set; } = null!;

    public decimal Priority { get; set; }

    public decimal ChrgCfees { get; set; }

    public decimal ChrgMvrfe { get; set; }

    public string Billcode { get; set; } = null!;

    public bool WebClient { get; set; }

    public string WebGroup { get; set; } = null!;

    public decimal WebLoginc { get; set; }

    public DateTime WebLastac { get; set; }

    public string WebLastus { get; set; } = null!;

    public decimal WebReqcnt { get; set; }

    public bool Faxcall1st { get; set; }

    public decimal WebDsdays { get; set; }

    public string SpecProc { get; set; } = null!;

    public decimal Spec2Do { get; set; }

    public string AffCode { get; set; } = null!;

    public string Emailzippw { get; set; } = null!;

    public decimal InactLev { get; set; }

    public string CliState { get; set; } = null!;

    public string Itembltype { get; set; } = null!;

    public decimal WebPurge { get; set; }

    public bool DsupprSsn { get; set; }

    public bool DsupprDob { get; set; }

    public decimal PdfOrTxt { get; set; }

    public bool EmlComprs { get; set; }

    public bool WebEnotif { get; set; }

    public bool FrzAll { get; set; }

    public bool DiscrRpt { get; set; }

    public string DiscrTerm { get; set; } = null!;

    public decimal PstCtyasn { get; set; }

    public decimal PstCtynbr { get; set; }

    public decimal PstCtyyrs { get; set; }

    public decimal PstCtysrc { get; set; }

    public string PstFooter { get; set; } = null!;

    public bool PstAlAka { get; set; }

    public bool PstAlSsn { get; set; }

    public bool PstAlDob { get; set; }

    public bool PstAlDod { get; set; }

    public bool PstAlFrz { get; set; }

    public bool PstErFrz { get; set; }

    public decimal Enotiftype { get; set; }

    public decimal Enotifpart { get; set; }

    public bool PartRpt { get; set; }

    public bool CompRpt { get; set; }

    public bool DiscrRes { get; set; }

    public bool RsupprSsn { get; set; }

    public bool RsupprDob { get; set; }

    public bool LxWebsv { get; set; }

    public string LxSiteid { get; set; } = null!;

    public decimal LxRrfmt { get; set; }

    public string LxWpath { get; set; } = null!;

    public decimal LxPthtype { get; set; }

    public string LxLpath { get; set; } = null!;

    public bool LxEmnorec { get; set; }

    public bool LxEmnosnt { get; set; }

    public string LxEmladdr { get; set; } = null!;

    public string LxEmRmsg { get; set; } = null!;

    public string LxEmSmsg { get; set; } = null!;

    public string LxWsTodo { get; set; } = null!;

    public bool LxWebalso { get; set; }

    public bool LxExsumm { get; set; }

    public bool LxDelxOn { get; set; }

    public string LxFtpinfo { get; set; } = null!;

    public bool CrprtCred { get; set; }

    public bool CrprtSsn { get; set; }

    public bool CrsntCred { get; set; }

    public bool CrsntSsn { get; set; }

    public string PatNoRec { get; set; } = null!;

    public string PatYesrec { get; set; } = null!;

    public decimal PstFedasn { get; set; }

    public decimal PstFednbr { get; set; }

    public decimal PstFedyrs { get; set; }

    public bool PstSwAsn { get; set; }

    public bool PstAcAsn { get; set; }

    public bool PstRfddup { get; set; }

    public bool PstRfmism { get; set; }

    public bool PstRftfrm { get; set; }

    public bool PstRfDob { get; set; }

    public bool PstRfSsn { get; set; }

    public decimal PstResfmt { get; set; }

    public string PstResmsg { get; set; } = null!;

    public decimal BillMeth { get; set; }

    public bool Bilwebpost { get; set; }

    public bool Dlinxovral { get; set; }

    public bool PstFrzall { get; set; }

    public bool LxAdjudX { get; set; }

    public bool Lx1Per { get; set; }

    public bool LxExintid { get; set; }

    public decimal Intidlimit { get; set; }

    public bool ComplCred { get; set; }

    public bool ComplSoc { get; set; }

    public bool ComplMvr { get; set; }

    public string CcredMsg { get; set; } = null!;

    public string CsocMsg { get; set; } = null!;

    public string CmvrMsg { get; set; } = null!;

    public string EcldobMsg { get; set; } = null!;

    public string EclpkgMsg { get; set; } = null!;

    public string Eclwelcmsg { get; set; } = null!;

    public string Eclconfmsg { get; set; } = null!;

    public bool StrNmFrs { get; set; }

    public bool StrNmM1 { get; set; }

    public bool StrNmM2 { get; set; }

    public bool StrNmM9 { get; set; }

    public bool Emailnotif { get; set; }

    public bool PstNaFrz { get; set; }

    public string Rpclisubid { get; set; } = null!;

    public bool Post2Req { get; set; }

    public bool Lxstrucmvr { get; set; }

    public bool DmdefaCc { get; set; }

    public bool DmdefaWk { get; set; }

    public bool DmdefaVr { get; set; }

    public string CIntNote { get; set; } = null!;

    public bool CrtfeeExc { get; set; }

    public bool CrtfeeNot { get; set; }

    public string CrtfeeLst { get; set; } = null!;

    public bool Crmautoalr { get; set; }

    public bool Mvrautoalr { get; set; }

    public bool PstRfnas { get; set; }

    public bool PstCtyNa { get; set; }

    public string EclacMsg { get; set; } = null!;

    public bool EclDsXls { get; set; }

    public bool LxExtraid { get; set; }

    public string LxAdjudY { get; set; } = null!;

    public string LxAdjudN { get; set; } = null!;

    public bool SpecialC { get; set; }

    public bool Special2 { get; set; }

    public bool Special3 { get; set; }

    public bool Special4 { get; set; }

    public bool Special5 { get; set; }

    public bool LxSupname { get; set; }

    public bool LxSupssn { get; set; }

    public bool LxSupdob { get; set; }

    public bool PstAlBbd { get; set; }

    public bool PstAlNul { get; set; }

    public bool PstAlU21 { get; set; }

    public bool PstAlIss { get; set; }

    public bool PstAlTra { get; set; }

    public bool Pstautoalr { get; set; }

    public bool MvrDeFrz { get; set; }

    public bool PstAlEae { get; set; }

    public string Addendum { get; set; } = null!;

    public bool Adjprograd { get; set; }

    public string Pospiklist { get; set; } = null!;

    public bool Exglobwmsg { get; set; }

    public DateTime Firstfildt { get; set; }

    public bool Noremcntys { get; set; }

    public string Crimassign { get; set; } = null!;

    public bool Addverb { get; set; }

    public string Addvrbpass { get; set; } = null!;

    public string Addvrbfail { get; set; } = null!;

    public bool MvrFlUnl { get; set; }

    public bool Web2ref { get; set; }

    public decimal ChrgAfees { get; set; }

    public decimal ChrgOfees { get; set; }

    public string Akadisptxt { get; set; } = null!;

    public decimal Emailclnt { get; set; }

    public decimal Forcepwchg { get; set; }

    public string Rsnlogfail { get; set; } = null!;

    public decimal Setnumfail { get; set; }

    public string Suspended { get; set; } = null!;

    public bool Usestrngpw { get; set; }

    public bool Usrchgpass { get; set; }

    public string Typpwcrypt { get; set; } = null!;

    public string RcCliId { get; set; } = null!;

    public string RcProfId { get; set; } = null!;

    public bool RmaskDln { get; set; }

    public decimal AkasOfees { get; set; }

    public bool Pstshowsum { get; set; }

    public bool Partsndall { get; set; }

    public bool Partalldet { get; set; }

    public bool LxSexrace { get; set; }

    public bool PstInccty { get; set; }

    public bool AdjprodSt { get; set; }

    public string LxAdjudP { get; set; } = null!;

    public string Afflbltype { get; set; } = null!;

    public string Bifaxnum { get; set; } = null!;

    public bool NoComplet { get; set; }

    public bool FrzAdjpro { get; set; }

    public bool LxWebpart { get; set; }

    public bool PstCurasn { get; set; }

    public decimal Valpresuff { get; set; }

    public string Valnotes { get; set; } = null!;

    public decimal SriDest { get; set; }

    public decimal SriSend { get; set; }

    public bool Confirmsri { get; set; }

    public bool Confirmaka { get; set; }

    public bool Freezesri { get; set; }

    public bool Freezeaka { get; set; }

    public bool Csri2comnt { get; set; }

    public decimal Ccholddays { get; set; }

    public bool BkgRechk { get; set; }

    public bool BkgAuto { get; set; }

    public decimal BkgTiming { get; set; }

    public decimal BkgIncr { get; set; }

    public string BkgCemail { get; set; } = null!;

    public bool BkgPasst { get; set; }

    public bool BkgStwide { get; set; }

    public string BkgMsg { get; set; } = null!;

    public decimal BkgDeliv { get; set; }

    public string BkgOemail { get; set; } = null!;

    public decimal Bkgautoday { get; set; }

    public DateTime Bkgnextdt { get; set; }

    public bool LxConfirm { get; set; }

    public bool Ccautopay { get; set; }

    public DateTime Ccexpnotif { get; set; }

    public bool CreditFrz { get; set; }

    public bool SocialFrz { get; set; }

    public bool Sriweb2cmt { get; set; }

    public bool PstCurfed { get; set; }

    public string Prtyclient { get; set; } = null!;

    public int Id { get; set; }
}
