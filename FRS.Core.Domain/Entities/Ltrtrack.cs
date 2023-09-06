using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Ltrtrack
{
    public decimal SubjKey { get; set; }

    public string SubjName { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Lettertype { get; set; } = null!;

    public DateTime ReqDate { get; set; }

    public DateTime GenDtm { get; set; }

    public string GenUser { get; set; } = null!;

    public string DelivMeth { get; set; } = null!;

    public string AttchList { get; set; } = null!;

    public string Delivaddr { get; set; } = null!;

    public string Delivemail { get; set; } = null!;

    public int Id { get; set; }
}
