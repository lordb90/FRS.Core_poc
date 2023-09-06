using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vnarchiv
{
    public decimal Key { get; set; }

    public decimal Weborder { get; set; }

    public string Vrcd { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Sdesc { get; set; } = null!;

    public DateTime ReqDate { get; set; }

    public string ReqTime { get; set; } = null!;

    public DateTime WebDate { get; set; }

    public string WebTime { get; set; } = null!;

    public DateTime WcompDate { get; set; }

    public string WcompTime { get; set; } = null!;

    public string Wresults { get; set; } = null!;

    public int Id { get; set; }
}
