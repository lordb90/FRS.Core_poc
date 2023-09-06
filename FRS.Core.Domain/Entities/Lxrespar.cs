using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Lxrespar
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Time { get; set; } = null!;

    public string DiscrNote { get; set; } = null!;

    public int Id { get; set; }
}
