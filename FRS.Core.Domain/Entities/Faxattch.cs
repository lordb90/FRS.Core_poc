using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Faxattch
{
    public decimal Faxid { get; set; }

    public string Filename { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int Id { get; set; }
}
