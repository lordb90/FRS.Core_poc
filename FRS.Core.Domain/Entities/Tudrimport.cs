using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrimport
{
    public string CompCode { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public string Dlnum { get; set; } = null!;

    public string Dlstate { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Gender { get; set; } = null!;

    public string PresAddr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public decimal Ssno { get; set; }

    public DateTime MntrStart { get; set; }

    public DateTime MntrEnd { get; set; }

    public int Id { get; set; }
}
