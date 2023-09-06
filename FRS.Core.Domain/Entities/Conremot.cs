using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Conremot
{
    public string FcId { get; set; } = null!;

    public string SiteName { get; set; } = null!;

    public string ModemNbr { get; set; } = null!;

    public int Id { get; set; }
}
