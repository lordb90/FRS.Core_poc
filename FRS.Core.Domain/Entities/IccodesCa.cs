using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IccodesCa
{
    public string Code { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public int Id { get; set; }
}
