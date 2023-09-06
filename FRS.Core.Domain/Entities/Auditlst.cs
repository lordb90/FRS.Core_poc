using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;


public partial class Auditlst
{
    public string Aucode { get; set; } = null!;

    public string Audesc { get; set; } = null!;

    public int Id { get; set; }
}
