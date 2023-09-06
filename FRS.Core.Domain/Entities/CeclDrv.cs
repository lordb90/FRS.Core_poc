using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class CeclDrv
{
    public string Desc { get; set; } = null!;

    public decimal Position { get; set; }

    public decimal DispOrder { get; set; }

    public string Help { get; set; } = null!;

    public string Caution { get; set; } = null!;

    public string ReqCode { get; set; } = null!;

    public bool Active { get; set; }

    public decimal Greenbar { get; set; }

    public int Id { get; set; }
}
