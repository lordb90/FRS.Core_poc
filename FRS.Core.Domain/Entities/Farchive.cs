using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Farchive
{
    public string CompCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public decimal Ssno { get; set; }

    public DateTime RecDate { get; set; }

    public string RecFound { get; set; } = null!;

    public string State { get; set; } = null!;

    public DateTime ArchDate { get; set; }

    public int Id { get; set; }
}
