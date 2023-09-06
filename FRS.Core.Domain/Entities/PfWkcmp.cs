using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfWkcmp
{
    public decimal Key { get; set; }

    public string Wcstate { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public int PfKey { get; set; }
}
