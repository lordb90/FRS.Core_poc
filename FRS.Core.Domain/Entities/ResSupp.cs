using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ResSupp
{
    public decimal Key { get; set; }

    public string SubjName { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string ResCode { get; set; } = null!;

    public DateTime ResWhen { get; set; }

    public string Aka { get; set; } = null!;

    public int Id { get; set; }
}
