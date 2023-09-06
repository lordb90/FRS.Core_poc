using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfMlostNoIdentity
{
    public decimal Key { get; set; }

    public string OstDesc { get; set; } = null!;

    public string OsrchCrit { get; set; } = null!;

    public string Oresults { get; set; } = null!;

    public bool Complete { get; set; }

    public bool Print { get; set; }

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public decimal Eorder { get; set; }

    public string IntNotes { get; set; } = null!;

    public string RecallDt { get; set; } = null!;

    public decimal RecallCnt { get; set; }

    public string RecalLast { get; set; } = null!;

    public DateTime Lastmodify { get; set; }

    public bool RefFlag { get; set; }

    public string FmtSrcrit { get; set; } = null!;

    public bool RecReview { get; set; }

    public string FmtXtra { get; set; } = null!;

    public bool Mlodiscrep { get; set; }

    public string OrigRes { get; set; } = null!;

    public bool DlinxRetr { get; set; }

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public bool InoteComp { get; set; }

    public int InoteUcsz { get; set; }

    public DateTime Advdt2gen { get; set; }

    public int PfKey { get; set; }

    public decimal Grossalary { get; set; }

    public decimal Rentamount { get; set; }

    public bool Verifyinc { get; set; }

    public string Tntresults { get; set; } = null!;

    public bool NoCharge { get; set; }
}
