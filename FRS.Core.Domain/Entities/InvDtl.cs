using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class InvDtl
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public DateTime BasisDate { get; set; }

    public string DtlInfo { get; set; } = null!;

    public bool Lpbkup { get; set; }

    public string Invnum { get; set; } = null!;

    public int Id { get; set; }
}
