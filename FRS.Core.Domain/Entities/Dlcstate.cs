using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Dlcstate
{
    public string CompCode { get; set; } = null!;

    public string State { get; set; } = null!;

    public decimal NbrYears { get; set; }

    public string Vendor { get; set; } = null!;

    public int Id { get; set; }
}
