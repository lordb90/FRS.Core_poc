using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Supprtkt
{
    public string TktSite { get; set; } = null!;

    public string TktEncpw { get; set; } = null!;

    public string TktName { get; set; } = null!;

    public string TktEmail { get; set; } = null!;

    public string TktIssue { get; set; } = null!;

    public string TktNotes { get; set; } = null!;

    public string TktTime { get; set; } = null!;

    public DateTime TktDate { get; set; }

    public string TktStatus { get; set; } = null!;

    public decimal TktNum { get; set; }

    public string TktVernum { get; set; } = null!;

    public DateTime TktSent { get; set; }

    public string TktAttch1 { get; set; } = null!;

    public string TktUnqnm1 { get; set; } = null!;

    public string TktAttch2 { get; set; } = null!;

    public string TktUnqnm2 { get; set; } = null!;

    public string TktAttch3 { get; set; } = null!;

    public string TktUnqnm3 { get; set; } = null!;

    public decimal TktRetrys { get; set; }

    public int TktId { get; set; }
}
