using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Recsubj
{
    public string Userid { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public decimal SubjKey { get; set; }

    public DateTime Lastmodify { get; set; }

    public int Id { get; set; }
}
