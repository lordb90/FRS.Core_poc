using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PrCrim
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

    public string Crstatus { get; set; } = null!;

    public string CmcvFlag { get; set; } = null!;

    public string Subprofile { get; set; } = null!;

    public string County { get; set; } = null!;

    public string Crstate { get; set; } = null!;

    public string ResStat { get; set; } = null!;

    public string ResName { get; set; } = null!;

    public string OthDesc { get; set; } = null!;

    public bool SrchMisd { get; set; }

    public bool SrchFel { get; set; }

    public bool SrchOth { get; set; }

    public bool SrchUc { get; set; }

    public bool SrchLc { get; set; }

    public string Snapshot { get; set; } = null!;

    public DateTime CompDate { get; set; }

    public string CompTime { get; set; } = null!;

    public decimal Turnaround { get; set; }

    public string Reviewed { get; set; } = null!;

    public string SrchInstr { get; set; } = null!;

    public string SrchInd { get; set; } = null!;

    public string DispInfo { get; set; } = null!;

    public bool Selected { get; set; }

    public bool RecReview { get; set; }

    public DateTime Lastupdate { get; set; }

    public string Freeze { get; set; } = null!;

    public decimal HomeKey7 { get; set; }

    public decimal HomeKey8 { get; set; }

    public decimal Numrecs { get; set; }

    public string SrchCrit { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Csrchinstr { get; set; } = null!;

    public string City { get; set; } = null!;

    public string IntTrk1 { get; set; } = null!;

    public string IntTrk2 { get; set; } = null!;

    public string IntTrk3 { get; set; } = null!;

    public string IntTrk4 { get; set; } = null!;

    public string IntTrk5 { get; set; } = null!;

    public string IntId { get; set; } = null!;
}
