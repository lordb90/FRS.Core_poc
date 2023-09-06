using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Crimlink
{
    public string Desc { get; set; } = null!;

    public string Link { get; set; } = null!;

    public int Id { get; set; }
}
