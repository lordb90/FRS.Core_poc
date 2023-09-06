using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Lpbacku2
{
    public decimal Key { get; set; }

    public string CredRes { get; set; } = null!;

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public string ExtraInfo { get; set; } = null!;

    public bool EiComprsd { get; set; }

    public int EiUncmpsz { get; set; }

    public int Id { get; set; }
}
