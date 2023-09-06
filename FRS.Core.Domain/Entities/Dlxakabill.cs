using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Dlxakabill
{
    public string CompCode { get; set; } = null!;

    public string OstDesc { get; set; } = null!;

    public bool OrderAka { get; set; }

    public bool ChrgItem { get; set; }

    public bool ChrgPkg { get; set; }

    public string AddLoc { get; set; } = null!;

    public string Yesrectxt { get; set; } = null!;

    public string Norectxt { get; set; } = null!;

    public int Id { get; set; }
}
