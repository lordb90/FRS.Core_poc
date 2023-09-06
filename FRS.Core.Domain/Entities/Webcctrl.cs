using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webcctrl
{
    public string Searchtype { get; set; } = null!;

    public string Crit { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public decimal Order { get; set; }

    public string DlxProd { get; set; } = null!;

    public int Id { get; set; }
}
