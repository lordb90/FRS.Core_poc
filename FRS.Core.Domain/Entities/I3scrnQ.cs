using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class I3scrnQ
{
    public decimal SubjKey { get; set; }

    public string Providrkey { get; set; } = null!;

    public int Id { get; set; }
}
