using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webhisti
{
    public decimal Key { get; set; }

    public DateTime DateStamp { get; set; }

    public string TimeStamp { get; set; } = null!;

    public string UnqOrder { get; set; } = null!;

    public int Id { get; set; }
}
