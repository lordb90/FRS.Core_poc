using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ResList
{
    public string ResCode { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string ResName { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public string VoicePhon { get; set; } = null!;

    public decimal XmitMeth { get; set; }

    public bool AddFromC { get; set; }

    public bool AddOls { get; set; }

    public string OlsCode { get; set; } = null!;

    public decimal Slstyle { get; set; }

    public decimal Priority { get; set; }

    public string Notes { get; set; } = null!;

    public string Iemail { get; set; } = null!;

    public bool VnetRes { get; set; }

    public decimal VnetLogin { get; set; }

    public DateTime VnetLasta { get; set; }

    public string VnetLastu { get; set; } = null!;

    public decimal VnetCttot { get; set; }

    public decimal VnetVrtot { get; set; }

    public decimal VnetCtcur { get; set; }

    public decimal VnetVrcur { get; set; }

    public string VnetNotes { get; set; } = null!;

    public DateTime VnetNtpst { get; set; }

    public DateTime VnetNtclr { get; set; }

    public string Emailzippw { get; set; } = null!;

    public decimal PdfOrTxt { get; set; }

    public bool EmlComprs { get; set; }

    public string Current { get; set; } = null!;

    public bool WebEnotif { get; set; }

    public bool LxWebsv { get; set; }

    public string LxSiteid { get; set; } = null!;

    public decimal LxRrfmt { get; set; }

    public string LxLpath { get; set; } = null!;

    public bool LxEmnorec { get; set; }

    public bool LxEmnosnt { get; set; }

    public string LxEmladdr { get; set; } = null!;

    public string LxEmRmsg { get; set; } = null!;

    public string LxEmSmsg { get; set; } = null!;

    public string LxWsTodo { get; set; } = null!;

    public bool LxAddNew { get; set; }

    public string LxKwFrz { get; set; } = null!;

    public string OnetNotes { get; set; } = null!;

    public string OdtNotes { get; set; } = null!;

    public bool Slsupprssn { get; set; }

    public bool Covshtsrch { get; set; }

    public string Faxcovsrch { get; set; } = null!;

    public DateTime Lasttracer { get; set; }

    public int Id { get; set; }
}
