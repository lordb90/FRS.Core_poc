using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Deltrack
{
    public string Fullname { get; set; } = null!;

    public decimal Ssno { get; set; }

    public decimal Key { get; set; }

    public string Reference { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public DateTime RecDate { get; set; }

    public string RecTime { get; set; } = null!;

    public bool FullyComp { get; set; }

    public string KeySrc { get; set; } = null!;

    public string DelId { get; set; } = null!;

    public DateTime DelDate { get; set; }

    public string DelTime { get; set; } = null!;

    public DateTime DateSent { get; set; }

    public string TimeSent { get; set; } = null!;

    public string Wasweb { get; set; } = null!;

    public bool RetSsnver { get; set; }

    public int Id { get; set; }
}
