using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Company2
{
    public string CompCode { get; set; } = null!;

    public bool EmlMulti { get; set; }

    public string Adjwksheet { get; set; } = null!;

    public bool ApIncpend { get; set; }

    public bool ApEmredgr { get; set; }

    public bool ApErgygw1 { get; set; }

    public bool ApErgygw2 { get; set; }

    public bool ApUseaeml { get; set; }

    public string ApAltemlr { get; set; } = null!;

    public bool ApStndmsg { get; set; }

    public string Altverbred { get; set; } = null!;

    public string Altverbylw { get; set; } = null!;

    public string Altverbgrn { get; set; } = null!;

    public string Altverbgry { get; set; } = null!;

    public string Altverbwht { get; set; } = null!;

    public string LxAdjudS { get; set; } = null!;

    public string LxAdjudD { get; set; } = null!;

    public bool Covshtres { get; set; }

    public string Faxcovres { get; set; } = null!;

    public bool Setoverall { get; set; }

    public bool AdjuFcomp { get; set; }

    public bool OdNoblank { get; set; }

    public decimal Adverrange { get; set; }

    public string Advactlogo { get; set; } = null!;

    public string Advactadr1 { get; set; } = null!;

    public string Advactadr2 { get; set; } = null!;

    public string Advactadr3 { get; set; } = null!;

    public string Advactadr4 { get; set; } = null!;

    public string Advactnme { get; set; } = null!;

    public string Advactfeml { get; set; } = null!;

    public bool LogoSet { get; set; }

    public string Advactdelm { get; set; } = null!;

    public string Advtextpre { get; set; } = null!;

    public string Advtextpst { get; set; } = null!;

    public bool Advusepre { get; set; }

    public bool Advusepst { get; set; }

    public bool Wbpurgifvw { get; set; }

    public decimal Webmov2arc { get; set; }

    public bool Webmovifvw { get; set; }

    public decimal Wbpurgarc { get; set; }

    public bool Wbpurarcvw { get; set; }

    public string Drugpkgs { get; set; } = null!;

    public decimal Wknglobcli { get; set; }

    public string Wknsetup { get; set; } = null!;

    public bool Wbdsusehst { get; set; }

    public decimal SalesTax { get; set; }

    public bool Taxsupchrg { get; set; }

    public decimal ApFeeamt { get; set; }

    public string ApFeedesc { get; set; } = null!;

    public bool Emladdref { get; set; }

    public bool Agenexcel { get; set; }

    public bool Emailexcel { get; set; }

    public bool Trnsfeeadd { get; set; }

    public decimal Trnsfeeamt { get; set; }

    public bool Amcfeeadd { get; set; }

    public decimal Amcfeeamt { get; set; }

    public string Frzusers { get; set; } = null!;

    public bool Frzrstrct { get; set; }

    public string Altfromeml { get; set; } = null!;

    public bool Nobillist { get; set; }

    public decimal Pmtprocfee { get; set; }

    public bool Emlapplcnt { get; set; }

    public bool Emailpass { get; set; }

    public string AcctEml { get; set; } = null!;

    public bool Emlfrmamgr { get; set; }

    public string Scorecard { get; set; } = null!;

    public bool Tenantscrn { get; set; }

    public bool Showcrdrep { get; set; }

    public bool WdsUserng { get; set; }

    public decimal WdsBegmth { get; set; }

    public decimal WdsBegday { get; set; }

    public decimal WdsEndmth { get; set; }

    public decimal WdsEndday { get; set; }

    public bool Frzmultjur { get; set; }

    public DateTime WdsBegdte { get; set; }

    public DateTime WdsEnddte { get; set; }

    public string Yesreceml { get; set; } = null!;

    public bool LxFrzdups { get; set; }

    public bool Pstnotlst4 { get; set; }

    public decimal ProofOver { get; set; }

    public bool Lxreqnotor { get; set; }

    public bool Frreqnotor { get; set; }

    public bool Wbreqnotor { get; set; }

    public bool Inreqnotor { get; set; }

    public bool Enotifcltr { get; set; }

    public string Enotifemls { get; set; } = null!;

    public bool ApNopend { get; set; }

    public bool ApNeedsri { get; set; }

    public bool Dontdelay { get; set; }

    public bool Remindcand { get; set; }

    public string Rmdhdrtxt { get; set; } = null!;

    public string Rmdbdytxt { get; set; } = null!;

    public bool AdjuNofrz { get; set; }

    public bool Nofrzinst { get; set; }

    public bool DotRegula { get; set; }

    public decimal Hits2send { get; set; }

    public bool PstCivupp { get; set; }

    public bool PstCivlow { get; set; }

    public bool Cltrxchrg { get; set; }

    public bool Noctygroup { get; set; }

    public bool Sortbycnty { get; set; }

    public bool Genrandpwd { get; set; }

    public bool PstFulsta { get; set; }

    public bool Frz18lxml { get; set; }

    public bool Frz18web { get; set; }

    public bool Frz18manl { get; set; }

    public bool Frz18cstm { get; set; }

    public string Coocaption { get; set; } = null!;

    public string Cootext { get; set; } = null!;

    public string IntTrk1 { get; set; } = null!;

    public string IntTrk2 { get; set; } = null!;

    public string IntTrk3 { get; set; } = null!;

    public string IntTrk4 { get; set; } = null!;

    public string IntTrk5 { get; set; } = null!;

    public string PdfPswd { get; set; } = null!;

    public string Settings { get; set; } = null!;

    public bool Frzakaweb { get; set; }

    public string Co2text { get; set; } = null!;

    public string Co2caption { get; set; } = null!;

    public bool LxPkgAdd { get; set; }

    public bool LxPkgRem { get; set; }

    public string StiPacode { get; set; } = null!;

    public decimal Amcpurge { get; set; }

    public bool PstCtytoo { get; set; }

    public string FaxNumber { get; set; } = null!;

    public string Current { get; set; } = null!;

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
