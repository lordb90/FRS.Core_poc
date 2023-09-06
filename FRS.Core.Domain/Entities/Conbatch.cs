using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Conbatch
{
    public string CompCode { get; set; } = null!;

    public decimal SrchqNbr { get; set; }

    public DateTime Pickupdate { get; set; }

    public string Pickuptime { get; set; } = null!;

    public string Cmode { get; set; } = null!;

    public int Id { get; set; }
}
