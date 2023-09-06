using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class EclDeleted
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime Deleted { get; set; }

    public string Viewed { get; set; } = null!;

    public int Id { get; set; }
}
