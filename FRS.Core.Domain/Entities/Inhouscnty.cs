using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Inhouscnty
{
    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public int Id { get; set; }
}
