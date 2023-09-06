using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Othstfrm
{
    public string Desc { get; set; } = null!;

    public string Form { get; set; } = null!;

    public DateTime LastMod { get; set; }

    public int Id { get; set; }
}
