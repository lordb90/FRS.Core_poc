using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IhrWork
{
    public decimal Key { get; set; }

    public bool Select { get; set; }

    public string Whattodo { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string Dob { get; set; } = null!;

    public string Casenbr { get; set; } = null!;

    public string Court { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Offense { get; set; } = null!;

    public string OffType { get; set; } = null!;

    public string OffDate { get; set; } = null!;

    public string Yrsincdisp { get; set; } = null!;

    public decimal Ptrec { get; set; }

    public bool DateDiscr { get; set; }

    public string AkaOnrec { get; set; } = null!;

    public int Id { get; set; }
}
