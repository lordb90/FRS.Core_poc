using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Frsdatum
{
    public decimal Nvalue1 { get; set; }

    public decimal Nvalue2 { get; set; }

    public decimal Nvalue3 { get; set; }

    public decimal Nvalue4 { get; set; }

    public string Clegend { get; set; } = null!;

    public bool Ldetach { get; set; }

    public int Ncolor { get; set; }

    public string Cxaxis { get; set; } = null!;

    public string Queryname { get; set; } = null!;

    public string Queryid { get; set; } = null!;

    public int Id { get; set; }
}
