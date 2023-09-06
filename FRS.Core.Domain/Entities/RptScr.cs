using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class RptScr
{
    public string Primary { get; set; } = null!;

    public int Sequence { get; set; }

    public string Screentype { get; set; } = null!;

    public string Mediatype { get; set; } = null!;

    public bool Qualifier { get; set; }

    public string SubNode { get; set; } = null!;

    public string NodeName { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string RefType { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public decimal Precision { get; set; }

    public string Special { get; set; } = null!;

    public int Id { get; set; }
}
