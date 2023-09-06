using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IcmreqQ
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string Cmcv { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public string SrcCrit { get; set; } = null!;

    public bool Partial { get; set; }

    public string FlgSpecin { get; set; } = null!;

    public string SpecInstr { get; set; } = null!;

    public bool ReqAcct { get; set; }

    public bool ReqCc { get; set; }

    public decimal SrcNmatch { get; set; }

    public decimal SrcNchars { get; set; }

    public decimal SrcMiddle { get; set; }

    public decimal SrcDobval { get; set; }

    public decimal SrcDobpm { get; set; }

    public decimal SrcYrsret { get; set; }

    public bool SrcArrFd { get; set; }

    public bool SrcFreeze { get; set; }

    public decimal SrcDelay { get; set; }

    public bool SrcWkend { get; set; }

    public string CtyToSnd { get; set; } = null!;

    public bool MultiPass { get; set; }

    public string SiteId { get; set; } = null!;

    public string Transid { get; set; } = null!;

    public string Namefirst { get; set; } = null!;

    public string Namemiddle { get; set; } = null!;

    public string Namelast { get; set; } = null!;

    public string Namesuffix { get; set; } = null!;

    public string Aka { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Dobyear { get; set; } = null!;

    public string Dobmonth { get; set; } = null!;

    public string Dobday { get; set; } = null!;

    public string Billngcode { get; set; } = null!;

    public string Queryid { get; set; } = null!;

    public string WsAcct { get; set; } = null!;

    public string WsUserid { get; set; } = null!;

    public string WsPass { get; set; } = null!;

    public string CcExpire { get; set; } = null!;

    public string CcCode { get; set; } = null!;

    public string CcZip { get; set; } = null!;

    public DateTime Qdate { get; set; }

    public string Qtime { get; set; } = null!;

    public DateTime Senddate { get; set; }

    public string Sendtime { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Retrieved { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Ecode { get; set; } = null!;

    public decimal Receipt { get; set; }

    public string Srequest { get; set; } = null!;

    public string Response { get; set; } = null!;

    public string RespExtra { get; set; } = null!;

    public decimal NumAkas { get; set; }

    public decimal NbrHits { get; set; }

    public decimal Attempts { get; set; }

    public string AttHist { get; set; } = null!;

    public DateTime LastAtt { get; set; }

    public DateTime DelayComp { get; set; }

    public string IhrRun { get; set; } = null!;

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public int Id { get; set; }
}
