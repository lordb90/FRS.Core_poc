using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Othstin
{
    public string Desc { get; set; } = null!;

    public string Instruct { get; set; } = null!;

    public DateTime LastMod { get; set; }

    public string WebForm { get; set; } = null!;

    public DateTime WebMod { get; set; }

    public int Id { get; set; }
}
