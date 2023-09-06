using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Trksetchg
{
    public DateTime Scdatetime { get; set; }

    public string Scuserid { get; set; } = null!;

    public string Scusername { get; set; } = null!;

    public string Sctype { get; set; } = null!;

    public string Scfulltype { get; set; } = null!;

    public string Scdescript { get; set; } = null!;

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public bool AdminOnly { get; set; }

    public int Id { get; set; }
}
