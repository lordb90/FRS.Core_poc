using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Conuser
{
    public string FcId { get; set; } = null!;

    public string SiteName { get; set; } = null!;

    public string LastVer { get; set; } = null!;

    public DateTime LastCall { get; set; }

    public decimal AvgCall { get; set; }

    public decimal Fusercall { get; set; }

    public string Fusertype { get; set; } = null!;

    public int Id { get; set; }
}
