using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Blcdcom2
{
    public string CompCode { get; set; } = null!;

    public string Itemtype { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public decimal Price { get; set; }

    public int Id { get; set; }
}
