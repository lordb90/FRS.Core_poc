using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class RptMap
{
    public string Primary { get; set; } = null!;

    public int Sequence { get; set; }

    public string NodeName { get; set; } = null!;

    public string NodeType { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string RefType { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public decimal Precision { get; set; }

    public string Special { get; set; } = null!;

    public bool Required { get; set; }

    public bool Validated { get; set; }

    public string ValidMsg { get; set; } = null!;

    public int Id { get; set; }
}
