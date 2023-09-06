using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Resnoset
{
    public string Fullname { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal Device { get; set; }

    public bool FullyComp { get; set; }

    public DateTime RecDate { get; set; }

    public string RecTime { get; set; } = null!;

    public DateTime DelDate { get; set; }

    public string DelTime { get; set; } = null!;

    public string DelId { get; set; } = null!;

    public bool PrntIt { get; set; }

    public bool FaxIt { get; set; }

    public bool WebIt { get; set; }

    public bool EmailIt { get; set; }

    public int Id { get; set; }
}
