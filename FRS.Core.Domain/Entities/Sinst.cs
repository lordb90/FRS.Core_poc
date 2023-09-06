using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Sinst
{
    public string FrsUserid { get; set; } = null!;

    public string FrsPw { get; set; } = null!;

    public string StiUserid { get; set; } = null!;

    public string StiUsercd { get; set; } = null!;

    public string StiPw { get; set; } = null!;

    public string Stica2ndpw { get; set; } = null!;

    public string TrwEsubs { get; set; } = null!;

    public string TrwEsubpw { get; set; } = null!;

    public string TrwEpream { get; set; } = null!;

    public string TrwCsubs { get; set; } = null!;

    public string TrwCsubpw { get; set; } = null!;

    public string TrwCpream { get; set; } = null!;

    public string TrwSsubs { get; set; } = null!;

    public string TrwSsubpw { get; set; } = null!;

    public string TrwSpream { get; set; } = null!;

    public string TrwCredkw { get; set; } = null!;

    public string TrwSspp { get; set; } = null!;

    public decimal TrwCopykw { get; set; }

    public string TuMarket { get; set; } = null!;

    public string TuSubmark { get; set; } = null!;

    public string TuPicode { get; set; } = null!;

    public string TuPSubs { get; set; } = null!;

    public string TuPPw { get; set; } = null!;

    public string TuCicode { get; set; } = null!;

    public string TuCSubs { get; set; } = null!;

    public string TuCPw { get; set; } = null!;

    public string TuTicode { get; set; } = null!;

    public string TuTSubs { get; set; } = null!;

    public string TuTPw { get; set; } = null!;

    public string TuRicode { get; set; } = null!;

    public string TuRSubs { get; set; } = null!;

    public string TuRPw { get; set; } = null!;

    public bool TuFcrasup { get; set; }

    public string EqAcctp { get; set; } = null!;

    public string EqAcctc { get; set; } = null!;

    public string EqAcctid { get; set; } = null!;

    public string EqAcctdt { get; set; } = null!;

    public string EqPpurP { get; set; } = null!;

    public string EqPpurC { get; set; } = null!;

    public string EqPpurId { get; set; } = null!;

    public string EqPpurDt { get; set; } = null!;

    public bool EqFcrasup { get; set; }

    public string IctrwEmpi { get; set; } = null!;

    public string IctrwCred { get; set; } = null!;

    public string IctrwSoc { get; set; } = null!;

    public string IctuPeer { get; set; } = null!;

    public string IctuTrace { get; set; } = null!;

    public string IctuCred { get; set; } = null!;

    public string IctuRet { get; set; } = null!;

    public string IcequPers { get; set; } = null!;

    public string IcequCred { get; set; } = null!;

    public string IcequId { get; set; } = null!;

    public string IcequDtec { get; set; } = null!;

    public string DiscFhead { get; set; } = null!;

    public string DisclFull { get; set; } = null!;

    public string DlxhitMsg { get; set; } = null!;

    public bool Instntcomp { get; set; }

    public string MvrhitMsg { get; set; } = null!;

    public bool Mvrhitfltr { get; set; }

    public bool DiscCb1 { get; set; }

    public string Altunlname { get; set; } = null!;

    public bool ChrgAkas { get; set; }

    public bool MyverChwn { get; set; }

    public bool MyverChns { get; set; }

    public decimal ChwnExtra { get; set; }

    public decimal ChnsExtra { get; set; }

    public bool Nscaddrate { get; set; }

    public string CrimRptit { get; set; } = null!;

    public decimal ChwnExtr2 { get; set; }

    public decimal ChwnExtr3 { get; set; }

    public decimal Wkndeflglb { get; set; }

    public decimal NscRates { get; set; }

    public bool IcHtml { get; set; }

    public string Tenantost { get; set; } = null!;

    public string Sti2016 { get; set; } = null!;

    public bool Ssnsumonly { get; set; }

    public bool Premiumdlx { get; set; }

    public string MvrCUser { get; set; } = null!;

    public string MvrCAcct { get; set; } = null!;

    public string MvrCPass { get; set; } = null!;

    public string MvrCUrl { get; set; } = null!;

    public bool Prntfrndly { get; set; }

    public int Id { get; set; }
}
