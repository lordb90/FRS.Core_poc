using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IhrDlx
{
    public decimal Key { get; set; }

    public string SubjName { get; set; } = null!;

    public string OstDesc { get; set; } = null!;

    public string Frsproduct { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime DateAdd { get; set; }

    public string CompCode { get; set; } = null!;

    public int Id { get; set; }
}
