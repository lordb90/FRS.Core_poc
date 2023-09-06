using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Frsquery
{
    public string Queryid { get; set; } = null!;

    public string Querytype { get; set; } = null!;

    public string Queryname { get; set; } = null!;

    public string Sqlcode { get; set; } = null!;

    public bool Active { get; set; }

    public string Interval { get; set; } = null!;

    public string Sethrstart { get; set; } = null!;

    public string Sethrend { get; set; } = null!;

    public string Setminute { get; set; } = null!;

    public DateTime LastRun { get; set; }

    public string Xcaption { get; set; } = null!;

    public string Ycaption { get; set; } = null!;

    public decimal Defagraph { get; set; }

    public decimal Datatiers { get; set; }

    public string Legend1 { get; set; } = null!;

    public string Legend2 { get; set; } = null!;

    public string Legend3 { get; set; } = null!;

    public string Legend4 { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public string Setsecond { get; set; } = null!;

    public bool EdReposit { get; set; }

    public int Id { get; set; }
}
