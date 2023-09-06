using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class SqlBypass
{
    public decimal Key { get; set; }

    public int PfKey { get; set; }

    public string Tablename { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTime Lastattmpt { get; set; }

    public string Fromwhere { get; set; } = null!;

    public int Id { get; set; }
}
