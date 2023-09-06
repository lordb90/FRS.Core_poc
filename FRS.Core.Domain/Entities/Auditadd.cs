using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;


public partial class Auditadd
{
    public string AuditKey { get; set; } = null!;

    public string Extrainfo { get; set; } = null!;

    public int Id { get; set; }
}
