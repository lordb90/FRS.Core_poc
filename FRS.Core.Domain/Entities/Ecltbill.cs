using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Ecltbill
{
    public string CompCode { get; set; } = null!;

    public string Group { get; set; } = null!;

    public string Mstrgroup { get; set; } = null!;

    public string MasterInv { get; set; } = null!;

    public string Invnum { get; set; } = null!;

    public DateTime InvDate { get; set; }

    public DateTime DueDate { get; set; }

    public decimal Invamt { get; set; }

    public string InvPdf { get; set; } = null!;

    public string BlistPdf { get; set; } = null!;

    public string NbrSearch { get; set; } = null!;

    public string Workdates { get; set; } = null!;

    public string Viewed { get; set; } = null!;

    public bool Sent2web { get; set; }

    public DateTime Dtsent { get; set; }

    public bool ToRemove { get; set; }

    public string Remfromweb { get; set; } = null!;

    public string Remusrname { get; set; } = null!;

    public DateTime Remdttime { get; set; }

    public bool Paid { get; set; }

    public DateTime PaidDt { get; set; }

    public decimal AmountDue { get; set; }

    public bool Reprintweb { get; set; }

    public int Id { get; set; }
}
