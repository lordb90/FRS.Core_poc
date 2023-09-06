using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Chnatstu
{
    public string SchName { get; set; } = null!;

    public string SchCode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public DateTime Activation { get; set; }

    public decimal Feesretail { get; set; }

    public decimal Feescolleg { get; set; }

    public string Match { get; set; } = null!;

    public string Campus { get; set; } = null!;

    public string Frscity { get; set; } = null!;

    public string Frsstate { get; set; } = null!;

    public string Snameclean { get; set; } = null!;

    public decimal VerNum { get; set; }

    public int Id { get; set; }
}
