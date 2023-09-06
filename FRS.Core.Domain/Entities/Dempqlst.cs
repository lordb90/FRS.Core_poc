using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Dempqlst
{
    public string ShortDesc { get; set; } = null!;

    public string Question { get; set; } = null!;

    public decimal NbrAns { get; set; }

    public string Ans1 { get; set; } = null!;

    public string Ans2 { get; set; } = null!;

    public string Ans3 { get; set; } = null!;

    public string Ans4 { get; set; } = null!;

    public string Ans5 { get; set; } = null!;

    public int Id { get; set; }
}
