using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vmtchlog
{
    public decimal Weborder { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Details { get; set; } = null!;

    public int Id { get; set; }
}
