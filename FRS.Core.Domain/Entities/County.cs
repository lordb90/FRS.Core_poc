using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class County
{
    public string County1 { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Federal { get; set; } = null!;

    public string AssocCty { get; set; } = null!;

    public string ExtraEta { get; set; } = null!;

    public decimal TatHrs { get; set; }

    public int Id { get; set; }
}
