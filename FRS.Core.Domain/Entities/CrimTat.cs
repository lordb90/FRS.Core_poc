using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class CrimTat
{
    public decimal Key { get; set; }

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public decimal TatMins { get; set; }

    public DateTime TatAdded { get; set; }

    public decimal TatHrs { get; set; }

    public int Id { get; set; }
}
