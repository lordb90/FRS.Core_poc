using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Holiday
{
    public DateTime Holidate { get; set; }

    public string Desc { get; set; } = null!;

    public int Id { get; set; }
}
