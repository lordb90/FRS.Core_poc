using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class CtyList
{
    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Federal { get; set; } = null!;

    public int Id { get; set; }
}
