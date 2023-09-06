using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Eclresult
{
    public decimal Key { get; set; }

    public decimal Whichres { get; set; }

    public bool PrSupplem { get; set; }

    public string DlxCharge { get; set; } = null!;

    public string Resultinfo { get; set; } = null!;

    public string AdjudRes { get; set; } = null!;

    public bool Statecover { get; set; }

    public string StateText { get; set; } = null!;

    public string FullDiscl { get; set; } = null!;

    public bool DailyInv { get; set; }

    public string InvDat { get; set; } = null!;

    public DateTime PostDtime { get; set; }

    public string ExtraInfo { get; set; } = null!;

    public int Id { get; set; }
}
