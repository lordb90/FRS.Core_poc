using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Cinst
{
    public string CompCode { get; set; } = null!;

    public string CompName { get; set; } = null!;

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

    public decimal PstCtyasn { get; set; }

    public decimal PstCtynbr { get; set; }

    public decimal PstCtyyrs { get; set; }

    public decimal PstCtysrc { get; set; }

    public string PstFooter { get; set; } = null!;

    public bool PstAlAka { get; set; }

    public bool PstAlSsn { get; set; }

    public bool PstAlDob { get; set; }

    public bool PstAlDod { get; set; }

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

    public string PatNoRec { get; set; } = null!;

    public string PatYesrec { get; set; } = null!;

    public string Gclogoname { get; set; } = null!;

    public string RrptComp { get; set; } = null!;

    public string Rrpt1addr { get; set; } = null!;

    public string Rrpt2addr { get; set; } = null!;

    public string Rrpt3addr { get; set; } = null!;

    public string Rrpt4addr { get; set; } = null!;

    public bool AltLetter { get; set; }

    public bool RsupprSsn { get; set; }

    public bool RsupprDob { get; set; }

    public string StiUserid { get; set; } = null!;

    public string StiUsercd { get; set; } = null!;

    public string StiPasswd { get; set; } = null!;

    public string Stica2ndpw { get; set; } = null!;

    public bool LicAffil { get; set; }

    public bool StrNmM1 { get; set; }

    public bool StrNmM2 { get; set; }

    public bool StrNmM9 { get; set; }

    public string Hlsexpress { get; set; } = null!;

    public string Nwexpress { get; set; } = null!;

    public string Sorexpress { get; set; } = null!;

    public string Hsexpress { get; set; } = null!;

    public string AcctNbr { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public bool SpecialC { get; set; }

    public string VoicePhon { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public bool Crmautoalr { get; set; }

    public bool Mvrautoalr { get; set; }

    public bool PstRfnas { get; set; }

    public string CliState { get; set; } = null!;

    public string Pospiklist { get; set; } = null!;

    public decimal ChrgCfees { get; set; }

    public decimal ChrgMvrfe { get; set; }

    public string Billcode { get; set; } = null!;

    public bool CrtfeeExc { get; set; }

    public bool CrtfeeNot { get; set; }

    public string CrtfeeLst { get; set; } = null!;

    public string Itembltype { get; set; } = null!;

    public string BillType { get; set; } = null!;

    public bool MvrFlUnl { get; set; }

    public string RcCliId { get; set; } = null!;

    public string RcProfId { get; set; } = null!;

    public bool RmaskDln { get; set; }

    public decimal ChrgAfees { get; set; }

    public decimal ChrgOfees { get; set; }

    public decimal AkasOfees { get; set; }

    public bool PstCtyNa { get; set; }

    public string Altverbred { get; set; } = null!;

    public string Altverbylw { get; set; } = null!;

    public string Altverbgrn { get; set; } = null!;

    public string Altverbgry { get; set; } = null!;

    public string Altverbwht { get; set; } = null!;

    public decimal Adverrange { get; set; }

    public string Advactlogo { get; set; } = null!;

    public string Advactadr1 { get; set; } = null!;

    public string Advactadr2 { get; set; } = null!;

    public string Advactadr3 { get; set; } = null!;

    public string Advactadr4 { get; set; } = null!;

    public string Advactnme { get; set; } = null!;

    public string Advactfeml { get; set; } = null!;

    public bool LogoSet { get; set; }

    public decimal WebPurge { get; set; }

    public bool Wbpurgifvw { get; set; }

    public decimal Webmov2arc { get; set; }

    public bool Webmovifvw { get; set; }

    public decimal Wbpurgarc { get; set; }

    public bool Wbpurarcvw { get; set; }

    public decimal AltLtrhd { get; set; }

    public string Afflbltype { get; set; } = null!;

    public string Drugpkgs { get; set; } = null!;

    public decimal Wkncostemp { get; set; }

    public decimal Wkncostcur { get; set; }

    public decimal Wkncostpre { get; set; }

    public decimal Wknaddcost { get; set; }

    public decimal Wkndeflmth { get; set; }

    public decimal Wknglobcli { get; set; }

    public string Scorecard { get; set; } = null!;

    public bool Pstnotlst4 { get; set; }

    public string I3pkgs { get; set; } = null!;

    public string Coocaption { get; set; } = null!;

    public string Cootext { get; set; } = null!;

    public string Co2caption { get; set; } = null!;

    public string Co2text { get; set; } = null!;

    public string MvrCUser { get; set; } = null!;

    public string MvrCAcct { get; set; } = null!;

    public string MvrCPass { get; set; } = null!;

    public string StiPacode { get; set; } = null!;

    public int Id { get; set; }
}
