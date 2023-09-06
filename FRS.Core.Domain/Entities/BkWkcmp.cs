using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BkWkcmp
{
    public decimal Key { get; set; }

    public string Wcstate { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public int Id { get; set; }
}
