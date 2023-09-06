using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Extracst
{
    public string Desc { get; set; } = null!;

    public decimal Amount { get; set; }

    public int Id { get; set; }
}
