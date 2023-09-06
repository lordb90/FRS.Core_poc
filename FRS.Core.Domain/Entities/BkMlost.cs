using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BkMlost
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

    public decimal RecallCnt { get; set; }

    public string RecallDt { get; set; } = null!;

    public string RecalLast { get; set; } = null!;

    public bool RefFlag { get; set; }

    public string FmtSrcrit { get; set; } = null!;

    public string FmtXtra { get; set; } = null!;

    public bool Mlodiscrep { get; set; }

    public string OrigRes { get; set; } = null!;

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public bool InoteComp { get; set; }

    public int InoteUcsz { get; set; }

    public bool OresComp { get; set; }

    public int OresUcsz { get; set; }

    public string Tntresults { get; set; } = null!;

    public int Id { get; set; }
}
