using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Globkey
{
    public string Keyname { get; set; } = null!;

    public string Keyvaluec { get; set; } = null!;

    public decimal Keyvaluen { get; set; }

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
