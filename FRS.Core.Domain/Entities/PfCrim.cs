using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfCrim
{
    public decimal Key { get; set; }

    public string Crstatus { get; set; } = null!;

    public string Crstate { get; set; } = null!;

    public string County { get; set; } = null!;

    public DateTime ArrDate { get; set; }

    public DateTime FileDate { get; set; }

    public string Case { get; set; } = null!;

    public string Charge { get; set; } = null!;

    public DateTime DispDate { get; set; }

    public string Disp { get; set; } = null!;

    public string Court { get; set; } = null!;

    public string MatchDesc { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string Shortname { get; set; } = null!;

    public string SrchCrit { get; set; } = null!;

    public decimal Yesrectype { get; set; }

    public string CmcvFlag { get; set; } = null!;

    public bool SrchFel { get; set; }

    public bool SrchMisd { get; set; }

    public bool SrchFed { get; set; }

    public bool SrchUc { get; set; }

    public bool SrchLc { get; set; }

    public bool SrchOth { get; set; }

    public string OthDesc { get; set; } = null!;

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public string Csrchinstr { get; set; } = null!;

    public decimal Eorder { get; set; }

    public bool NoPay { get; set; }

    public string NoPayreas { get; set; } = null!;

    public decimal Numcount { get; set; }

    public bool RecReview { get; set; }

    public bool Faxhithere { get; set; }

    public bool IcSkip { get; set; }

    public bool Sriconfirm { get; set; }

    public bool Akaconfirm { get; set; }

    public string IntNotes { get; set; } = null!;

    public DateTime Eta { get; set; }

    public string CountData { get; set; } = null!;

    public int PfKey { get; set; }

    public string Orgcase { get; set; } = null!;
}
