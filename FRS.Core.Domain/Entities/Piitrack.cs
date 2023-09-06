using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Piitrack
{
    public string UnqOrder { get; set; } = null!;

    public decimal Key { get; set; }

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public decimal Ssno { get; set; }

    public DateTime Entered { get; set; }

    public int Id { get; set; }
}
