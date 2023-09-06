using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Retryrlk
{
    public string Ctable { get; set; } = null!;

    public decimal Recnum { get; set; }

    public string Code2exec { get; set; } = null!;

    public decimal Attempts { get; set; }

    public string Verify { get; set; } = null!;

    public int Id { get; set; }
}
