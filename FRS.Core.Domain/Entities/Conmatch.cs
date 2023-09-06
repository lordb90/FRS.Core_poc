using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Conmatch
{
    public string CompCode { get; set; } = null!;

    public string FcId { get; set; } = null!;

    public bool Call { get; set; }

    public string ModemNbr { get; set; } = null!;

    public string TSitename { get; set; } = null!;

    public decimal Fusercalls { get; set; }

    public decimal AvgCall { get; set; }

    public DateTime LastCall { get; set; }

    public string Status { get; set; } = null!;

    public int Id { get; set; }
}
