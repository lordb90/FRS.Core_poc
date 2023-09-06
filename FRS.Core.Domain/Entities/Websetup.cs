using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Websetup
{
    public decimal WrgOrMan { get; set; }

    public decimal ReqAuto { get; set; }

    public bool AddExsum { get; set; }

    public decimal PostMvr { get; set; }

    public decimal PostCred { get; set; }

    public decimal PostSsn { get; set; }

    public string InfoMsg { get; set; } = null!;

    public string CrimMsg { get; set; } = null!;

    public decimal WpdfSize { get; set; }

    public decimal WpdfCnt { get; set; }

    public decimal WdataSize { get; set; }

    public decimal WdataCnt { get; set; }

    public decimal ReqCount { get; set; }

    public decimal MaintTime { get; set; }

    public bool OscFm { get; set; }

    public bool OscFel { get; set; }

    public bool OscMisd { get; set; }

    public bool OscFed { get; set; }

    public bool OscUlc { get; set; }

    public bool OscUc { get; set; }

    public bool OscLc { get; set; }

    public string OsMain { get; set; } = null!;

    public decimal DispAlert { get; set; }

    public decimal VntProof { get; set; }

    public decimal VcloseOut { get; set; }

    public bool VntUcase { get; set; }

    public decimal VntCrtlat { get; set; }

    public decimal VntVerlat { get; set; }

    public decimal VnpdfSize { get; set; }

    public decimal VnpdfCnt { get; set; }

    public decimal VndataSiz { get; set; }

    public decimal VnCrtcnt { get; set; }

    public decimal VnVercnt { get; set; }

    public decimal VnTotcnt { get; set; }

    public decimal VnrptOver { get; set; }

    public decimal VnrptAssn { get; set; }

    public decimal VnrptBpa { get; set; }

    public DateTime Vnrgenover { get; set; }

    public DateTime Vnrgenassn { get; set; }

    public DateTime VnrgenBpa { get; set; }

    public string Vnemailcrt { get; set; } = null!;

    public string Vnemailver { get; set; } = null!;

    public bool AlSubject { get; set; }

    public bool AlDups { get; set; }

    public bool AlCounty { get; set; }

    public bool AlDrivers { get; set; }

    public bool Al1Perpg { get; set; }

    public bool VnhumCrt { get; set; }

    public bool VnhumVer { get; set; }

    public decimal VsendSsn { get; set; }

    public decimal VsendAddr { get; set; }

    public string CourtDesc { get; set; } = null!;

    public string HomePage { get; set; } = null!;

    public string InfoEmail { get; set; } = null!;

    public string AlertDesc { get; set; } = null!;

    public bool MvrexprCa { get; set; }

    public bool Ph5Afthrs { get; set; }

    public bool FrzIadd { get; set; }

    public string DlxhitMsg { get; set; } = null!;

    public bool Instntcomp { get; set; }

    public string MvrhitMsg { get; set; } = null!;

    public bool Mvrhitfltr { get; set; }

    public bool MyctyList { get; set; }

    public string SignupSet { get; set; } = null!;

    public string Signupintr { get; set; } = null!;

    public string Signupterm { get; set; } = null!;

    public string Signupdisc { get; set; } = null!;

    public string Suformpage { get; set; } = null!;

    public string SuformTit { get; set; } = null!;

    public string SuformMsg { get; set; } = null!;

    public bool Suformadob { get; set; }

    public string Suformfoot { get; set; } = null!;

    public string Smtpserver { get; set; } = null!;

    public bool SuppresSu { get; set; }

    public bool SuppresCf { get; set; }

    public bool Frzvnetsri { get; set; }

    public string Formslink { get; set; } = null!;

    public string Loginwelcm { get; set; } = null!;

    public string ExpMvr { get; set; } = null!;

    public string ExpSsn { get; set; } = null!;

    public string ExpNation { get; set; } = null!;

    public string ExpSor { get; set; } = null!;

    public string ExpHls { get; set; } = null!;

    public string ExpHcs { get; set; } = null!;

    public string ExpAlign { get; set; } = null!;

    public string Escrnid { get; set; } = null!;

    public string Escrnlogin { get; set; } = null!;

    public string Escrnpswd { get; set; } = null!;

    public string Nofrzkeywd { get; set; } = null!;

    public bool Exactkeywd { get; set; }

    public string MvrexprNo { get; set; } = null!;

    public string I3userid { get; set; } = null!;

    public string I3pwd { get; set; } = null!;

    public int Id { get; set; }
}
