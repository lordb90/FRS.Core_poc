using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Dempqmst
{
    public string ShortDesc { get; set; } = null!;

    public string LongDesc { get; set; } = null!;

    public decimal NumQuest { get; set; }

    public DateTime AddDate { get; set; }

    public DateTime EditDate { get; set; }

    public string Default { get; set; } = null!;

    public int Id { get; set; }
}
