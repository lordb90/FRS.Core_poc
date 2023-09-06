using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class International
{
    public string Country { get; set; } = null!;

    public string Atweb { get; set; } = null!;

    public string IntSri { get; set; } = null!;

    public int Id { get; set; }
}
