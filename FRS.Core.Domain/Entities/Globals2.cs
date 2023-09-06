using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Globals2
{
    public string Rpdcmpyid { get; set; } = null!;

    public bool FrzRpdref { get; set; }

    public bool Disablerpd { get; set; }

    public string Rpdrefost { get; set; } = null!;

    public string Alt15name { get; set; } = null!;

    public bool FrzI3scrn { get; set; }

    public string I3scrnost { get; set; } = null!;

    public bool Suprdobemp { get; set; }

    public bool Suprdobedu { get; set; }

    public bool Suprdobpli { get; set; }

    public string Stipasword { get; set; } = null!;

    public DateTime Stipasdate { get; set; }

    public bool Prevdisput { get; set; }

    public string Sti2016 { get; set; } = null!;

    public string EmlRaVer { get; set; } = null!;

    public string Piipurgeis { get; set; } = null!;

    public bool Piidopurge { get; set; }

    public bool Maskssnrep { get; set; }

    public string Cltemlsubj { get; set; } = null!;

    public string Cltemlbody { get; set; } = null!;

    public string Settings { get; set; } = null!;

    public string MvrCUser { get; set; } = null!;

    public string MvrCAcct { get; set; } = null!;

    public string MvrCPass { get; set; } = null!;

    public string MvrCUrl { get; set; } = null!;

    public DateTime MvrCDate { get; set; }

    public bool Premiumdlx { get; set; }

    public string Ltr613F1 { get; set; } = null!;

    public string Ltr613esub { get; set; } = null!;

    public string Ltr613ost { get; set; } = null!;

    public string Ltr613logo { get; set; } = null!;

    public string Ltr613nme { get; set; } = null!;

    public string Ltr613adr1 { get; set; } = null!;

    public string Ltr613adr2 { get; set; } = null!;

    public string Ltr613adr3 { get; set; } = null!;

    public string Ltr613adr4 { get; set; } = null!;

    public bool Prntfrndly { get; set; }

    public string Emlnewcli { get; set; } = null!;

    public bool Blmloreord { get; set; }

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
