using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webhisto
{
    public decimal Key { get; set; }

    public DateTime SendDate { get; set; }

    public string SendTime { get; set; } = null!;

    public string Pdf { get; set; } = null!;

    public DateTime FirstDate { get; set; }

    public string Partial { get; set; } = null!;

    public string AtWeb { get; set; } = null!;

    public int Id { get; set; }
}
