using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Billcode
{
    public string Billcode1 { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public decimal Order { get; set; }

    public decimal Price { get; set; }

    public string Inactive { get; set; } = null!;

    public int Id { get; set; }
}
