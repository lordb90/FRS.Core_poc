using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IcR
{
    public string State { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public DateTime Setup { get; set; }

    public int Id { get; set; }
}
