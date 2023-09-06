using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfMvrNoIdentity
{
    public decimal Key { get; set; }

    public string Dlnum { get; set; } = null!;

    public string Dlstate { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public string Dlflag { get; set; } = null!;

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public string ShortSumm { get; set; } = null!;

    public decimal NbrYears { get; set; }

    public decimal MvrPflag { get; set; }

    public string LxstruRes { get; set; } = null!;

    public string Vendor { get; set; } = null!;

    public int PfKey { get; set; }
}
