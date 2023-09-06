using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webready
{
    public decimal Key { get; set; }

    public string Ssno { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public DateTime ReqDate { get; set; }

    public string Partial { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string DispAlert { get; set; } = null!;

    public DateTime Posted { get; set; }

    public bool Lpbackup { get; set; }

    public string UnqOrder { get; set; } = null!;

    public int Id { get; set; }
}
