using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class DisclSt
{
    public string State { get; set; } = null!;

    public string DisclBody { get; set; } = null!;

    public bool Clientflag { get; set; }

    public bool SubjFlag { get; set; }

    public bool LogoFlag { get; set; }

    public DateTime LastUpd { get; set; }

    public decimal FontSize { get; set; }

    public int Id { get; set; }
}
