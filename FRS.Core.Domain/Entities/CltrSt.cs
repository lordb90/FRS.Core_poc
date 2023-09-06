using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class CltrSt
{
    public string State { get; set; } = null!;

    public bool Clientflag { get; set; }

    public bool SubjFlag { get; set; }

    public bool CrhitFlag { get; set; }

    public int Id { get; set; }
}
