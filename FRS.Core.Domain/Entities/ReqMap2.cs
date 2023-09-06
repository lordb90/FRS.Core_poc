using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ReqMap2
{
    public string Primary { get; set; } = null!;

    public int Sequence { get; set; }

    public string NodeName { get; set; } = null!;

    public string RootName { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string RefType { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public decimal DataSize { get; set; }

    public decimal Precision { get; set; }

    public string Special { get; set; } = null!;

    public bool Required { get; set; }

    public bool Validated { get; set; }

    public string ValidMsg { get; set; } = null!;

    public bool Exists { get; set; }

    public bool Stripbad { get; set; }

    public int Id { get; set; }
}
