using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class DelPf
{
    public DateTime Lastmodify { get; set; }

    public decimal PfRec { get; set; }

    public string Desc { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Id { get; set; }
}
