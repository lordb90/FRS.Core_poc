using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfEmplq
{
    public string Key { get; set; } = null!;

    public string Question { get; set; } = null!;

    public string Answer { get; set; } = null!;
}
