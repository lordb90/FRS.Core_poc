using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IhrIcm
{
    public decimal Key { get; set; }

    public string SubjName { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string IhrType { get; set; } = null!;

    public string Partial { get; set; } = null!;

    public string IhrDesc { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime DateAdd { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime RecDttm { get; set; }

    public string BegComm { get; set; } = null!;

    public int Id { get; set; }
}
