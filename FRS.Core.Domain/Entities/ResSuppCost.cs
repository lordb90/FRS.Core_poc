using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ResSuppCost
{
    public string ResCode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Cost { get; set; }

    public int Id { get; set; }
}
