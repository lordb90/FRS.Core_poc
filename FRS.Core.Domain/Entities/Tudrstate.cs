using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrstate
{
    public string State { get; set; } = null!;

    public string Statelong { get; set; } = null!;

    public decimal Lookback { get; set; }

    public int Id { get; set; }
}
