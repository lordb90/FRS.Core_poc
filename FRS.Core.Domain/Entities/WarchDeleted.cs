using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class WarchDeleted
{
    public decimal Key { get; set; }

    public string Ssno { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public DateTime ReqDate { get; set; }

    public DateTime WebDate { get; set; }

    public string Viewed { get; set; } = null!;

    public string MgrViewed { get; set; } = null!;

    public string Mstrviewed { get; set; } = null!;

    public int Id { get; set; }
}
