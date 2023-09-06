using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Wfjready
{
    public decimal Key { get; set; }

    public decimal RrType { get; set; }

    public string CompCode { get; set; } = null!;

    public bool IncCred { get; set; }

    public bool IncSsn { get; set; }

    public bool IncMvr { get; set; }

    public bool WfjPrint { get; set; }

    public int Id { get; set; }
}
