using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PrMvr
{
    public decimal Key { get; set; }

    public string Lname { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public DateTime RecDate { get; set; }

    public string RecTime { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Aka { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Dlflag { get; set; } = null!;

    public string Dlnum { get; set; } = null!;

    public string Dlstate { get; set; } = null!;

    public string ResStat { get; set; } = null!;

    public string ResCode { get; set; } = null!;

    public string ResName { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string Snapshot { get; set; } = null!;

    public DateTime CompDate { get; set; }

    public string CompTime { get; set; } = null!;

    public decimal Turnaround { get; set; }

    public string Reviewed { get; set; } = null!;

    public string DispInfo { get; set; } = null!;

    public bool Selected { get; set; }

    public DateTime Lastupdate { get; set; }

    public string Freeze { get; set; } = null!;

    public decimal HomeKey7 { get; set; }

    public decimal HomeKey8 { get; set; }

    public string Status { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string IntTrk1 { get; set; } = null!;

    public string IntTrk2 { get; set; } = null!;

    public string IntTrk3 { get; set; } = null!;

    public string IntTrk4 { get; set; } = null!;

    public string IntTrk5 { get; set; } = null!;

    public string IntId { get; set; } = null!;
}
