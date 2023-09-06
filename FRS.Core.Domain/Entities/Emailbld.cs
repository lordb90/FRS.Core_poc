using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Emailbld
{
    public decimal EmailId { get; set; }

    public string Type { get; set; } = null!;

    public string Subtype { get; set; } = null!;

    public decimal Format { get; set; }

    public string Extrainfo1 { get; set; } = null!;

    public string Extrainfo2 { get; set; } = null!;

    public string Extrainfo3 { get; set; } = null!;

    public string Extrainfo4 { get; set; } = null!;

    public decimal ExtraNum { get; set; }

    public string ResNotes { get; set; } = null!;

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
