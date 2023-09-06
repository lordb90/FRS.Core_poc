using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Lpbacku4
{
    public decimal Key { get; set; }

    public string SsnRes { get; set; } = null!;

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public int Id { get; set; }
}
