using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfPlicNoIdentity
{
    public decimal Key { get; set; }

    public string ResName { get; set; } = null!;

    public DateTime ResDate { get; set; }

    public string LicType { get; set; } = null!;

    public string LicState { get; set; } = null!;

    public string LicNbr { get; set; } = null!;

    public string IssueDate { get; set; } = null!;

    public string ContBoard { get; set; } = null!;

    public string Confirmby { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string BPhone { get; set; } = null!;

    public string BFax { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string LicName { get; set; } = null!;

    public string LicDate { get; set; } = null!;

    public string LicExpire { get; set; } = null!;

    public string Bcomments { get; set; } = null!;

    public string Rcomments { get; set; } = null!;

    public bool Complete { get; set; }

    public string AddInfo { get; set; } = null!;

    public bool Discrep { get; set; }

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public string IntNotes { get; set; } = null!;

    public string RecallDt { get; set; } = null!;

    public decimal RecallCnt { get; set; }

    public string RecalLast { get; set; } = null!;

    public DateTime Lastmodify { get; set; }

    public bool RecReview { get; set; }

    public bool Unabl2vrfy { get; set; }

    public int PfKey { get; set; }
}
