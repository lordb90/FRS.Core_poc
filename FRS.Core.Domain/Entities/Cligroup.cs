using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Cligroup
{
    public string GroupName { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public int Id { get; set; }
}
