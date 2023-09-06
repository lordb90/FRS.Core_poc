using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Reshist
{
    public string CompCode { get; set; } = null!;

    public DateTime RhDate { get; set; }

    public string RhTime { get; set; } = null!;

    public string Device { get; set; } = null!;

    public decimal NumNames { get; set; }

    public string Namelist { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Resend { get; set; } = null!;

    public int Id { get; set; }
}
