using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrglob
{
    public string Certname { get; set; } = null!;

    public bool FrzTudr { get; set; }

    public bool Disabletdr { get; set; }

    public string OstAlert { get; set; } = null!;

    public string OstMonitr { get; set; } = null!;

    public string Xtrafeedra { get; set; } = null!;

    public string Xtrafeedrm { get; set; } = null!;

    public int Id { get; set; }
}
