using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Othdlinx
{
    public string Desc { get; set; } = null!;

    public string NoRecord { get; set; } = null!;

    public string YesRecord { get; set; } = null!;

    public int Id { get; set; }
}
