using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vnattach
{
    public decimal Key { get; set; }

    public decimal Weborder { get; set; }

    public string WebStat { get; set; } = null!;

    public string Descriptn { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int Id { get; set; }
}
